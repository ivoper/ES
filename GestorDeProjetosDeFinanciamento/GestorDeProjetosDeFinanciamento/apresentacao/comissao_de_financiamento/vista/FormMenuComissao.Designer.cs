namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista
{
	partial class FormMenuComissao
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.realizarDespacho = new System.Windows.Forms.Button();
			this.reativarProjeto = new System.Windows.Forms.Button();
			this.suspenderProjeto = new System.Windows.Forms.Button();
			this.decidirAprovacao = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
			this.label1.Location = new System.Drawing.Point(45, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(543, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menu Comissão de Financiamento";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// realizarDespacho
			// 
			this.realizarDespacho.Location = new System.Drawing.Point(33, 244);
			this.realizarDespacho.Name = "realizarDespacho";
			this.realizarDespacho.Size = new System.Drawing.Size(103, 47);
			this.realizarDespacho.TabIndex = 2;
			this.realizarDespacho.Text = "Realizar Despacho";
			this.realizarDespacho.UseVisualStyleBackColor = true;
			this.realizarDespacho.Click += new System.EventHandler(this.realizarDespacho_Click);
			// 
			// reativarProjeto
			// 
			this.reativarProjeto.Location = new System.Drawing.Point(485, 244);
			this.reativarProjeto.Name = "reativarProjeto";
			this.reativarProjeto.Size = new System.Drawing.Size(103, 47);
			this.reativarProjeto.TabIndex = 3;
			this.reativarProjeto.Text = "Reativar Projeto";
			this.reativarProjeto.UseVisualStyleBackColor = true;
			this.reativarProjeto.Click += new System.EventHandler(this.reativarProjeto_Click);
			// 
			// suspenderProjeto
			// 
			this.suspenderProjeto.Location = new System.Drawing.Point(343, 244);
			this.suspenderProjeto.Name = "suspenderProjeto";
			this.suspenderProjeto.Size = new System.Drawing.Size(103, 47);
			this.suspenderProjeto.TabIndex = 4;
			this.suspenderProjeto.Text = "Suspender Projeto";
			this.suspenderProjeto.UseVisualStyleBackColor = true;
			this.suspenderProjeto.Click += new System.EventHandler(this.suspenderProjeto_Click);
			// 
			// decidirAprovacao
			// 
			this.decidirAprovacao.Location = new System.Drawing.Point(191, 244);
			this.decidirAprovacao.Name = "decidirAprovacao";
			this.decidirAprovacao.Size = new System.Drawing.Size(103, 47);
			this.decidirAprovacao.TabIndex = 5;
			this.decidirAprovacao.Text = "Decidir aprovação de reforço";
			this.decidirAprovacao.UseVisualStyleBackColor = true;
			this.decidirAprovacao.Click += new System.EventHandler(this.decidirAprovacao_Click);
			// 
			// FormMenuComissao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(633, 370);
			this.Controls.Add(this.decidirAprovacao);
			this.Controls.Add(this.suspenderProjeto);
			this.Controls.Add(this.reativarProjeto);
			this.Controls.Add(this.realizarDespacho);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormMenuComissao";
			this.Text = "Gestor de Projetos de Financiamento";
			this.Load += new System.EventHandler(this.FormMenuComissao_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button realizarDespacho;
		private System.Windows.Forms.Button reativarProjeto;
		private System.Windows.Forms.Button suspenderProjeto;
		private System.Windows.Forms.Button decidirAprovacao;
	}
}