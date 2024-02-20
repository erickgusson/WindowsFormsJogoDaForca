using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsJogoDaForca
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {

            listViewCadastro.Items.Clear();

            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {

                string scriptSQL = "SELECT id, palavra FROM tb_palavras";

                using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                {

                    conexao.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            int id = reader.GetInt32(0);
                            string palavra = reader.GetString(1);

                            ListViewItem lista = new ListViewItem(id.ToString() + " - " + palavra);
                            listViewCadastro.Items.Add(lista);


                        }
                    }

                    conexao.Close();

                }

            }

        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {

            listViewCadastro.View = View.Details;
            listViewCadastro.Columns.Add("Palavras", 255);

            CarregarDados();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string palavraEscolhida = txbCadastro.Text;

            if (palavraEscolhida.Trim() != "")
            {

                CadastrarDados(palavraEscolhida);

            }

            txbCadastro.Text = "";
            listViewCadastro.Items.Clear();
            CarregarDados() ;



        }

        private void CadastrarDados(string palavra)
        {

            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {

                    string scriptSQL = "INSERT INTO tb_palavras (palavra) VALUES (@valorPalavra)";

                    using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                    {

                        conexao.Open();

                        comando.Parameters.AddWithValue("@valorPalavra", palavra.ToLower());

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {

                            MessageBox.Show("Palavra cadastrar com suesso");

                        }

                    }

                    conexao.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar informação: " + ex.Message);
            }
        }

        private void RemoverDados()
        {

            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {

                    string scriptSQL = "DELETE FROM tb_palavras WHERE id = (@idRemovido)";

                    using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                    {

                        conexao.Open();

                        comando.Parameters.AddWithValue("@idRemovido", txbIDRemover.Text);

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {

                            MessageBox.Show("Palavra removida com suesso");

                        }

                    }

                    conexao.Close();

                    CarregarDados();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar informação: " + ex.Message);
            }
        }

        private void AtualizarDados()
        {

            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {

                    string scriptSQL = "UPDATE tb_palavras SET palavra = (@palavraAtualizada) WHERE id = (@idAtualizado)";

                    using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                    {

                        conexao.Open();

                        comando.Parameters.AddWithValue("@palavraAtualizada", txbPalavraAtualizada.Text);
                        comando.Parameters.AddWithValue("@idAtualizado", txbIDAtualizar.Text);

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {

                            MessageBox.Show("Palavra atualizada com suesso");

                        }

                    }

                    conexao.Close();

                    CarregarDados();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar informação: " + ex.Message);
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {

            RemoverDados();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            AtualizarDados();

        }

    }
}
