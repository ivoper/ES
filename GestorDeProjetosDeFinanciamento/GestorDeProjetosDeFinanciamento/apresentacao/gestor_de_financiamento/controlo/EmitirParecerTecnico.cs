﻿using GestorDeProjetosDeFinanciamento.acesso_a_dados;
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
        private Projeto projeto;

        public EmitirParecerTecnico(Projeto projeto) : base(new FormEmitirParecerTecnico())
        {
            this.projeto = projeto;
            servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoParecer = CRUDParecerTecnico.ObterInstancia();
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
                texto_livre = args.texto,
                decisao = args.decisao.ToLower(),
                id_projeto = projeto.id,
                data_parecer = DateTime.Now
            };
            servicoParecer.CriarParecerTecnico(parecer);

            EstadosProjeto estadoAntigo = Utils.StringParaEstado(projeto.estado);
            EstadosProjeto estadoNovo;
            if (args.decisao.Equals("Aprovado"))
                estadoNovo = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.parecer_favoravel);
            else
                estadoNovo = MaquinaDeEstados.processar(estadoAntigo, EventosProjeto.parecer_desfavoravel);

            projeto.estado = Utils.EstadoParaString(estadoNovo);
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
