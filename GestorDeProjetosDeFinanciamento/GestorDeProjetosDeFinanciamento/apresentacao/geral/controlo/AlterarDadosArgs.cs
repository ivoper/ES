using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
	public class AlterarDadosArgs : EventArgs
	{
		public readonly string novoEmail;
		public readonly string novoTelefone;

		public AlterarDadosArgs(string novoEmail, string novoTelefone)
		{
			this.novoEmail = novoEmail;
			this.novoTelefone = novoTelefone;
		}
	}
}
