using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
    public class IntArgs : EventArgs
    {
        public readonly int valor;

        public IntArgs(int num)
        {
            valor = num;
        }
    }
}
