using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
	class ApresentarCandidatura : Apresentador<FormApresentarCandidatura, ApresentarCandidaturaArgs>
	{
		public ApresentarCandidatura() : base(new FormApresentarCandidatura())
		{
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(ApresentarCandidaturaArgs args)
		{
			//TODO fully testado pelo duduzan e ta bom :)
			Console.WriteLine("descricao " +args.descricao);
			Console.WriteLine("designacaoPromotor " + args.designacaoPromotor);
			Console.WriteLine("designacaoResponsavel " + args.designacaoResponsavel);
			Console.WriteLine("email " + args.email);
			Console.WriteLine("montante " + args.montante);
			Console.WriteLine("nacionalidade " + args.nacionalidade);
			Console.WriteLine("NIB " + args.NIB);
			Console.WriteLine("NIF " + args.NIF);
			Console.WriteLine("telefone " + args.telefone);
			Console.WriteLine("tipo " + args.tipo);
			Vista.Hide();
			Vista.Close();
		}
	}
}
