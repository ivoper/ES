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
        private readonly EstadosProjeto estado = EstadosProjeto.suspenso;    //not

        
        public SuspenderProjeto() 
        {
            Vista.Notificavel = this;
            projetos = servicoProjetos.ProjetosEstadoDiferente(estado);
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
    }
}
