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
		private readonly List<EstadosProjeto> estados = new List<EstadosProjeto>();    //not

		public SuspenderProjeto() 
        {
			initEstados();
			IEnumerable<string> estadosString = estados.Select(e => Enum.GetName(typeof(EstadosProjeto), e));
			Vista.Notificavel = this;
            projetos = servicoProjetos.ProjetosEstadoDiferente(estadosString);
            listar();
            Vista.ShowDialog();
        }

        public override void Notificar(IntArgs args)
        {
			if(args.valor == 0) return;
            Projeto projeto = projetos[args.valor - 1];
			servicoProjetos.CriarHistorico(new Historico
			{
				id = projeto.id,
				estado = projeto.estado
			});
			projeto.estado = nameof(EstadosProjeto.suspenso);
			servicoProjetos.AtualizarEstado(projeto);
            Vista.Hide();
            Vista.Close();
        }

		private void initEstados()
		{
			estados.Add(EstadosProjeto.rejeitado);
			estados.Add(EstadosProjeto.suspenso);
		}
    }
}
