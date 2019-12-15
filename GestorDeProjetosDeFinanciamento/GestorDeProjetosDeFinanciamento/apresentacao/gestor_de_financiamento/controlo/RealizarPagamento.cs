using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
	class RealizarPagamento : Apresentador<FormRealizarPagamento, RealizarPagamentoArgs>
	{

		public RealizarPagamento() : base(new FormRealizarPagamento())
		{
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(RealizarPagamentoArgs args)
		{
			//TODO testado pelo duduzan ta bom :)
			Console.WriteLine(args.montante);
			Vista.Hide();
			Vista.Close();
		}
	}
}
