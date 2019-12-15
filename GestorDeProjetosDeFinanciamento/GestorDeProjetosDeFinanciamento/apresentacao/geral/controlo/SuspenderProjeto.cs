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
    class SuspenderProjeto : Apresentador<FormListarProjetos, IntArgs>
    {
        private CRUDProjetos servicoProjetos;
        private readonly EstadosProjeto estado = EstadosProjeto.suspenso;    //not disto
        private List<Projeto> projetos;
        
        public SuspenderProjeto() : base(new FormListarProjetos())
        {
            servicoProjetos = CRUDProjetos.ObterInstancia();
            Vista.Notificavel = this;
            projetos = servicoProjetos.ProjetosEstadoDiferente(estado);
            listar();
            Vista.ShowDialog();
        }

        public override void Notificar(IntArgs args)
        {
            Projeto projeto = projetos[args.valor - 1];
            projeto.estado = nameof(EstadosProjeto.suspenso);
            servicoProjetos.AtualizarEstado(projeto);
            Vista.Hide();
            Vista.Close();
        }

        private void listar()
        {
            List<string[]> lista = new List<string[]>();
            foreach(Projeto projeto in projetos)
            {
                string[] linha = new string[4];
                linha[0] = projeto.id.ToString();
                linha[1] = projeto.tipo;
                linha[2] = projeto.descricao;
                linha[3] = projeto.data_criacao.ToString();
                lista.Add(linha);
            }
            Vista.listar(lista);
        }
    }
}
