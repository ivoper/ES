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

		public void CriarDespacho(Despacho despacho)
		{
			using (Entidades context = new Entidades())
			{
				context.Despacho.Add(new Despacho
				{
					id_projeto = despacho.id_projeto,
					prazo_execucao = despacho.prazo_execucao,
					montante = despacho.montante,
					data_despacho = despacho.data_despacho,
					custo_elegivel = despacho.custo_elegivel,
					resultado = despacho.resultado
				});
				context.SaveChanges();
			}
		}

        //retorna os projetos que estão no historico, cujo estado atual é "estado" TODO
        public Projeto ProjetosComHistorico(string estado)
        {
            using (Entidades context = new Entidades())
            {
                return (from p in context.Projeto
                                join h in context.Historico on p.id equals h.id
                                where p.estado == estado
                                select p).SingleOrDefault();
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
