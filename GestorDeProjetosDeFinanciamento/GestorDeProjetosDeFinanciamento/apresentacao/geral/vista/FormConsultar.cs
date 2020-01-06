using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.vista
{
    public partial class FormConsultar : Vista<EventArgs>
    {
        public FormConsultar()
        {
            InitializeComponent();
        }

        public void listarDespachos(List<string[]> lista)
        {
            foreach (string[] linha in lista)
            {
                despachos.Rows.Add(linha);
            }
        }

        public void listarPedidosDeReforco(List<string[]> lista)
        {
            foreach (string[] linha in lista)
            {
                pedidosDeReforco.Rows.Add(linha);
            }
        }

        public void listarPareceresTecnicos(List<string[]> lista)
        {
            foreach (string[] linha in lista)
            {
                pareceres_tecnico.Rows.Add(linha);
            }
        }

        public void listarPagamentos(List<string[]> lista)
        {
            foreach (string[] linha in lista)
            {
                pagamentos.Rows.Add(linha);
            }
        }

        public void AlterarDadosPromotor(string designacao, string nacionalidade, decimal nib, decimal nif)
        {
            designacao_promotor.Text = designacao;
            this.nacionalidade.Text = nacionalidade;
            this.nib.Text = nib.ToString();
            this.nif.Text = nif.ToString();
        }

        public void AlterarDadosResponsavel(string designacao, string telefone, string email)
        {
            designacao_responsavel.Text = designacao;
            this.telefone.Text = telefone;
            this.email.Text = email;
        }

        public void AlterarDadosProjeto(int id, string username, string tipo, double montante_financiamento, string descricao, string estado, DateTime data_criacao)
        {
            this.id.Text = id.ToString();
            this.tecnico.Text = username;
            this.tipo.Text = tipo;
            montante.Text = montante_financiamento.ToString();
            this.descricao.Text = descricao;
            this.estado.Text = estado;
            data.Text = data_criacao.ToString();
        }
    }
}
