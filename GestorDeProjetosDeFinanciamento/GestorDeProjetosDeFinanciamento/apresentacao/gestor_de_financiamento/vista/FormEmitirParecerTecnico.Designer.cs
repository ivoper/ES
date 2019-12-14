namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista
{
	partial class FormEmitirParecerTecnico
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
			this.textoLivre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.decisao = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.emitir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.label1.Location = new System.Drawing.Point(144, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(288, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Emitir Parecer Técnico";
			// 
			// textoLivre
			// 
			this.textoLivre.Location = new System.Drawing.Point(59, 88);
			this.textoLivre.Multiline = true;
			this.textoLivre.Name = "textoLivre";
			this.textoLivre.Size = new System.Drawing.Size(457, 20);
			this.textoLivre.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Descrição";
			// 
			// decisao
			// 
			this.decisao.FormattingEnabled = true;
			this.decisao.Items.AddRange(new object[] {
            "Aprovado",
            "Rejeitado"});
			this.decisao.Location = new System.Drawing.Point(59, 172);
			this.decisao.Name = "decisao";
			this.decisao.Size = new System.Drawing.Size(120, 30);
			this.decisao.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Decisão";
			// 
			// emitir
			// 
			this.emitir.Location = new System.Drawing.Point(233, 239);
			this.emitir.Name = "emitir";
			this.emitir.Size = new System.Drawing.Size(105, 40);
			this.emitir.TabIndex = 5;
			this.emitir.Text = "Emitir";
			this.emitir.UseVisualStyleBackColor = true;
			this.emitir.Click += new System.EventHandler(this.emitir_Click);
			// 
			// FormEmitirParecerTecnico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 312);
			this.Controls.Add(this.emitir);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.decisao);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textoLivre);
			this.Controls.Add(this.label1);
			this.Name = "FormEmitirParecerTecnico";
			this.Text = "Gestor de Projetos de Financiamento";
			this.Load += new System.EventHandler(this.FormEmitirParecerTecnico_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textoLivre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox decisao;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button emitir;
	}
}