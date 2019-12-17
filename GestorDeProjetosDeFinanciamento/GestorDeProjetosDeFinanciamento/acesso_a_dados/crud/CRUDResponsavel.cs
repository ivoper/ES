using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.acesso_a_dados
{
    class CRUDResponsavel
    {
        private static CRUDResponsavel servico;

        private CRUDResponsavel()
        {

        }

        public Responsavel LerResponsavel(int id_responsavel)
        {
            using (Entidades context = new Entidades())
            {
                return context.Responsavel.Find(id_responsavel);
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

        public Responsavel LerResponsavel(string telefone, string email, string designacao)
        {
            using (Entidades contexto = new Entidades())
            {
                return contexto.Responsavel.SingleOrDefault(p => p.telefone == telefone && p.email == email && p.designacao == designacao);
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

        public static CRUDResponsavel ObterInstancia()
        {
            if (servico == null)
                servico = new CRUDResponsavel();

            return servico;
        }
    }
}
