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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.montante = new System.Windows.Forms.TextBox();
			this.custoElegivel = new System.Windows.Forms.TextBox();
			this.prazo = new System.Windows.Forms.MonthCalendar();
			this.realizar = new System.Windows.Forms.Button();
			this.montante_maximo = new System.Windows.Forms.TextBox();
			this.taxa = new System.Windows.Forms.TextBox();
			this.periodo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.label1.Location = new System.Drawing.Point(185, 9);
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
			this.resultado.Location = new System.Drawing.Point(15, 95);
			this.resultado.Name = "resultado";
			this.resultado.Size = new System.Drawing.Size(159, 43);
			this.resultado.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Resultado";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(237, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Montante";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(237, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Custo Elegivel";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(374, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Prazo de Execução";
			// 
			// montante
			// 
			this.montante.Location = new System.Drawing.Point(240, 141);
			this.montante.Name = "montante";
			this.montante.Size = new System.Drawing.Size(100, 20);
			this.montante.TabIndex = 6;
			// 
			// custoElegivel
			// 
			this.custoElegivel.Location = new System.Drawing.Point(240, 95);
			this.custoElegivel.Name = "custoElegivel";
			this.custoElegivel.Size = new System.Drawing.Size(100, 20);
			this.custoElegivel.TabIndex = 7;
			// 
			// prazo
			// 
			this.prazo.Location = new System.Drawing.Point(377, 75);
			this.prazo.MaxSelectionCount = 1;
			this.prazo.Name = "prazo";
			this.prazo.TabIndex = 8;
			// 
			// realizar
			// 
			this.realizar.Location = new System.Drawing.Point(240, 304);
			this.realizar.Name = "realizar";
			this.realizar.Size = new System.Drawing.Size(141, 58);
			this.realizar.TabIndex = 9;
			this.realizar.Text = "Realizar";
			this.realizar.UseVisualStyleBackColor = true;
			this.realizar.Click += new System.EventHandler(this.realizar_Click);
			// 
			// montante_maximo
			// 
			this.montante_maximo.Location = new System.Drawing.Point(37, 341);
			this.montante_maximo.Name = "montante_maximo";
			this.montante_maximo.Size = new System.Drawing.Size(100, 20);
			this.montante_maximo.TabIndex = 15;
			// 
			// taxa
			// 
			this.taxa.Location = new System.Drawing.Point(37, 232);
			this.taxa.Name = "taxa";
			this.taxa.Size = new System.Drawing.Size(100, 20);
			this.taxa.TabIndex = 14;
			// 
			// periodo
			// 
			this.periodo.Location = new System.Drawing.Point(37, 285);
			this.periodo.Name = "periodo";
			this.periodo.Size = new System.Drawing.Size(100, 20);
			this.periodo.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 324);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(163, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Montante máximo de bonificação";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(35, 216);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Taxa de bonificação";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(34, 269);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(118, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Período de bonificação";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 193);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(308, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Preencher se o projeto seja do tipo bonificação ou transformado";
			// 
			// FormRealizarDespacho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 380);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.montante_maximo);
			this.Controls.Add(this.taxa);
			this.Controls.Add(this.periodo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.realizar);
			this.Controls.Add(this.prazo);
			this.Controls.Add(this.custoElegivel);
			this.Controls.Add(this.montante);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.resultado);
			this.Controls.Add(this.label1);
			this.Name = "FormRealizarDespacho";
			this.Text = "Gestor de Projetos de Financiamento";
			this.Load += new System.EventHandler(this.FormRealizarDespacho_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox resultado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox montante;
		private System.Windows.Forms.TextBox custoElegivel;
		private System.Windows.Forms.MonthCalendar prazo;
		private System.Windows.Forms.Button realizar;
		private System.Windows.Forms.TextBox montante_maximo;
		private System.Windows.Forms.TextBox taxa;
		private System.Windows.Forms.TextBox periodo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
	}
}