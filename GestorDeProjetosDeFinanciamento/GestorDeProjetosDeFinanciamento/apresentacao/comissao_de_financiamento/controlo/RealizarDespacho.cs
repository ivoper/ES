using GestorDeProjetosDeFinanciamento.acesso_a_dados;
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
		private CRUDProjetos servico;

		public RealizarDespacho(Projeto projetoSelecionado) : base(new FormRealizarDespacho())
		{
			servico = CRUDProjetos.ObterInstancia();
			projeto = projetoSelecionado;
			Vista.Notificavel = this;
			Vista.ShowDialog();
			
		}

		public override void Notificar(DespachoArgs args)
		{
			if (verificarArgumentos(args))
			{
				Erro erro = new Erro("Por favor preencha todos os campos necessários");
				return;
			}
			servico.CriarDespacho(new Despacho()
			{
				id_projeto = projeto.id,
				resultado = args.resultado,
				custo_elegivel = Convert.ToDouble(args.custoElegivel),
				prazo_execucao = Convert.ToDateTime(args.prazo),
				montante = Convert.ToDouble(args.montante),
				data_despacho = DateTime.Now
			});
			EstadosProjeto estadoAntigo;
			Enum.TryParse(projeto.estado, out estadoAntigo);
			EstadosProjeto novoEstado;
			if (args.resultado.Equals("Aprovado") || args.resultado.Equals("Transformado em Bonificação"))
			{
				novoEstado = MaquinaDeEstados.processar(estadoAntigo, Evento.despacho_aprovado);
			}
			else
			{
				novoEstado = MaquinaDeEstados.processar(estadoAntigo, Evento.despacho_rejeitado);
			}
			projeto.estado = Enum.GetName(typeof(EstadosProjeto), novoEstado);
			if (args.resultado.Equals("Transformado em Bonificação")) projeto.tipo = "bonificacao";
			servico.AtualizarProjeto(projeto);
			Vista.Hide();
			Vista.Close();
		}

		private bool verificarArgumentos(DespachoArgs despacho)
		{
			if(despacho.resultado != "Aprovado" && despacho.resultado != "") return false;
			return despacho.custoElegivel == "" || despacho.montante == ""  || despacho.resultado == "";
		}
	}
}
