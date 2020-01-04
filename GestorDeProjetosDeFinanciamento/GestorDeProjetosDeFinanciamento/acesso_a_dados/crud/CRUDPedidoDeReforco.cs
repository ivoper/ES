using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.acesso_a_dados.crud
{
    class CRUDPedidoDeReforco
    {

        private static CRUDPedidoDeReforco servico;

        public void CriarPedidoDeReforco(PedidoDeReforco pedidoDeReforco)
        {
            using (Entidades contexto = new Entidades())
            {
                pedidoDeReforco.decisao = "por decidir";
                contexto.Entry(pedidoDeReforco).State = EntityState.Added;
                contexto.SaveChanges();
            }
        }

        public PedidoDeReforco LerPedidoDeReforcoPorDecidir(PedidoDeReforco pedidoDeReforco)
        {
            using (Entidades contexto = new Entidades())
            {
                IEnumerable<PedidoDeReforco> pedidoDeReforcos = contexto.PedidoDeReforco
                    .Where(p => p.id_despacho == pedidoDeReforco.id_despacho && p.decisao.Equals("por decidir"));

                if (!pedidoDeReforcos.Any())
                    return null;

                return pedidoDeReforcos.First();
            }
        }

        public void AtualizarPedidoDeReforco(PedidoDeReforco pedidoDeReforco)
        {
            using (Entidades contexto = new Entidades())
            {
                contexto.Entry(pedidoDeReforco).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public static CRUDPedidoDeReforco ObterInstancia()
        {
            if (servico == null)
                servico = new CRUDPedidoDeReforco();

            return servico;
        }
    }
}
