namespace GestorDeProjetosDeFinanciamento.apresentacao.gestor_de_financiamento.vista
{
	partial class FormReforcoDeFinanciamento
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
            this.label3 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.MonthCalendar();
            this.pedir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedir reforço de financiamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Montante";
            // 
            // montante
            // 
            this.montante.Location = new System.Drawing.Point(48, 105);
            this.montante.Name = "montante";
            this.montante.Size = new System.Drawing.Size(110, 20);
            this.montante.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data";
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(291, 110);
            this.data.MaxSelectionCount = 1;
            this.data.Name = "data";
            this.data.TabIndex = 4;
            // 
            // pedir
            // 
            this.pedir.Location = new System.Drawing.Point(206, 302);
            this.pedir.Name = "pedir";
            this.pedir.Size = new System.Drawing.Size(134, 49);
            this.pedir.TabIndex = 5;
            this.pedir.Text = "Pedir Reforço";
            this.pedir.UseVisualStyleBackColor = true;
            this.pedir.Click += new System.EventHandler(this.pedir_Click);
            // 
            // FormReforcoDeFinanciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 383);
            this.Controls.Add(this.pedir);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.montante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormReforcoDeFinanciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Projetos de Financiamento";
            this.Load += new System.EventHandler(this.FormReforcoDeFinanciamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox montante;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MonthCalendar data;
		private System.Windows.Forms.Button pedir;
	}
}