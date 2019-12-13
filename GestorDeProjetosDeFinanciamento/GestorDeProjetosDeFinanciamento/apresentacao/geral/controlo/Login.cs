using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;

namespace GestorDeProjetosDeFinanciamento.apresentacao
{
    public class Login : Apresentador<FormLogin>
    {
        
        public delegate void LoginClick(object sender, LoginArgs eventArgs);
        private Autenticacao autenticacao;

        public Login() : base(new FormLogin())
        {
            autenticacao = Autenticacao.ObterInstancia();
            Vista.OnLoginClick += new LoginClick(OnLoginClick);
            Vista.ShowDialog();
        }

        private void OnLoginClick(object sender, LoginArgs eventArgs)
        {
            User user = autenticacao.FazerLogin(eventArgs.username, eventArgs.password);

            if (user == null)
            {
                Erro erro = new Erro("Wrong Credentials.");
                Vista.ApagarTexto();
                
            }
            else
            {
                Console.WriteLine("User");
            }
        }

    }
}
