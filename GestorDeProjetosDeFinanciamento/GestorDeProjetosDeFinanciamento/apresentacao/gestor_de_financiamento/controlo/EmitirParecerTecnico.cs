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
	class EmitirParecerTecnico : Apresentador<FormEmitirParecerTecnico, EmitirParecerTecnicoArgs>
	{

        protected CRUDProjetos servicoProjetos;
        protected CRUDParecerTecnico servicoParecer;
        private ObterEstados servicoObterEstados; 
        private Projeto projeto;

        public EmitirParecerTecnico(Projeto projeto) : base(new FormEmitirParecerTecnico())
        {
            this.projeto = projeto;
            servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoParecer = CRUDParecerTecnico.ObterInstancia();
            servicoObterEstados = ObterEstados.ObterInstancia();
            Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(EmitirParecerTecnicoArgs args)
		{
            if (!verificarArgumentos(args))
            {
                Erro erro = new Erro("Por favor preencha todos os campos necessários");
                return;
            }

            ParecerTecnico parecer = new ParecerTecnico()
            {
                texto = args.texto,
                decisao = args.decisao.ToLower(),
                id_projeto = projeto.id,
                data_parecer = DateTime.Now
            };
            servicoParecer.CriarParecerTecnico(parecer);

            String estado = servicoObterEstados.ObterEstado(projeto.estado).estado1;
            EstadosProjeto estadoAntigo = Utils.StringParaEstado(estado);
            EstadosProjeto estadoNovo;
            if (args.decisao.Equals("Aprovado"))
                estadoNovo = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.parecer_favoravel);
            else
                estadoNovo = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.parecer_desfavoravel);

            String superEstadoNovo = Utils.EstadoParaString(estadoNovo);
            projeto.estado = servicoObterEstados.ObterIdEstado(superEstadoNovo);
            servicoProjetos.AtualizarProjeto(projeto);

            Vista.Hide();
			Vista.Close();
		}

        private bool verificarArgumentos(EmitirParecerTecnicoArgs args)
        {
            return !args.texto.Equals("") && !args.decisao.Equals("");
        }
	}
}
