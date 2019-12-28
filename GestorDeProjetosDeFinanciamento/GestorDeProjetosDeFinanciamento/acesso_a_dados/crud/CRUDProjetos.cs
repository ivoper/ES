using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
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
        private ObterEstados servicoObterEstados;

        private CRUDProjetos()
        {
            servicoObterEstados = ObterEstados.ObterInstancia();
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
                IEnumerable<Projeto> projetos = context.Projeto.Where(p => estadosProjeto.Contains(servicoObterEstados.ObterEstado(p.estado).estado1));
                return projetos.ToList();
            }
        }

        public List<Projeto> ProjetosEstado(string estadoProjeto)
        {
            using (Entidades context = new Entidades())
            {
                List<Projeto> projetos = new List<Projeto>();
                foreach (Projeto p in context.Projeto)
                {
                    String estado = servicoObterEstados.ObterEstado(p.estado).estado1;
                    if (estado.Equals(estadoProjeto))
                        projetos.Add(p);
                }

                return projetos;
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
                        where p.estado == servicoObterEstados.ObterIdEstado(estado) 
                        select new { p.id, h.estado, p.data_criacao, p.descricao }).ToList()
                        .Select(x => new Projeto { id = x.id, estado = x.estado, data_criacao = x.data_criacao, descricao = x.descricao }).ToList();
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
