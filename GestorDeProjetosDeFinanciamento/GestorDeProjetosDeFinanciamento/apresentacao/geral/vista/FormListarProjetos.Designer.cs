namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.vista
{
	partial class FormListarProjetos
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
            this.projetos = new System.Windows.Forms.ListBox();
            this.confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projetos
            // 
            this.projetos.FormattingEnabled = true;
            this.projetos.Location = new System.Drawing.Point(12, 12);
            this.projetos.Name = "projetos";
            this.projetos.Size = new System.Drawing.Size(669, 316);
            this.projetos.TabIndex = 0;
            this.projetos.SelectedIndexChanged += new System.EventHandler(this.projetos_SelectedIndexChanged);
            // 
            // confirmar
            // 
            this.confirmar.Location = new System.Drawing.Point(275, 334);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(149, 64);
            this.confirmar.TabIndex = 1;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // FormListarProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 407);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.projetos);
            this.Name = "FormListarProjetos";
            this.Text = "Gestor de Projetos de Financiamento";
            this.Load += new System.EventHandler(this.FormListarProjetos_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox projetos;
		private System.Windows.Forms.Button confirmar;
	}
}