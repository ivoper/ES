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

        public void CriarParecerTecnico(ParecerTecnico parecerTecnico)
        {
            using(Entidades contexto = new Entidades())
            {
                contexto.ParecerTecnico.Add(new ParecerTecnico()
                {
                    texto_livre = parecerTecnico.texto_livre,
                    decisao = parecerTecnico.decisao,
                    id_projeto = parecerTecnico.id_projeto,
                    data_parecer = parecerTecnico.data_parecer
                });
                contexto.SaveChanges();
            }
        }

        public void RealizarPagamento(Pagamento pagamento)
        {
            using (Entidades contexto = new Entidades())
            {
                contexto.Pagamento.Add(new Pagamento()
                {
                    montante = pagamento.montante,
                    data_pagamento = pagamento.data_pagamento,
                    id_projeto = pagamento.id_projeto
                });
                contexto.SaveChanges();
            }
        }

        public List<Pagamento> ObterPagamentosDeProjeto(Projeto projeto)
        {
            using (Entidades contexto = new Entidades())
            {
                return contexto.Pagamento.Where(p => p.id_projeto == projeto.id).ToList();
            }
        }

        public List<Despacho> LerDespachosDeProjeto(Projeto projeto)
        {
            using (Entidades contexto = new Entidades())
            {
                return contexto.Despacho.Where(d => d.id_projeto == projeto.id).ToList();
            }
        }

        public void AtualizarDespacho(Despacho despacho)
        {
            using (Entidades context = new Entidades())
            {
                context.Entry(despacho).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Responsavel LerResponsavelComProjeto(Projeto projeto)
		{
			using (Entidades contexto = new Entidades())
			{
				return contexto.Projeto.Where(p => p.id == projeto.id).FirstOrDefault().Responsavel;
			}
		}

		public void AtualizarResponsavel(Responsavel responsavel)
		{
			using (Entidades context = new Entidades())
			{
				context.Entry(responsavel).State = EntityState.Modified;
				context.SaveChanges();
			}
		}

		//retorna os projetos que estão no historico, cujo estado atual é "estado" TODO
		public List<Projeto> ProjetosComHistorico(string estado)
        {
            using (Entidades context = new Entidades())
            {
                return (from p in context.Set<Projeto>()
                        join h in context.Set<Historico>()
                        on p.id equals h.id
                        where p.estado == estado 
                        select new { p.id, h.estado }).ToList()
                        .Select(x => new Projeto { id = x.id, estado = x.estado }).ToList();
            }
        }

        public Promotor LerPromotor(decimal nif)
        {
            using (Entidades context = new Entidades())
            {
                return context.Promotor.Find(nif);
            }
        }

        public Responsavel LerResponsavel(string telefone)
        {
            using (Entidades contexto = new Entidades())
            {
                return contexto.Responsavel.Find(telefone);
            }
        }

        public void CriarResponsavel(Responsavel responsavel)
        {
            using (Entidades contexto = new Entidades())
            {
                contexto.Responsavel.Add(new Responsavel()
                {
                    designacao = responsavel.designacao,
                    email = responsavel.email,
                    telefone = responsavel.telefone
                });
                contexto.SaveChanges();
            }
        }

        public void CriarPromotor(Promotor promotor)
        {
            using (Entidades contexto = new Entidades())
            {
                contexto.Promotor.Add(new Promotor()
                {
                    designacao = promotor.designacao,
                    nacionalidade = promotor.nacionalidade,
                    nib = promotor.nib,
                    nif = promotor.nif
                });
                contexto.SaveChanges();
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
