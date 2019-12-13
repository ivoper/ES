using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
    public class MenuArgs : EventArgs
    {
        public readonly string buttonClicked;

        public MenuArgs(string button)
        {
            buttonClicked = button;
        }
    }
}
