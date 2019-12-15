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

		public void CriarProjeto(Projeto projeto)
		{
			using (Entidades context = new Entidades())
			{
				context.Entry(projeto).State = EntityState.Added;
				context.SaveChanges();
			}
		}

		//TODO
		public List<Projeto> ProjetosEstado(EstadosProjeto estadosProjeto)
        {
			string estado = Enum.GetName(typeof(EstadosProjeto), estadosProjeto);
			using (Entidades context = new Entidades())
            {
                IEnumerable<Projeto> projetos = context.Projeto.Where(p => p.estado == estado);
                return projetos.ToList();
            }
        }

        public List<Projeto> ProjetosEstadoDiferente(EstadosProjeto estadosProjeto)
        {
            string estado = Enum.GetName(typeof(EstadosProjeto), estadosProjeto);
            using (Entidades context = new Entidades())
            {
                IEnumerable<Projeto> projetos = context.Projeto.Where(p => p.estado != estado);
                return projetos.ToList();
            }
        }

        public void AtualizarEstado(Projeto projeto)
        {
            using (Entidades context = new Entidades())
            {
                context.Entry(projeto).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

		public void CriarHistorico(Historico historico)
		{
			using (Entidades context = new Entidades())
			{
				context.Entry(historico).State = EntityState.Added;
				context.SaveChanges();
			}
		}

		public void EliminarHistorico(Historico historico)
		{
			using (Entidades context = new Entidades())
			{
				context.Entry(historico).State = EntityState.Deleted;
				context.SaveChanges();
			}
		}

		public Historico LerHistorico(Historico historico)
		{
			using (Entidades context = new Entidades())
			{
				return context.Historico.Find(historico.id);
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
