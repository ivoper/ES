using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.vista;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
    class Consultar : Apresentador<FormConsultar, EventArgs>
    {
        private CRUDResponsavel servicoResponsavel;
        private CRUDParecerTecnico servicoParecer;
        private CRUDDespacho servicoDespacho;
        private CRUDPromotor servicoPromotor;
        private CRUDPagamento servicoPagamento;
        private ObterEstados servicoObterEstados;
        private Utilizador user;

        public Consultar(Utilizador user, Projeto projeto) : base(new FormConsultar())
        {
            this.user = user;
            servicoResponsavel = CRUDResponsavel.ObterInstancia();
            servicoParecer = CRUDParecerTecnico.ObterInstancia();
            servicoDespacho = CRUDDespacho.ObterInstancia();
            servicoPromotor = CRUDPromotor.ObterInstancia();
            servicoPagamento = CRUDPagamento.ObterInstancia();
            servicoObterEstados = ObterEstados.ObterInstancia();
            Vista.Notificavel = this;
            InitVista(projeto);
            Vista.ShowDialog();
        }

        public override void Notificar(EventArgs args)
        {
            // Nothing...
        }

        public void InitVista(Projeto projeto)
        {
            Promotor promotor = servicoPromotor.LerPromotor(projeto.id_promotor);
            Responsavel responsavel = servicoResponsavel.LerResponsavel(projeto.id_responsavel);
            Vista.AlterarDadosPromotor(promotor.nome, promotor.nacionalidade, promotor.nib, promotor.nif);
            Vista.AlterarDadosResponsavel(responsavel.nome, responsavel.telefone, responsavel.email);

            String tipo = projeto.Bonificacao != null ? "Bonificação" : "Incentivo";
            String estado = servicoObterEstados.ObterEstado(projeto.estado).estado1;
            Vista.AlterarDadosProjeto(projeto.id, user.username, tipo, projeto.montante_solicitado, projeto.descricao, estado, projeto.data_criacao);

            ListarDespacho(servicoDespacho.LerDespachosDeProjeto(projeto));
            ListarPagamentos(servicoPagamento.LerPagamentosDeProjeto(projeto));
            ListarPareceresTecnico(servicoParecer.LerParecerTecnicosDeProjeto(projeto));
        }

        public void ListarDespacho(List<Despacho> despachos)
        {
            List<string[]> lista = new List<string[]>();
            foreach (Despacho despacho in despachos)
            {
                string[] linha = new string[8];
                linha[0] = despacho.resultado;
                linha[4] = despacho.data_despacho.ToString();
                if (despacho.DespachoBonificacao != null)
                {
                    linha[5] = despacho.DespachoBonificacao.periodo.ToString();
                    linha[6] = despacho.DespachoBonificacao.taxa.ToString();
                    linha[7] = despacho.DespachoBonificacao.montante_maximo.ToString();
                }
                else if (despacho.DespachoIncentivo != null)
                {
                    linha[1] = despacho.DespachoIncentivo.montante.ToString();
                    linha[2] = despacho.DespachoIncentivo.custo_elegivel.ToString();
                    linha[3] = despacho.DespachoIncentivo.prazo_execucao.ToString();
                }
				lista.Add(linha);
            }
            Vista.listarDespachos(lista);
        }

        public void ListarPagamentos(List<Pagamento> pagamentos)
        {
            List<string[]> lista = new List<string[]>();
            foreach (Pagamento pagamento in pagamentos)
            {
                string[] linha = new string[2];
                linha[0] = pagamento.valor.ToString();
                linha[1] = pagamento.data.ToString();
                lista.Add(linha);
            }
            Vista.listarPagamentos(lista);
        }

        public void ListarPareceresTecnico(List<ParecerTecnico> pareceresTecnico)
        {
            List<string[]> lista = new List<string[]>();
            foreach (ParecerTecnico parecer in pareceresTecnico)
            {
                string[] linha = new string[3];
                linha[0] = parecer.decisao;
                linha[1] = parecer.texto;
                linha[2] = parecer.data_parecer.ToString();
                lista.Add(linha);
            }
            Vista.listarPareceresTecnicos(lista);
        }
    }
}
