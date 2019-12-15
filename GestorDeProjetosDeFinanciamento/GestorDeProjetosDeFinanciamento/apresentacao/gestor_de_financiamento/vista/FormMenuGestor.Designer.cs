namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista
{
	partial class FormMenuGestor
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
			this.emitirParecer = new System.Windows.Forms.Button();
			this.realizarPagamento = new System.Windows.Forms.Button();
			this.alterarDados = new System.Windows.Forms.Button();
			this.reativarProjeto = new System.Windows.Forms.Button();
			this.pedirReforco = new System.Windows.Forms.Button();
			this.suspenderProjeto = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
			this.label1.Location = new System.Drawing.Point(38, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(612, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menu do gestor de financiamento";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// emitirParecer
			// 
			this.emitirParecer.Location = new System.Drawing.Point(46, 220);
			this.emitirParecer.Name = "emitirParecer";
			this.emitirParecer.Size = new System.Drawing.Size(121, 51);
			this.emitirParecer.TabIndex = 2;
			this.emitirParecer.Text = "Emitir Paracer Técnico";
			this.emitirParecer.UseVisualStyleBackColor = true;
			this.emitirParecer.Click += new System.EventHandler(this.emitirParecer_Click);
			// 
			// realizarPagamento
			// 
			this.realizarPagamento.Location = new System.Drawing.Point(46, 314);
			this.realizarPagamento.Name = "realizarPagamento";
			this.realizarPagamento.Size = new System.Drawing.Size(121, 51);
			this.realizarPagamento.TabIndex = 3;
			this.realizarPagamento.Text = "Realizar Pagamento";
			this.realizarPagamento.UseVisualStyleBackColor = true;
			this.realizarPagamento.Click += new System.EventHandler(this.realizarPagamento_Click);
			// 
			// alterarDados
			// 
			this.alterarDados.Location = new System.Drawing.Point(267, 220);
			this.alterarDados.Name = "alterarDados";
			this.alterarDados.Size = new System.Drawing.Size(121, 51);
			this.alterarDados.TabIndex = 4;
			this.alterarDados.Text = "Alterar Dados";
			this.alterarDados.UseVisualStyleBackColor = true;
			this.alterarDados.Click += new System.EventHandler(this.alterarDados_Click);
			// 
			// reativarProjeto
			// 
			this.reativarProjeto.Location = new System.Drawing.Point(474, 220);
			this.reativarProjeto.Name = "reativarProjeto";
			this.reativarProjeto.Size = new System.Drawing.Size(121, 51);
			this.reativarProjeto.TabIndex = 5;
			this.reativarProjeto.Text = "Reativar Projeto";
			this.reativarProjeto.UseVisualStyleBackColor = true;
			this.reativarProjeto.Click += new System.EventHandler(this.reativarProjeto_Click);
			// 
			// pedirReforco
			// 
			this.pedirReforco.Location = new System.Drawing.Point(267, 314);
			this.pedirReforco.Name = "pedirReforco";
			this.pedirReforco.Size = new System.Drawing.Size(121, 51);
			this.pedirReforco.TabIndex = 6;
			this.pedirReforco.Text = "Pedir Reforço de Financiamento";
			this.pedirReforco.UseVisualStyleBackColor = true;
			this.pedirReforco.Click += new System.EventHandler(this.pedirReforco_Click);
			// 
			// suspenderProjeto
			// 
			this.suspenderProjeto.Location = new System.Drawing.Point(474, 314);
			this.suspenderProjeto.Name = "suspenderProjeto";
			this.suspenderProjeto.Size = new System.Drawing.Size(121, 51);
			this.suspenderProjeto.TabIndex = 7;
			this.suspenderProjeto.Text = "Suspender Projeto";
			this.suspenderProjeto.UseVisualStyleBackColor = true;
			this.suspenderProjeto.Click += new System.EventHandler(this.suspenderProjeto_Click);
			// 
			// FormMenuGestor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 423);
			this.Controls.Add(this.suspenderProjeto);
			this.Controls.Add(this.pedirReforco);
			this.Controls.Add(this.reativarProjeto);
			this.Controls.Add(this.alterarDados);
			this.Controls.Add(this.realizarPagamento);
			this.Controls.Add(this.emitirParecer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormMenuGestor";
			this.Text = "Gestor de Projetos de Financiamento";
			this.Load += new System.EventHandler(this.FormMenuGestor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button emitirParecer;
		private System.Windows.Forms.Button realizarPagamento;
		private System.Windows.Forms.Button alterarDados;
		private System.Windows.Forms.Button reativarProjeto;
		private System.Windows.Forms.Button pedirReforco;
		private System.Windows.Forms.Button suspenderProjeto;
	}
}