using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo;
using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo;
using GestorDeProjetosDeFinanciamento.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.controlo
{
	class RealizarPagamento : Apresentador<FormRealizarPagamento, StringArgs>
	{

        protected CRUDProjetos servicoProjetos;
        private Projeto projeto;

        public RealizarPagamento(Projeto projeto) : base(new FormRealizarPagamento())
		{
            this.projeto = projeto;
            servicoProjetos = CRUDProjetos.ObterInstancia();
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(StringArgs args)
		{
            if (verificarArgumentos(args))
            {
                Erro erro = new Erro("Por favor preencha todos os campos necessários");
                return;
            }

            Pagamento pagamento = new Pagamento()
            {
                id_projeto = projeto.id,
                data_pagamento = DateTime.Now,
                montante = Int32.Parse(args.texto)
            };
            servicoProjetos.RealizarPagamento(pagamento);

            EstadosProjeto estadoAntigo, estadoNovo;
            Enum.TryParse(projeto.estado, out estadoAntigo);

            double montante = servicoProjetos
                .ObterPagamentosDeProjeto(projeto)
                .Select(p => p.montante)
                .Sum();
            

            /*projeto.estado = Enum.GetName(typeof(EstadosProjeto), estadoNovo);
            servicoProjetos.AtualizarProjeto(projeto);*/

            Vista.Hide();
			Vista.Close();
		}

        private bool verificarArgumentos(StringArgs m)
        {
            Int32 montante;
            return !m.texto.Equals("") && Int32.TryParse(m.texto, out montante);
        }

    }
}
