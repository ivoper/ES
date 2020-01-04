using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
    class SuspenderProjeto : ListarProjetos
    {
		private List<EstadosProjeto> estados;
        private ObterEstados servicoObterEstados;

		public SuspenderProjeto(Utilizador utilizador) 
        {
            servicoObterEstados = ObterEstados.ObterInstancia();
            initEstados(utilizador);
            IEnumerable<string> estadosString = estados.Select(e => Enum.GetName(typeof(EstadosProjeto), e));   //passa de Estados para string
            Vista.Notificavel = this;
            projetos = servicoProjetos.ProjetosEstado(estadosString);
            listar();
            Vista.ShowDialog();
        }

        public override void Notificar(IntArgs args)
        {
            Projeto projeto = projetos[args.valor];
            servicoHistorico.CriarHistorico(new Historico
			{
				id_projeto = projeto.id,
				estado = projeto.estado
			});
            String estado = servicoObterEstados.ObterEstado(projeto.estado).estado1;
            String novoEstado = Utils.EstadoParaString(MaquinaDeEstados.processar(
                Utils.StringParaEstado(estado),
                EventosProjeto.suspender));

            projeto.estado = servicoObterEstados.ObterIdEstado(novoEstado);
			servicoProjetos.AtualizarProjeto(projeto);
            Vista.Hide();
            Vista.Close();
        }

		private void initEstados(Utilizador utilizador)
		{
            estados = servicoObterEstados
                .ObterEstadosValidos(utilizador)
                .Select(e => Utils.StringParaEstado(e.estado1))
                .ToList();
            estados.Remove(EstadosProjeto.rejeitado);
            estados.Remove(EstadosProjeto.fechado);
            estados.Remove(EstadosProjeto.suspenso);
            estados.Remove(EstadosProjeto.espera_reforco);
		}
    }
}
