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
		public readonly String taxa;
		public readonly String periodo;
		public readonly String montante_maximo;

		public DespachoArgs(String resultado, String custoElegivel, String montante, String prazo,String taxa,String periodo,String montante_maximo)
		{
			this.resultado = resultado;
			this.custoElegivel = custoElegivel;
			this.montante = montante;
			this.prazo = prazo;
			this.taxa = taxa;
			this.periodo = periodo;
			this.montante_maximo = montante_maximo;
		}
	}
}
