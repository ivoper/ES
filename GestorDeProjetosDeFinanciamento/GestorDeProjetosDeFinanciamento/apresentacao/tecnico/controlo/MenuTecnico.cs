using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista;
using System;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
    class MenuTecnico : Apresentador<FormMenuTecnico, SimplesArgs>
    {
        public MenuTecnico(): base(new FormMenuTecnico())
        {
            Vista.Notificavel = this;
            Vista.ShowDialog();
        }

        public override void Notificar(SimplesArgs args)
        {
            switch (args.botaoClicado)
            {
                case "apresentarCandidatura":
					new ApresentarCandidatura();
                    break;
                case "reenquadrarProjeto":
					new ListarProjetos();
					break;
                case "suspenderProjeto":
					new ListarProjetos();
					break;
                case "reativarProjeto":
					new ListarProjetos();
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