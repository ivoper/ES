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

        public ReforcoDeFinanciamento(Projeto projeto) : base(new FormReforcoDeFinanciamento())
		{
            servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoHistorico = CRUDHistorico.ObterInstancia();
            servicoDespacho = CRUDDespacho.ObterInstancia();
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
            despacho.prazo_execucao = data;
            despacho.montante += Convert.ToDouble(args.montante);
            servicoDespacho.AtualizarDespacho(despacho);        //despacho atualizado
            Historico historico = new Historico()
            {
                id_projeto = projeto.id,
                estado = projeto.estado
            };
            servicoHistorico.CriarHistorico(historico);          //historico criado
            projeto.estado = Utils.EstadoParaString(MaquinaDeEstados.processar(Utils.StringParaEstado(projeto.estado), EventosProjeto.pedir_reforco));
            servicoProjetos.AtualizarProjeto(projeto);          //estado atualizado
			Vista.Hide();
			Vista.Close();
		}
	}
}
