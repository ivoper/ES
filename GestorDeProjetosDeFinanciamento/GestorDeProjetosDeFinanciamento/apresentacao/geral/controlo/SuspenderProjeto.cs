using GestorDeProjetosDeFinanciamento.acesso_a_dados;
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

		public SuspenderProjeto(User user) 
        {
			initEstados(user);
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
            projeto.estado = Utils.EstadoParaString(MaquinaDeEstados.processar(
                Utils.StringParaEstado(projeto.estado),
                EventosProjeto.suspender));
			servicoProjetos.AtualizarProjeto(projeto);
            Vista.Hide();
            Vista.Close();
        }

		private void initEstados(User user)
		{
            estados = new List<EstadosProjeto>(user.estadosValidos);
            estados.Remove(EstadosProjeto.rejeitado);
            estados.Remove(EstadosProjeto.fechado);
            estados.Remove(EstadosProjeto.suspenso);
            estados.Remove(EstadosProjeto.espera_reforco);
		}
    }
}
