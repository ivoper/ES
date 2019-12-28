using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista;
using GestorDeProjetosDeFinanciamento.dominio;
using System;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
    class MenuTecnico : Apresentador<FormMenuTecnico, StringArgs>
    {
        private Tecnico tecnico;

        public MenuTecnico(Tecnico tecnico): base(new FormMenuTecnico())
        {
            this.tecnico = tecnico;
            Vista.AlterarNome(tecnico.Utilizador.username);
            Vista.Notificavel = this;
            Vista.ShowDialog();
        }

        public override void Notificar(StringArgs args)
        {
            switch (args.texto)
            {
                case "apresentarCandidatura":
					new ApresentarCandidatura(tecnico);
                    break;
                case "reenquadrarProjeto":
                    new ReenquadrarProjeto(tecnico);
					break;
                case "consulta":
                    new ConsultarListarProjetos(tecnico.Utilizador);
                    break;
				case "logout":
					Vista.Hide();
					Vista.Close();
					new Login();
					break;
				default:
                    Console.WriteLine("Algo Correu Mal... Nome de botao errado.");
                    break;
            }
        }
    }
}