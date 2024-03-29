﻿using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.acesso_a_dados.crud;
using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo.args;
using GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.controlo
{
    class RealizarDespachoIncentivo : Apresentador<FormRealizarDespachoIncentivo, RealizarDespachoArgs>
    {
        private readonly Projeto projeto;
        private readonly string resultado;
        private CRUDDespacho servicoDespacho;
        private CRUDProjetos servicoProjetos;
        private ObterEstados servicoObterEstados;

        public RealizarDespachoIncentivo(Projeto projeto, string resultado) : base(new FormRealizarDespachoIncentivo())
        {
            this.projeto = projeto;
            this.resultado = resultado;
            servicoDespacho = CRUDDespacho.ObterInstancia();
            servicoProjetos = CRUDProjetos.ObterInstancia();
            servicoObterEstados = ObterEstados.ObterInstancia();
            Vista.Notificavel = this;
            Vista.ShowDialog();
        }

        public override void Notificar(RealizarDespachoArgs args)
        {
            if (verificarArgumentos(args))
            {
                new Erro("Por favor preencha todos os campos necessários");
                return;
            }

            Despacho despachoRejeitar = new Despacho()
            {
                id_projeto = projeto.id,
                resultado = resultado.ToLower(),
                data_despacho = DateTime.Now
            };
            int idDespacho = servicoDespacho.CriarDespacho(despachoRejeitar);

            DespachoIncentivo despachoIncentivo = new DespachoIncentivo()
            {
                id_despacho = idDespacho,
                montante = Convert.ToDouble(args.val1),
                custo_elegivel = Convert.ToDouble(args.val2),
                prazo_execucao = Convert.ToDateTime(args.data)
            };
            servicoDespacho.CriarDespachoIncentivo(despachoIncentivo);

            string estado = servicoObterEstados.ObterEstado(projeto.estado).estado1;
            string estadoNovo = Utils.EstadoParaString(MaquinaDeEstados.processar(Utils.StringParaEstado(estado), EventosProjeto.despacho_aprovado));
            projeto.estado = servicoObterEstados.ObterIdEstado(estadoNovo);
            servicoProjetos.AtualizarProjeto(projeto);

            Vista.Hide();
            Vista.Close();
        }

        private bool verificarArgumentos(RealizarDespachoArgs args)
        {
            double d1, d2;
            DateTime data = Convert.ToDateTime(args.data);
            return !double.TryParse(args.val1, out d1) || !double.TryParse(args.val2, out d2) || DateTime.Compare(data, DateTime.Now) <= 0;
        }
    }
}
