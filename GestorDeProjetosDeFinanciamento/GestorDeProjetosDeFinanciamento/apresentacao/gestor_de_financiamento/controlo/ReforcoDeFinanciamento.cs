using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
	class ReforcoDeFinanciamento : Apresentador<FormReforcoDeFinanciamento, ReforcoDeFinanciamentoArgs>
	{
        private Projeto projeto;
        private CRUDProjetos servicoProjetos;
        private CRUDHistorico servicoHistorico;
        protected CRUDDespacho servicoDespacho;
        private ObterEstados servicoObterEstados;

        public ReforcoDeFinanciamento(Projeto projeto) : base(new FormReforcoDeFinanciamento())
		{
            servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoHistorico = CRUDHistorico.ObterInstancia();
            servicoDespacho = CRUDDespacho.ObterInstancia();
            servicoObterEstados = ObterEstados.ObterInstancia();
            this.projeto = projeto;
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(ReforcoDeFinanciamentoArgs args)
		{
            double montante;
            DateTime data = Convert.ToDateTime(args.data);
            if (!Double.TryParse(args.montante, out montante) || DateTime.Compare(data, DateTime.Now) <= 0)
            {
                new Erro("Por favor preencha todos os campos necessários");
                return;
            }

            Despacho despacho = servicoDespacho.LerDespachosDeProjeto(projeto).OrderBy(d=>d.data_despacho).Last(); //despacho mais recente
            despacho.DespachoIncentivo.prazo_execucao = data;
            despacho.DespachoIncentivo.montante += Convert.ToDouble(args.montante);
            servicoDespacho.AtualizarDespacho(despacho);        //despacho atualizado
            Historico historico = new Historico()
            {
                id_projeto = projeto.id,
                estado = projeto.estado
            };
            servicoHistorico.CriarHistorico(historico);          //historico criado
            String estado = servicoObterEstados.ObterEstado(projeto.estado).estado1;
            String estadoNovo = Utils.EstadoParaString(MaquinaDeEstados.processar(
                Utils.StringParaEstado(estado), 
                EventosProjeto.pedir_reforco));

            projeto.estado = servicoObterEstados.ObterIdEstado(estadoNovo);
            servicoProjetos.AtualizarProjeto(projeto);          //estado atualizado
			Vista.Hide();
			Vista.Close();
		}
	}
}
