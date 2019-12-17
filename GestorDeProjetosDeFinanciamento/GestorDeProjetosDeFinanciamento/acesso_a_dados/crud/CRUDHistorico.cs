using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.acesso_a_dados.crud
{
    class CRUDHistorico
    {
        private static CRUDHistorico servico;

        private CRUDHistorico()
        {

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

        public static CRUDHistorico ObterInstancia()
        {
            if (servico == null)
                servico = new CRUDHistorico();

            return servico;
        }
    }
}
