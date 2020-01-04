using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
	class ReativarProjeto : ListarProjetos
	{
		private readonly EstadosProjeto estado = EstadosProjeto.suspenso;       //só vai ter um
		private ObterEstados servicoObterEstados;

		public ReativarProjeto(Utilizador utilizador)
		{
            string estadoString = Enum.GetName(typeof(EstadosProjeto), estado);   //passa de Estados para string
            Vista.Notificavel = this;
			servicoObterEstados = ObterEstados.ObterInstancia();
            projetos = servicoProjetos.ProjetosComHistorico(estadoString).ToList();
			IEnumerable<string> estadosString = servicoObterEstados
				.ObterEstadosValidos(utilizador)
				.Select(e => e.estado1)
				.ToList();
            projetos = projetos
				.Where(p => estadosString.Contains(servicoObterEstados.ObterEstado(p.estado).estado1))
				.ToList();
            listar();
			Vista.ShowDialog();
		}

		public override void Notificar(IntArgs args)
		{
			Projeto projeto = projetos[args.valor];				//projeto com id e estado para colocar
            Projeto aux = servicoProjetos.LerProjeto(projeto);  //projeto que tem todos os detalhes
            aux.estado = projeto.estado;                        //atualizar estado
			servicoProjetos.AtualizarProjeto(aux);
			Historico historico = servicoHistorico.LerHistorico(new Historico() { 
				id_projeto = projeto.id
			});
            servicoHistorico.EliminarHistorico(historico);
			Vista.Hide();
			Vista.Close();
		}
	}
}
