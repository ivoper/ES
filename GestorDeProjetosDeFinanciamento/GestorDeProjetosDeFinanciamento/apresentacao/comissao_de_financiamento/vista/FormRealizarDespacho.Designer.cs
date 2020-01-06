namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista
{
	partial class FormRealizarDespacho
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
            this.resultado = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.realizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realizar Despacho";
            // 
            // resultado
            // 
            this.resultado.FormattingEnabled = true;
            this.resultado.Items.AddRange(new object[] {
            "Aprovado",
            "Rejeitado"});
            this.resultado.Location = new System.Drawing.Point(71, 111);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(159, 43);
            this.resultado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado";
            // 
            // realizar
            // 
            this.realizar.Location = new System.Drawing.Point(80, 179);
            this.realizar.Name = "realizar";
            this.realizar.Size = new System.Drawing.Size(141, 58);
            this.realizar.TabIndex = 9;
            this.realizar.Text = "Realizar";
            this.realizar.UseVisualStyleBackColor = true;
            this.realizar.Click += new System.EventHandler(this.realizar_Click);
            // 
            // FormRealizarDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 270);
            this.Controls.Add(this.realizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRealizarDespacho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Projetos de Financiamento";
            this.Load += new System.EventHandler(this.FormRealizarDespacho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox resultado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button realizar;
	}
}