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
        private User user;

        public ConsultarListarProjetos(User currentUser)
        {
            user = currentUser;
            initEstados(currentUser);
            IEnumerable<string> estadosString = estados.Select(e => Enum.GetName(typeof(EstadosProjeto), e));
            Vista.Notificavel = this;
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

        private void initEstados(User user)
        {
            estados = new List<EstadosProjeto>(user.estadosValidos);
            
        }

        private List<Projeto> ConfirmarSuspensos()
        {
            List<Projeto> projetosNovos = new List<Projeto>();
            foreach(Projeto p in projetos)
            {
                if (p.estado == Utils.EstadoParaString(EstadosProjeto.suspenso))
                {
                    Historico historico = servicoHistorico.LerHistorico(new Historico()
                    {
                        id_projeto = p.id
                    });

                    if (!estados.Contains(Utils.StringParaEstado(historico.estado)))
                        continue;
                }

                projetosNovos.Add(p);
            }

            return projetosNovos;
        }
    }
}
