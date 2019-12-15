using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
	public class EmitirParecerTecnicoArgs : EventArgs
	{
		public readonly String texto;
		public readonly String decisao;

		public EmitirParecerTecnicoArgs(String texto, String decisao)
		{
			this.texto = texto;
			this.decisao = decisao;
		}
	}
}
