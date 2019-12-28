using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
	class AlterarDadosListarProjetos : ListarProjetos
	{
		private List<EstadosProjeto> estados;
		private ObterEstados servicoObterEstados;

		public AlterarDadosListarProjetos(Utilizador currentUser)
		{
			initEstados(currentUser);
			servicoObterEstados = ObterEstados.ObterInstancia();
			IEnumerable<string> estadosString = estados.Select(e => Enum.GetName(typeof(EstadosProjeto), e));
			Vista.Notificavel = this;
			projetos = servicoProjetos.ProjetosEstado(estadosString);
			listar();
			Vista.ShowDialog();
		}

		public override void Notificar(IntArgs args)
		{
			Projeto projeto = projetos[args.valor];
			Vista.Hide();
			Vista.Close();
			new AlterarDados(projeto);
		}

		private void initEstados(Utilizador user)
		{
			estados = servicoObterEstados
				.ObterEstadosValidos(user)
				.Select(e => Utils.StringParaEstado(e.estado1))
				.ToList();
			estados.Remove(EstadosProjeto.rejeitado);
			estados.Remove(EstadosProjeto.suspenso);
			estados.Remove(EstadosProjeto.espera_despacho);
			estados.Remove(EstadosProjeto.espera_reforco);
			estados.Remove(EstadosProjeto.pagamento);
			estados.Remove(EstadosProjeto.fechado);
		}

	}
}
