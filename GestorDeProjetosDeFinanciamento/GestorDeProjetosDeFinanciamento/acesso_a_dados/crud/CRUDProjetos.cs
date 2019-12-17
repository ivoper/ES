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

        public List<Projeto> LerTodosOsProjetos()
        {
            using (Entidades context = new Entidades())
            {
                return context.Projeto.ToList();
            }
        }

		public void CriarProjeto(Projeto projeto)
		{
			using (Entidades context = new Entidades())
			{
				context.Entry(projeto).State = EntityState.Added;
				context.SaveChanges();
			}
		}

        public Projeto LerProjeto(Projeto projeto)
        {
            using (Entidades context = new Entidades())
            {
                return context.Projeto.Find(projeto.id);
            }
        }

        public List<Projeto> ProjetosEstado(IEnumerable<string> estadosProjeto)
        {
			using (Entidades context = new Entidades())
            {
                IEnumerable<Projeto> projetos = context.Projeto.Where(p => estadosProjeto.Contains(p.estado));
                return projetos.ToList();
            }
        }

        public List<Projeto> ProjetosEstado(string estadoProjeto)
        {
            using (Entidades context = new Entidades())
            {
                IEnumerable<Projeto> projetos = context.Projeto.Where(p => p.estado == estadoProjeto);
                return projetos.ToList();
            }
        }

        public void AtualizarProjeto(Projeto projeto)
        {
            using (Entidades context = new Entidades())
            {
                context.Entry(projeto).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

		//retorna os projetos que estão no historico, cujo estado atual é "estado"
		public List<Projeto> ProjetosComHistorico(string estado)
        {
            using (Entidades context = new Entidades())
            {
                return (from p in context.Set<Projeto>()
                        join h in context.Set<Historico>()
                        on p.id equals h.id_projeto
                        where p.estado == estado 
                        select new { p.id, h.estado, p.data_criacao, p.descricao, p.tipo }).ToList()
                        .Select(x => new Projeto { id = x.id, estado = x.estado, tipo = x.tipo, data_criacao = x.data_criacao, descricao = x.descricao }).ToList();
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
