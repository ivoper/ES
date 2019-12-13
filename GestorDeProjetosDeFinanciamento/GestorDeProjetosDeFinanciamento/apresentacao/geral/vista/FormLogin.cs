using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using System;
using System.Windows.Forms;
using static GestorDeProjetosDeFinanciamento.apresentacao.Login;

namespace GestorDeProjetosDeFinanciamento
{
    public partial class FormLogin : Form
	{
        public event LoginClick OnLoginClick;

        public FormLogin()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
            LoginArgs loginArgs = new LoginArgs(usernameTextBox.Text, passwordTextBox.Text);
            //throw event
            OnLoginClick(this, loginArgs);
		}

        public void ApagarTexto()
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }
    }
}
