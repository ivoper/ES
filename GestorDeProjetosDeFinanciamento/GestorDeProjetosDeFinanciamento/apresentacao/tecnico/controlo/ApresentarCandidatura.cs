using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista;
using GestorDeProjetosDeFinanciamento.dominio;

namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.controlo
{
	class ApresentarCandidatura : Apresentador<FormApresentarCandidatura, ApresentarCandidaturaArgs>
	{
		private CRUDProjetos servicoProjetos;

		public ApresentarCandidatura() : base(new FormApresentarCandidatura())
		{
			servicoProjetos = CRUDProjetos.ObterInstancia();
			Vista.Notificavel = this;
			Vista.ShowDialog();
		}

		public override void Notificar(ApresentarCandidaturaArgs args)
		{
			servicoProjetos.CriarProjeto(new Projeto
			{
				id = 1,
				tipo = args.tipo,
				montante_financiamento = Convert.ToDouble(args.montante),
				descricao = args.descricao,
				estado = Enum.GetName(typeof(EstadosProjeto), EstadosProjeto.aberto),
				data_criacao = DateTime.Now,
				id_tecnico = 1, //TODO
				telefone = args.telefone,
				nif = Convert.ToDecimal(args.NIF)
			});
			Vista.Hide();
			Vista.Close();
		}
	}
}
