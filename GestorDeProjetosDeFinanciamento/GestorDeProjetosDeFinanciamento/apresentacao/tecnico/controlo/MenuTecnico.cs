using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
    class MenuTecnico : Apresentador<FormMenuTecnico, MenuArgs>
    {

        public delegate void ButtonClick(object sender, MenuArgs eventArgs);

        public MenuTecnico(): base(new FormMenuTecnico())
        {
            Vista.ShowDialog();
            Vista.Notificavel = this;
        }

        public override void Notificar(MenuArgs args)
        {
            switch (args.buttonClicked)
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
                    Console.WriteLine("something went wrong, probablly button names.");
                    break;
            }
        }
    }
}