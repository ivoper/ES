using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.acesso_a_dados.crud
{
    class CRUDDespacho
    {
        private static CRUDDespacho servico;

        private CRUDDespacho()
        {

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

        public static CRUDDespacho ObterInstancia()
        {
            if (servico == null)
                servico = new CRUDDespacho();

            return servico;
        }
    }
}
