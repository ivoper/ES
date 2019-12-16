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

		public AlterarDadosListarProjetos(User currentUser)
		{
			initEstados(currentUser);
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

		private void initEstados(User user)
		{
			estados = new List<EstadosProjeto>(user.estadosValidos);
			estados.Remove(EstadosProjeto.rejeitado);
			estados.Remove(EstadosProjeto.suspenso);
			estados.Remove(EstadosProjeto.espera_despacho);
			estados.Remove(EstadosProjeto.espera_reforco);
			estados.Remove(EstadosProjeto.pagamento);
			estados.Remove(EstadosProjeto.fechado);
		}

	}
}
