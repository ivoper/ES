using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo
{
	class RealizarDespacho : Apresentador<FormRealizarDespacho, DespachoArgs>
	{
		public RealizarDespacho() : base(new FormRealizarDespacho())
		{
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(DespachoArgs args)
		{
			Console.WriteLine(args.custoElegivel);  //TODO a data veio como 15/01/2020 (dia/mes/ano) pode dar 
			Console.WriteLine(args.montante);   // problemas depois pa base de dados mas de resto da bom
			Console.WriteLine(args.prazo);
			Console.WriteLine(args.resultado);
		}
	}
}
