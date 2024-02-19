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
            listViewCadastro.Columns.Add("palavras", 255);

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

                    string scriptSQL = "INSERT INTO tb_palavras (palavra) VALUEs (@valorPalavra)";

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

        private void RemoverDados(int id)
        {

            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {

                    string scriptSQL = "INSERT INTO tb_palavras (palavra) VALUEs (@valorPalavra)";

                    using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                    {

                        conexao.Open();

                        //comando.Parameters.AddWithValue("@valorPalavra");

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

        private void btnRemover_Click(object sender, EventArgs e)
        {

            int selecionado = 0;

            RemoverDados(selecionado);

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
