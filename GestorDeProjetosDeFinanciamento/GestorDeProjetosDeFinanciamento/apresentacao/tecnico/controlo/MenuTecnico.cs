using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    break;
                case "reenquadrarProjeto":

                    break;
                case "suspenderProjeto":

                    break;
                case "reativarProjeto":

                    break;
                default:
                    Console.WriteLine("Algo Correu Mal... Nome de botao errado.");
                    break;
            }
        }
    }
}