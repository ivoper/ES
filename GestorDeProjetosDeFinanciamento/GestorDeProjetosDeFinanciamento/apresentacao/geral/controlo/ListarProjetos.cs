using GestorDeProjetosDeFinanciamento.acesso_a_dados;
using GestorDeProjetosDeFinanciamento.apresentacao.geral.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.controlo
{
	abstract class ListarProjetos : Apresentador<FormListarProjetos, IntArgs>
	{
		protected CRUDProjetos servicoProjetos;
		protected List<Projeto> projetos;

		public ListarProjetos() : base(new FormListarProjetos())
		{
			servicoProjetos = CRUDProjetos.ObterInstancia();
            projetos = new List<Projeto>();
        }

		protected void listar()
		{
			List<string[]> lista = new List<string[]>();
			foreach (Projeto projeto in projetos)
			{
				string[] linha = new string[4];
				linha[0] = projeto.id.ToString();
				linha[1] = projeto.tipo;
				linha[2] = projeto.descricao;
				linha[3] = projeto.data_criacao.ToString();
				lista.Add(linha);
			}
			Vista.listar(lista);
		}
	}
}
