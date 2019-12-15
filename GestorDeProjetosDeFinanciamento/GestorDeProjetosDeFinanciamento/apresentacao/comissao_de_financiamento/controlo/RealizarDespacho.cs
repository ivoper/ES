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
			throw new NotImplementedException();
		}
	}
}
