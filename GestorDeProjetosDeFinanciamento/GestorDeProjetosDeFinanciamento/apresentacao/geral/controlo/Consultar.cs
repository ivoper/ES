﻿using GestorDeProjetosDeFinanciamento.acesso_a_dados;
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
        private CRUDProjetos servico;
        private User user;

        public Consultar(User user, Projeto projeto) : base(new FormConsultar())
        {
            this.user = user;
            servico = CRUDProjetos.ObterInstancia();
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
            Promotor promotor = servico.LerPromotor(projeto.nif);
            Responsavel responsavel = servico.LerResponsavel(projeto.id_responsavel);
            Vista.AlterarDadosPromotor(promotor.designacao, promotor.nacionalidade, promotor.nib, promotor.nif);
            Vista.AlterarDadosResponsavel(responsavel.designacao, responsavel.telefone, responsavel.email);
            Vista.AlterarDadosProjeto(projeto.id, user.username, projeto.tipo, projeto.montante_financiamento, projeto.descricao, projeto.estado, projeto.data_criacao);

            ListarDespacho(servico.LerDespachosDeProjeto(projeto));
            ListarPagamentos(servico.LerPagamentosDeProjeto(projeto));
            ListarPareceresTecnico(servico.LerParecerTecnicosDeProjeto(projeto));
        }

        public void ListarDespacho(List<Despacho> despachos)
        {
            List<string[]> lista = new List<string[]>();
            foreach (Despacho despacho in despachos)
            {
                string[] linha = new string[5];
                linha[0] = despacho.resultado;
                linha[1] = despacho.montante.ToString();
                linha[2] = despacho.custo_elegivel.ToString();
                linha[3] = despacho.prazo_execucao.ToString();
                linha[4] = despacho.data_despacho.ToString();
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
                linha[0] = pagamento.montante.ToString();
                linha[1] = pagamento.data_pagamento.ToString();
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
                linha[1] = parecer.texto_livre;
                linha[2] = parecer.data_parecer.ToString();
                lista.Add(linha);
            }
            Vista.listarPareceresTecnicos(lista);
        }
    }
}
