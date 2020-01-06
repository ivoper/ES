namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista
{
	partial class FormAprovacaoReforco
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
            this.sim = new System.Windows.Forms.Button();
            this.nao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.montante = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prazo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aprovar Reforço de Financiamento";
            // 
            // sim
            // 
            this.sim.Location = new System.Drawing.Point(42, 133);
            this.sim.Name = "sim";
            this.sim.Size = new System.Drawing.Size(108, 52);
            this.sim.TabIndex = 1;
            this.sim.Text = "Sim";
            this.sim.UseVisualStyleBackColor = true;
            this.sim.Click += new System.EventHandler(this.sim_Click);
            // 
            // nao
            // 
            this.nao.Location = new System.Drawing.Point(304, 133);
            this.nao.Name = "nao";
            this.nao.Size = new System.Drawing.Size(108, 52);
            this.nao.TabIndex = 2;
            this.nao.Text = "Não";
            this.nao.UseVisualStyleBackColor = true;
            this.nao.Click += new System.EventHandler(this.nao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Montante: ";
            // 
            // montante
            // 
            this.montante.AutoSize = true;
            this.montante.Location = new System.Drawing.Point(89, 62);
            this.montante.Name = "montante";
            this.montante.Size = new System.Drawing.Size(0, 13);
            this.montante.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prazo :";
            // 
            // prazo
            // 
            this.prazo.AutoSize = true;
            this.prazo.Location = new System.Drawing.Point(71, 91);
            this.prazo.Name = "prazo";
            this.prazo.Size = new System.Drawing.Size(0, 13);
            this.prazo.TabIndex = 6;
            // 
            // FormAprovacaoReforco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 204);
            this.Controls.Add(this.prazo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.montante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nao);
            this.Controls.Add(this.sim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAprovacaoReforco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Projetos de Financiamento";
            this.Load += new System.EventHandler(this.FormAprovacaoReforco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button sim;
		private System.Windows.Forms.Button nao;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label montante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label prazo;
    }
}