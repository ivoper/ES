using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
    class ConsultarListarProjetos : ListarProjetos
    {

        private List<EstadosProjeto> estados;
        private ObterEstados servicoObterEstados;
        private Utilizador user;

        public ConsultarListarProjetos(Utilizador currentUser)
        {
            Vista.Notificavel = this;
            user = currentUser;
            servicoObterEstados = ObterEstados.ObterInstancia();
            initEstados(currentUser);
            IEnumerable<string> estadosString = estados.Select(e => Enum.GetName(typeof(EstadosProjeto), e));
            projetos = servicoProjetos.ProjetosEstado(estadosString);
            projetos = ConfirmarSuspensos();
            listar();
            Vista.ShowDialog();
        }

        public override void Notificar(IntArgs args)
        {
            Projeto projeto = projetos[args.valor];
            Vista.Hide();
            Vista.Close();
            new Consultar(user, projeto);
        }

        private void initEstados(Utilizador user)
        {
            estados = servicoObterEstados
                .ObterEstadosValidos(user)
                .Select(e => Utils.StringParaEstado(e.estado1))
                .ToList();
        }

        private List<Projeto> ConfirmarSuspensos()
        {
            List<Projeto> projetosNovos = new List<Projeto>();
            foreach(Projeto p in projetos)
            {
                Estado estado = servicoObterEstados.ObterEstado(p.estado);
                if (estado.estado1 == Utils.EstadoParaString(EstadosProjeto.suspenso))
                {
                    Historico historico = servicoHistorico.LerHistorico(new Historico()
                    {
                        id_projeto = p.id
                    });

                    if (!estados.Contains(Utils.StringParaEstado(servicoObterEstados.ObterEstado(historico.estado).estado1)))
                        continue;
                }

                projetosNovos.Add(p);
            }

            return projetosNovos;
        }
    }
}
