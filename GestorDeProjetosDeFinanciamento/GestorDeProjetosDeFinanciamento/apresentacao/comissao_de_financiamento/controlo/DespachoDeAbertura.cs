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
			EstadosProjeto estadoAntigo;
			Enum.TryParse(projeto.estado, out estadoAntigo);
			EstadosProjeto novoEstado = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.despacho_aprovado);
			projeto.estado = Enum.GetName(typeof(EstadosProjeto), novoEstado);
			servicoProjetos.AtualizarProjeto(projeto);
			Vista.Hide();
			Vista.Close();
		}
	}
}
