using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
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
        private ObterEstados servicoObterEstados;

        public ReenquadrarProjeto(Tecnico tecnico)
        {
            this.tecnico = tecnico;
            Vista.Notificavel = this;
            servicoObterEstados = ObterEstados.ObterInstancia();
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
            String estado = servicoObterEstados.ObterEstado(projeto.estado).estado1;
            String estadoNovo = Utils.EstadoParaString(MaquinaDeEstados.processar(Utils.StringParaEstado(estado), EventosProjeto.reenquadrar));

            projeto.estado = servicoObterEstados.ObterIdEstado(estadoNovo);
            servicoProjetos.AtualizarProjeto(projeto);
            Vista.Hide();
            Vista.Close();
        }
    }
}
