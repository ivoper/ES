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
            this.confirmar = new System.Windows.Forms.Button();
            this.listaProjetos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listaProjetos)).BeginInit();
            this.SuspendLayout();
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
            // listaProjetos
            // 
            this.listaProjetos.AllowUserToAddRows = false;
            this.listaProjetos.AllowUserToDeleteRows = false;
            this.listaProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaProjetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tipo,
            this.Descricao,
            this.DataCriacao});
            this.listaProjetos.Location = new System.Drawing.Point(9, 10);
            this.listaProjetos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaProjetos.Name = "listaProjetos";
            this.listaProjetos.ReadOnly = true;
            this.listaProjetos.RowTemplate.Height = 24;
            this.listaProjetos.Size = new System.Drawing.Size(675, 318);
            this.listaProjetos.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // DataCriacao
            // 
            this.DataCriacao.HeaderText = "Data de Criação";
            this.DataCriacao.Name = "DataCriacao";
            this.DataCriacao.ReadOnly = true;
            // 
            // FormListarProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 407);
            this.Controls.Add(this.listaProjetos);
            this.Controls.Add(this.confirmar);
            this.Name = "FormListarProjetos";
            this.Text = "Gestor de Projetos de Financiamento";
            this.Load += new System.EventHandler(this.FormListarProjetos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaProjetos)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.DataGridView listaProjetos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCriacao;
    }
}