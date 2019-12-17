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
		private CRUDResponsavel servicoResponsavel;

		public AlterarDados(Projeto projetoSelecionado) : base(new FormAlterarDados())
		{
            servicoResponsavel = CRUDResponsavel.ObterInstancia();
			projeto = projetoSelecionado;
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(AlterarDadosArgs args)
		{
            if (args.novoEmail.Equals("") || args.novoTelefone.Equals(""))
            {
                new Erro("Por favor preencha todos os campos necessários");
                return;
            }
			Responsavel res = servicoResponsavel.LerResponsavelComProjeto(projeto);
			res.email = args.novoEmail;
			res.telefone = args.novoTelefone;
            servicoResponsavel.AtualizarResponsavel(res);
			Vista.Hide();
			Vista.Close();
		}
	}
}
