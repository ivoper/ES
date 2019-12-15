namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista
{
	partial class FormRealizarPagamento
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
			this.montante = new System.Windows.Forms.TextBox();
			this.pagar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
			this.label1.Location = new System.Drawing.Point(135, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(326, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "Realizar Pagamento";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(75, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Montante";
			// 
			// montante
			// 
			this.montante.Location = new System.Drawing.Point(78, 101);
			this.montante.Name = "montante";
			this.montante.Size = new System.Drawing.Size(100, 20);
			this.montante.TabIndex = 2;
			// 
			// pagar
			// 
			this.pagar.Location = new System.Drawing.Point(233, 184);
			this.pagar.Name = "pagar";
			this.pagar.Size = new System.Drawing.Size(111, 46);
			this.pagar.TabIndex = 3;
			this.pagar.Text = "Pagar";
			this.pagar.UseVisualStyleBackColor = true;
			this.pagar.Click += new System.EventHandler(this.pagar_Click);
			// 
			// FormRealizarPagamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(579, 300);
			this.Controls.Add(this.pagar);
			this.Controls.Add(this.montante);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormRealizarPagamento";
			this.Text = "Gestor de Projetos de Financiamento";
			this.Load += new System.EventHandler(this.FormRealizarPagamento_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox montante;
		private System.Windows.Forms.Button pagar;
	}
}