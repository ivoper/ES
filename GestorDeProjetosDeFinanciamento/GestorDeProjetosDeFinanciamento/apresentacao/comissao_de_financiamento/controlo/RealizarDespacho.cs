using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo
{
	class RealizarDespacho : Apresentador<FormRealizarDespacho, DespachoArgs>
	{
		private Projeto projeto;
		private CRUDProjetos servicoProjetos;
        private CRUDDespacho servicoDespacho;

        public RealizarDespacho(Projeto projetoSelecionado) : base(new FormRealizarDespacho())
		{
			servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoDespacho = CRUDDespacho.ObterInstancia();
            projeto = projetoSelecionado;
			Vista.Notificavel = this;
			Vista.ShowDialog();
			
		}

		public override void Notificar(DespachoArgs args)
		{
			if (verificarArgumentos(args))
			{
				new Erro("Por favor preencha todos os campos necessários");
				return;
			}

            servicoDespacho.CriarDespacho(new Despacho()
			{
				id_projeto = projeto.id,
				resultado = args.resultado,
				custo_elegivel = args.resultado.Equals("Aprovado") ? Convert.ToDouble(args.custoElegivel) : 0,
                prazo_execucao = Convert.ToDateTime(args.prazo),
				montante = args.resultado.Equals("Aprovado")? Convert.ToDouble(args.montante) : 0,
				data_despacho = DateTime.Now
			});

            EstadosProjeto estadoAntigo = Utils.StringParaEstado(projeto.estado);
			EstadosProjeto novoEstado;

			if (args.resultado.Equals("Aprovado") || args.resultado.Equals("Transformado em Bonificação"))
			{
				novoEstado = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.despacho_aprovado);
			}
			else
			{
				novoEstado = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.despacho_rejeitado);
			}
            projeto.estado = Utils.EstadoParaString(novoEstado);
			if (args.resultado.Equals("Transformado em Bonificação")) projeto.tipo = "bonificacao";
			servicoProjetos.AtualizarProjeto(projeto);
			Vista.Hide();
			Vista.Close();
		}

		private bool verificarArgumentos(DespachoArgs despacho)
		{
            double d;
            if (DateTime.Compare(Convert.ToDateTime(despacho.prazo), DateTime.Now) <= 0) return true;
			if (despacho.resultado != "Aprovado" && despacho.resultado != "") return false;
            if (Double.TryParse(despacho.montante, out d) && Double.TryParse(despacho.custoElegivel, out d)) return false;
            return true;
		}
	}
}
