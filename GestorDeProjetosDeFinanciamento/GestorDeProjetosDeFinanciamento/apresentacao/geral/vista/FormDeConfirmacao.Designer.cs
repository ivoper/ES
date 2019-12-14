namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.vista
{
	partial class FormDeConfirmacao
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
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.label1.Location = new System.Drawing.Point(67, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(278, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Confirma a sua ação?";
			// 
			// sim
			// 
			this.sim.Location = new System.Drawing.Point(73, 110);
			this.sim.Name = "sim";
			this.sim.Size = new System.Drawing.Size(99, 43);
			this.sim.TabIndex = 1;
			this.sim.Text = "Sim";
			this.sim.UseVisualStyleBackColor = true;
			this.sim.Click += new System.EventHandler(this.sim_Click);
			// 
			// nao
			// 
			this.nao.Location = new System.Drawing.Point(246, 110);
			this.nao.Name = "nao";
			this.nao.Size = new System.Drawing.Size(99, 43);
			this.nao.TabIndex = 2;
			this.nao.Text = "Não";
			this.nao.UseVisualStyleBackColor = true;
			this.nao.Click += new System.EventHandler(this.nao_Click);
			// 
			// FormDeConfirmacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(423, 218);
			this.Controls.Add(this.nao);
			this.Controls.Add(this.sim);
			this.Controls.Add(this.label1);
			this.Name = "FormDeConfirmacao";
			this.Text = "Gestor de Projetos de Financiamento";
			this.Load += new System.EventHandler(this.FormDeConfirmacao_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button sim;
		private System.Windows.Forms.Button nao;
	}
}