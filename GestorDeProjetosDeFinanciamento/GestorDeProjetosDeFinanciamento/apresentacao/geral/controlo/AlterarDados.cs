using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
	class AlterarDados : Apresentador<FormAlterarDados, AlterarDadosArgs>
	{
		private Projeto projeto;
		private CRUDProjetos servico;

		public AlterarDados(Projeto projetoSelecionado) : base(new FormAlterarDados())
		{
			servico = CRUDProjetos.ObterInstancia();
			projeto = projetoSelecionado;
			Vista.Notificavel = this;
			Vista.ShowDialog();

		}

		public override void Notificar(AlterarDadosArgs args)
		{
			Responsavel res = servico.LerResponsavelComProjeto(projeto);
			res.email = args.novoEmail;
			res.telefone = args.novoTelefone;
			servico.AtualizarResponsavel(res);
			Vista.Hide();
			Vista.Close();
		}
	}
}
