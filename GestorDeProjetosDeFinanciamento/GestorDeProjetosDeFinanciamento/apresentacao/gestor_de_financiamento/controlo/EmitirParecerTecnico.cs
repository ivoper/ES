using GestorDeProjetosDeFinanciamento.acesso_a_dados;
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
        private Projeto projeto;

        public EmitirParecerTecnico(Projeto projeto) : base(new FormEmitirParecerTecnico())
        {
            this.projeto = projeto;
            servicoProjetos = CRUDProjetos.ObterInstancia();
            Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(EmitirParecerTecnicoArgs args)
		{
            if (verificarArgumentos(args))
            {
                Erro erro = new Erro("Por favor preencha todos os campos necessários");
                return;
            }

            ParecerTecnico parecer = new ParecerTecnico()
            {
                texto_livre = args.texto,
                decisao = args.decisao.ToLower(),
                id_projeto = projeto.id,
                data_parecer = DateTime.Now
            };
            servicoProjetos.CriarParecerTecnico(parecer);

            EstadosProjeto estadoAntigo, estadoNovo;
            Enum.TryParse(projeto.estado, out estadoAntigo);
            if (args.decisao.Equals("Aprovado"))
                estadoNovo = MaquinaDeEstados.processar(estadoAntigo, Evento.parecer_favoravel);
            else
                estadoNovo = MaquinaDeEstados.processar(estadoAntigo, Evento.parecer_desfavoravel);
            
            projeto.estado = Enum.GetName(typeof(EstadosProjeto), estadoNovo);
            servicoProjetos.AtualizarProjeto(projeto);

            Vista.Hide();
			Vista.Close();
		}

        private bool verificarArgumentos(EmitirParecerTecnicoArgs args)
        {
            return args.texto.Equals("") && args.decisao.Equals("");
        }
	}
}
