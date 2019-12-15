using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
	public class RealizarPagamentoArgs : EventArgs
	{
		public readonly String montante;

		public RealizarPagamentoArgs(String montante)
		{
			this.montante = montante;
		}
	}
}
