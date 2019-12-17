using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
	public class ApresentarCandidaturaArgs : EventArgs
	{
		public readonly String designacaoPromotor;
		public readonly String nacionalidade;
		public readonly String NIF;
		public readonly String NIB;
		public readonly String designacaoResponsavel;
		public readonly String email;
		public readonly String telefone;
		public readonly String montante;
		public readonly String tipo;
		public readonly String descricao;

		public ApresentarCandidaturaArgs(String designacaoPromotor, String nacionalidade, String NIF, String NIB, String designacaoResponsavel, String email, String telefone, String montante, String tipo, String descricao)
		{
			this.designacaoPromotor = designacaoPromotor;
			this.nacionalidade = nacionalidade;
			this.NIF = NIF;
			this.NIB = NIB;
			this.designacaoResponsavel = designacaoResponsavel;
			this.email = email;
			this.telefone = telefone;
			this.montante = montante;
			this.tipo = tipo;
			this.descricao = descricao;
		}
	}
}
