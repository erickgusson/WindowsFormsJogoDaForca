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
    public partial class FormJogo : Form
    {
        public FormJogo()
        {
            InitializeComponent();
        }

        string letrasTentadas = "";
        string palavra_secreta = "";

        private void FormJogo_Load(object sender, EventArgs e)
        {

            palavra_secreta = SortearPalavra();
            lbPalavraSecreta.Text = VerificarPalavra(palavra_secreta.ToCharArray(), letrasTentadas.ToCharArray());

        }

        //private string SortearPalavra()
        //{

        //    Lista de palavras
        //    List<string> palavras = new List<string> { "csharp", "python", "ruby", "php", "javascript" };

        //    Random rnd = new Random();
        //    int indiceSorteado = rnd.Next(0, palavras.Count);

        //    string palavraSorteada = palavras[indiceSorteado];

        //    return palavraSorteada;

        //}

        private string SortearPalavra()
        {

            string conexaoString = "server=62.72.62.1;user=u687609827_alunos;database=u687609827_TI21;port=3306;password=@Aluno12345";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {

                string scriptSQL = "SELECT palavra FROM tb_palavras";

                using (MySqlCommand comando = new MySqlCommand(scriptSQL, conexao))
                {

                    conexao.Open();

                    List<string> palavrasBanco = new List<string>();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string palavra = reader.GetString(0);
                            palavrasBanco.Add(palavra);


                        }
                    }

                    conexao.Close();

                    Random rnd = new Random();
                    int indiceSorteado = rnd.Next(0, palavrasBanco.Count);

                    return palavrasBanco[indiceSorteado];


                }

            }

        }

        private char[] SepararLetraPalavra(string palavra)
        {

            //Criando um array do tamanho da palavra que foi sorteada
            char[] letrasPalavras = new char[palavra.Length];

            letrasPalavras = palavra.ToCharArray();

            return letrasPalavras;

        }

        private void btnVerificarLetra_Click(object sender, EventArgs e)
        {

            string letra = txbTentativa.Text;

            bool letraRepitida = false;
            for (int i = 0; i < letrasTentadas.Length; i++)
            {


                if (letrasTentadas[i].ToString() == letra)
                {

                    MessageBox.Show("Essa letra ja foi tentada");
                    letraRepitida = true;

                }

            }

            int verificarSeGanhou = 1;

            if (!letraRepitida)
            {

                letrasTentadas += letra;

                char[] letrasDaPalavras = SepararLetraPalavra(palavra_secreta);
                string palavra_exibicao = VerificarPalavra(letrasDaPalavras, letrasTentadas.ToCharArray());

                lbPalavraSecreta.Text = palavra_exibicao;

                verificarSeGanhou = 0;
                for (int i = 0; i < palavra_exibicao.Length; i++)
                {

                    if (palavra_exibicao[i] == '_')
                    {

                        verificarSeGanhou++;

                    }

                }

            }

            if (verificarSeGanhou == 0)
            {

                MessageBox.Show("Você ganhou");
                this.Close();

            }

                letraRepitida = false;
            txbTentativa.Text = "";

        }



        private string VerificarPalavra(char[] palavra, char[] letraTentadas)
        {

            string palavra_escondida = "";

            //Laço de repetição para esconder a palavra
            for (int i = 0; i < palavra.Length; i++)
            {

                bool letraAcertada = false;
                for (int j = 0; j < letraTentadas.Length; j++)
                {

                    if (palavra[i] == letrasTentadas[j])
                    {

                        palavra_escondida += palavra[i];
                        letraAcertada = true;

                    }

                }

                if (!letraAcertada)
                {

                    palavra_escondida += " _";

                }


            }

            return palavra_escondida;

        }



    }
}
