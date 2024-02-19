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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {

            Form formJogo = new FormJogo(); //Criando uma instância do nosso formulário

            formJogo.ShowDialog(); //Pedindo para abrir o formulário

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Form formCadastrar = new FormCadastrar(); //Criando uma instância do nosso formulário

            formCadastrar.ShowDialog(); //Pedindo para abrir o formulário

        }
    }
}
