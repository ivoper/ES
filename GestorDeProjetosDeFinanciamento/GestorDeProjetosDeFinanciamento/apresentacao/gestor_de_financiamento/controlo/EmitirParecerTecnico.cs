using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
	class EmitirParecerTecnico : Apresentador<FormEmitirParecerTecnico, EmitirParecerTecnicoArgs>
	{
		public EmitirParecerTecnico() : base(new FormEmitirParecerTecnico())
		{
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(EmitirParecerTecnicoArgs args)
		{
			//TODO foi testado pelo duduzan e ta bom :)
			Console.WriteLine(args.decisao);
			Console.WriteLine(args.texto);
			Vista.Hide();
			Vista.Close();
		}
	}
}
