using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo
{
	class DespachoDeAbertura : ListarProjetos
	{
		private EstadosProjeto estado = EstadosProjeto.aberto;   

		public DespachoDeAbertura()
		{
			string estadoString = Enum.GetName(typeof(EstadosProjeto), estado);   
			Vista.Notificavel = this;
			projetos = servicoProjetos.ProjetosEstado(estadoString);
			listar();
			Vista.ShowDialog();
		}

		public override void Notificar(IntArgs args)
		{
			Projeto projeto = projetos[args.valor];
			projeto.estado = Utils.EstadoParaString(MaquinaDeEstados.processar(
                Utils.StringParaEstado(projeto.estado), 
                EventosProjeto.despacho_aprovado));
			servicoProjetos.AtualizarProjeto(projeto);
			Vista.Hide();
			Vista.Close();
		}
	}
}
