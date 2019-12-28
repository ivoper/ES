using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.acesso_a_dados
{
    class CRUDPagamento
    {
        private static CRUDPagamento servico;

        private CRUDPagamento()
        {

        }

        public List<Pagamento> LerPagamentosDeProjeto(Projeto projeto)
        {
            using (Entidades contexto = new Entidades())
            {
                return contexto.Pagamento.Where(d => d.id_projeto == projeto.id).ToList();
            }
        }

        public void RealizarPagamento(Pagamento pagamento)
        {
            using (Entidades contexto = new Entidades())
            {
                contexto.Pagamento.Add(new Pagamento()
                {
                    valor = pagamento.valor,
                    data = pagamento.data,
                    id_projeto = pagamento.id_projeto,
                    id_despacho = pagamento.id_despacho
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

        public static CRUDPagamento ObterInstancia()
        {
            if (servico == null)
                servico = new CRUDPagamento();

            return servico;
        }
    }
}
