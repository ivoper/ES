using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
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
		private ObterEstados servicoObterEstados;

		public DespachoDeAbertura()
		{
			servicoObterEstados = ObterEstados.ObterInstancia();
			string estadoString = Enum.GetName(typeof(EstadosProjeto), estado);   
			Vista.Notificavel = this;
			projetos = servicoProjetos.ProjetosEstado(estadoString);
			listar();
			Vista.ShowDialog();
		}

		public override void Notificar(IntArgs args)
		{
			Projeto projeto = projetos[args.valor];
			String estado = servicoObterEstados.ObterEstado(projeto.estado).estado1;
			String estadoNovo = Utils.EstadoParaString(MaquinaDeEstados.processar(
                Utils.StringParaEstado(estado), 
                EventosProjeto.despacho_aprovado));

			projeto.estado = servicoObterEstados.ObterIdEstado(estadoNovo);
			servicoProjetos.AtualizarProjeto(projeto);
			Vista.Hide();
			Vista.Close();
		}
	}
}
