using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.acesso_a_dados.crud
{
    class CRUDPromotor
    {
        private static CRUDPromotor servico;

        private CRUDPromotor()
        {

        }

        public Promotor LerPromotor(int id)
        {
            using (Entidades context = new Entidades())
            {
                return context.Promotor.Find(id);
            }
        }

        public Promotor LerPromotor(decimal nif)
        {
            using (Entidades context = new Entidades())
            {
                List<Promotor> proms = context.Promotor.Where(p => p.nif == nif).ToList();
                if (!proms.Any())
                    return null;
                return proms.First();
            }
        }

        public void CriarPromotor(Promotor promotor)
        {
            using (Entidades contexto = new Entidades())
            {
                contexto.Promotor.Add(new Promotor()
                {
                    nome = promotor.nome,
                    nacionalidade = promotor.nacionalidade,
                    nib = promotor.nib,
                    nif = promotor.nif
                });
                contexto.SaveChanges();
            }
        }

        public static CRUDPromotor ObterInstancia()
        {
            if (servico == null)
                servico = new CRUDPromotor();

            return servico;
        }
    }
}
