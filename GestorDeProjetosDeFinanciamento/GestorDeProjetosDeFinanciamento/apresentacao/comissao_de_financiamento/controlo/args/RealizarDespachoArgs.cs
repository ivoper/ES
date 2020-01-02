using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo.args
{
    public class RealizarDespachoArgs : EventArgs
    {

        public readonly string val1, val2, data;

        public RealizarDespachoArgs(string val1, string val2, string data)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.data = data;
        }
    }
}
