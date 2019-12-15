using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.acesso_a_dados
{
    class CRUDProjetos
    {
        private static CRUDProjetos servico;

        private CRUDProjetos()
        {

        }

       //TODO
       public List<Projeto> ProjetosEstado(EstadosProjeto estadosProjeto)
        {
            using(EntidadesES context = new EntidadesES())
            {
                IEnumerable<Projeto> projetos = context.Projeto.Where(p => p.estado == nameof(estadosProjeto));
                return projetos.ToList();
            }
        }

        public List<Projeto> ProjetosEstadoDiferente(EstadosProjeto estadosProjeto)
        {
            using (EntidadesES context = new EntidadesES())
            {
                IEnumerable<Projeto> projetos = context.Projeto.Where(p => p.estado != nameof(estadosProjeto));
                return projetos.ToList();
            }
        }

        public void AtualizarEstado(Projeto projeto)
        {
            using (EntidadesES context = new EntidadesES())
            {
                context.Entry(projeto).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public static CRUDProjetos ObterInstancia()
        {
            if (servico == null)
                servico = new CRUDProjetos();

            return servico;
        }
    }
}
