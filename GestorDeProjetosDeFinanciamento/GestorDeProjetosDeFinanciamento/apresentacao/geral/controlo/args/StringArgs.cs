using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
    public class StringArgs : EventArgs
    {
        public readonly string texto;

        public StringArgs(string t)
        {
            texto = t;
        }
    }
}
