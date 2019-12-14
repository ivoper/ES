using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
    public class SimplesArgs : EventArgs
    {
        public readonly string botaoClicado;

        public SimplesArgs(string botao)
        {
            botaoClicado = botao;
        }
    }
}
