using GestorDeProjetosDeFinanciamento.acesso_a_dados;
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

		public ReforcoDeFinanciamento(Projeto projeto) : base(new FormReforcoDeFinanciamento())
		{
            servicoProjetos = CRUDProjetos.ObterInstancia();
            this.projeto = projeto;
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(ReforcoDeFinanciamentoArgs args)
		{
            Despacho despacho = servicoProjetos.LerDespachosDeProjeto(projeto).OrderBy(d=>d.prazo_execucao).Last(); //despacho mais recente
            despacho.prazo_execucao = Convert.ToDateTime(args.data);
            despacho.montante += Convert.ToDouble(args.montante);
            servicoProjetos.AtualizarDespacho(despacho);        //despacho atualizado
            Historico historico = new Historico()
            {
                id = projeto.id,
                estado = projeto.estado
            };
            servicoProjetos.CriarHistorico(historico);          //historico criado
            EstadosProjeto estadoAntigo;
            Enum.TryParse(projeto.estado, out estadoAntigo);
            EstadosProjeto estadoNovo = MaquinaDeEstados.processar(estadoAntigo, Evento.pedir_reforco);
            projeto.estado = Enum.GetName(typeof(EstadosProjeto), estadoNovo);
            servicoProjetos.AtualizarProjeto(projeto);          //estado atualizado
			Vista.Hide();
			Vista.Close();
		}
	}
}
