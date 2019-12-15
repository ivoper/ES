using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
	class ReforcoDeFinanciamento : Apresentador<FormReforcoDeFinanciamento, ReforcoDeFinanciamentoArgs>
	{
		public ReforcoDeFinanciamento() : base(new FormReforcoDeFinanciamento())
		{
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(ReforcoDeFinanciamentoArgs args)
		{
			//TODO ta testado pelo duduzan ta bom :) data é tb dia/mes/ano
			Console.WriteLine(args.data);
			Console.WriteLine(args.montante);
			Vista.Hide();
			Vista.Close();
		}
	}
}
