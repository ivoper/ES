using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
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
            Despacho despacho = servicoDespacho.LerDespachosDeProjeto(projeto).OrderBy(d=>d.prazo_execucao).Last(); //despacho mais recente
            despacho.prazo_execucao = Convert.ToDateTime(args.data);
            despacho.montante += Convert.ToDouble(args.montante);
            servicoDespacho.AtualizarDespacho(despacho);        //despacho atualizado
            Historico historico = new Historico()
            {
                id = projeto.id,
                estado = projeto.estado
            };
            servicoHistorico.CriarHistorico(historico);          //historico criado
            projeto.estado = MaquinaDeEstados.processar(projeto.estado, EventosProjeto.pedir_reforco);
            servicoProjetos.AtualizarProjeto(projeto);          //estado atualizado
			Vista.Hide();
			Vista.Close();
		}
	}
}
