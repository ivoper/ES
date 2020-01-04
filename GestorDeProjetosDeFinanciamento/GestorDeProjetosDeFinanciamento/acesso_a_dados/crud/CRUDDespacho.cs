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

        public int CriarDespacho(Despacho despacho)
        {
            using (Entidades context = new Entidades())
            {
                Despacho despachoNovo = new Despacho
                {
                    id_projeto = despacho.id_projeto,
                    data_despacho = despacho.data_despacho,
                    resultado = despacho.resultado
                };
                context.Despacho.Add(despachoNovo);
                context.SaveChanges();
                return despachoNovo.id;
            }
        }

        public void CriarDespachoIncentivo(DespachoIncentivo despacho)
        {
            using (Entidades context = new Entidades())
            {
                DespachoIncentivo despachoNovo = new DespachoIncentivo
                {
                    id_despacho = despacho.id_despacho,
                    prazo_execucao = despacho.prazo_execucao,
                    montante = despacho.montante,
                    custo_elegivel = despacho.custo_elegivel
                };
                context.DespachoIncentivo.Add(despachoNovo);
                context.SaveChanges();
            }
        }

        public void CriarDespachoBonificacao(DespachoBonificacao despacho)
        {
            using (Entidades context = new Entidades())
            {
                DespachoBonificacao despachoNovo = new DespachoBonificacao
                {
                    id_despacho = despacho.id_despacho,
                    taxa = despacho.taxa,
                    periodo = despacho.periodo,
                    montante_maximo = despacho.montante_maximo
                };
                context.DespachoBonificacao.Add(despachoNovo);
                context.SaveChanges();
            }
        }

        public List<Despacho> LerDespachosDeProjeto(Projeto projeto)
        {
            using (Entidades contexto = new Entidades())
            {
                return contexto.Despacho
                    .Where(d => d.id_projeto == projeto.id)
                    .Include(d => d.DespachoBonificacao)
                    .Include(d => d.DespachoIncentivo)
                    .ToList();
            }
        }

        public List<DespachoIncentivo> LerDespachosDeProjetoIncentivo(Projeto projeto)
        {
            using (Entidades contexto = new Entidades())
            {
                return contexto.DespachoIncentivo
                    .Where(d => d.Despacho.id_projeto == projeto.id)
                    .Include(d => d.Despacho)
                    .ToList();
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
