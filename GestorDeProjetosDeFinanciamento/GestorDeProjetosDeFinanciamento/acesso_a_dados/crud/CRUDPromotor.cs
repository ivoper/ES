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

        public Promotor LerPromotor(decimal nif)
        {
            using (Entidades context = new Entidades())
            {
                return context.Promotor.Find(nif);
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

        public static CRUDPromotor ObterInstancia()
        {
            if (servico == null)
                servico = new CRUDPromotor();

            return servico;
        }
    }
}
