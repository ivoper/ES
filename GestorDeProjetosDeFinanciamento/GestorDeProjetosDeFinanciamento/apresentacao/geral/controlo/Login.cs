using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo;
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
            if (args.username.Equals("") || args.password.Equals(""))
            {
                Erro erro = new Erro("Por favor preencha todos os campos necessários");
                return;
            }
            
            Utilizador user = autenticacao.FazerLogin(args.username, args.password);

            if (user == null)
            {
                Erro erro = new Erro("Credenciais Erradas... Username e/ou Password não correspondem, tente novamente.");
                Vista.ApagarTexto();
                return;
            }
            
            Vista.Hide();
            Vista.Close();
            if (user.Tecnico != null)
                new MenuTecnico(user.Tecnico);

            else if (user.GestorDeFinanciamento != null)
                new MenuGestor(user.GestorDeFinanciamento);

            else if (user.ComissaoDeFinanciamento != null)
                new MenuComissao(user.ComissaoDeFinanciamento);
            /*switch (user)
            {
                case Tecnico t:
                    new MenuTecnico(t);
                    break;
                case GestorDeFinanciamento g:
                    new MenuGestor(g);
                    break;
				case ComissaoDeFinanciamento c:
                    new MenuComissao(c);
                    break;
            }*/
			
        }
    }
}
