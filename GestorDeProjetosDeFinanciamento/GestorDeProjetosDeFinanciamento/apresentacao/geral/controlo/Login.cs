using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;

namespace GestorDeProjetosDeFinanciamento.apresentacao
{
    class Login : Apresentador<FormLogin, LoginArgs>
    {        
        private Autenticacao autenticacao;

        public Login() : base(new FormLogin())
        {
            autenticacao = Autenticacao.ObterInstancia();
            Vista.Notificavel = this;
            Vista.ShowDialog();
        }

        public override void Notificar(LoginArgs args)
        {
            User user = autenticacao.FazerLogin(args.username, args.password);

            if (user == null)
            {
                Erro erro = new Erro("Credenciais Erradas... Username e/ou Password não correspondem, tente novamente.");
                Vista.ApagarTexto();
            }
            else
            {
                Vista.Hide();
                Vista.Close();
                switch(user)
                {
                    case Tecnico t:
                        new MenuTecnico();
                        break;
                    case GestorDeFinanciamento g:
                        //new GestorDeFinanciamento();
                        break;
                    case ComissaoDeFinanciamento c:
                        //new ComissaoDeFinanciamento();
                        break;
                }

                
            }
        }

    }
}
