using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo
{
	class RealizarDespacho : Apresentador<FormRealizarDespacho, StringArgs>
	{
		private Projeto projeto;
		private CRUDProjetos servicoProjetos;
        private CRUDDespacho servicoDespacho;
		private ObterEstados servicoObterEstados;

        public RealizarDespacho(Projeto projetoSelecionado) : base(new FormRealizarDespacho())
		{
			servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoDespacho = CRUDDespacho.ObterInstancia();
			servicoObterEstados = ObterEstados.ObterInstancia();
			projeto = projetoSelecionado;
			confirmarTipo();
			Vista.Notificavel = this;
			Vista.ShowDialog();
			
		}

		public override void Notificar(StringArgs args)
		{
			string resultado = args.texto;

			Vista.Hide();
			Vista.Close();
			switch (resultado)
			{
				case "Aprovado":
					AprovarProjeto(resultado);
					break;
				case "Rejeitado":
					RejeitarProjeto(resultado);
					break;
				case "Transformado em Bonificação":
					new RealizarDespachoBonificacao(projeto, "transformado");
					break;
			}
		}

		private void RejeitarProjeto(String resultado)
		{
			Despacho despachoRejeitar = new Despacho()
			{
				id_projeto = projeto.id,
				resultado = resultado.ToLower(),
				data_despacho = DateTime.Now
			};
			int idDespacho = servicoDespacho.CriarDespacho(despachoRejeitar);

			if (projeto.Incentivo != null)
			{
				DespachoIncentivo despachoIncentivo = new DespachoIncentivo()
				{
					id_despacho = idDespacho,
					montante = null,
					custo_elegivel = null,
					prazo_execucao = null
				};
				servicoDespacho.CriarDespachoIncentivo(despachoIncentivo);
			}
			if (projeto.Bonificacao != null)
			{
				DespachoBonificacao despachoBonificacao = new DespachoBonificacao()
				{
					id_despacho = idDespacho,
					montante_maximo = null,
					periodo = null,
					taxa = null
				};
				servicoDespacho.CriarDespachoBonificacao(despachoBonificacao);
			}

			string estado = servicoObterEstados.ObterEstado(projeto.estado).estado1;
			string estadoNovo = Utils.EstadoParaString(MaquinaDeEstados.processar(Utils.StringParaEstado(estado), EventosProjeto.despacho_rejeitado));
			projeto.estado = servicoObterEstados.ObterIdEstado(estadoNovo);
			servicoProjetos.AtualizarProjeto(projeto);
		}

		private void AprovarProjeto(String resultado)
		{
			if (projeto.Bonificacao != null)
				new RealizarDespachoBonificacao(projeto, resultado);
			if (projeto.Incentivo != null)
				new RealizarDespachoIncentivo(projeto, resultado);
		}

		private void confirmarTipo()
		{
			projeto = servicoProjetos.LerProjeto(projeto);
			if (projeto.Incentivo != null)
			{
				Vista.adicionarListBox();
			}
		}
	}
}
