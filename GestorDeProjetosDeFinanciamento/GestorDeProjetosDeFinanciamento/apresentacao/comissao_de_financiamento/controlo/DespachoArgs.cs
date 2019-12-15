using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo
{
	public class DespachoArgs : EventArgs
	{
		public readonly String resultado;
		public readonly String custoElegivel;
		public readonly String montante;
		public readonly String prazo;

		public DespachoArgs(String resultado, String custoElegivel, String montante, String prazo)
		{
			this.resultado = resultado;
			this.custoElegivel = custoElegivel;
			this.montante = montante;
			this.prazo = prazo;
		}
	}
}
