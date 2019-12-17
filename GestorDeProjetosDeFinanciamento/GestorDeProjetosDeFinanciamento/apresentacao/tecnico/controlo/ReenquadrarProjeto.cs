using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
    class ReenquadrarProjeto : ListarProjetos
    {

        private readonly EstadosProjeto estadosProjeto = EstadosProjeto.arquivado;
        private Tecnico tecnico;

        public ReenquadrarProjeto(Tecnico tecnico)
        {
            this.tecnico = tecnico;
            Vista.Notificavel = this;
            projetos = servicoProjetos.ProjetosEstado(Enum.GetName(typeof(EstadosProjeto), estadosProjeto));
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
            projeto.estado = nameof(EstadosProjeto.aberto);
            servicoProjetos.AtualizarProjeto(projeto);
            Vista.Hide();
            Vista.Close();
        }
    }
}
