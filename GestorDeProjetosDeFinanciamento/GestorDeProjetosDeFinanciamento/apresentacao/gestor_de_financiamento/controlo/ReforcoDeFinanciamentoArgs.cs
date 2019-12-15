using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
	public class ReforcoDeFinanciamentoArgs : EventArgs
	{
		public readonly String montante;
		public readonly String data;

		public ReforcoDeFinanciamentoArgs(String montante, String data)
		{
			this.montante = montante;
			this.data = data;
		}
	}
}
