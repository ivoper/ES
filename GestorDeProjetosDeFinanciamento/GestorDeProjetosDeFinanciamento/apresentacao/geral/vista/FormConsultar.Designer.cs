namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.vista
{
    partial class FormConsultar
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
			this.despachos = new System.Windows.Forms.DataGridView();
			this.pareceres_tecnico = new System.Windows.Forms.DataGridView();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.designacao_promotor = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nacionalidade = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.nib = new System.Windows.Forms.Label();
			this.nif = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.designacao_responsavel = new System.Windows.Forms.Label();
			this.telefone = new System.Windows.Forms.Label();
			this.email = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tecnico = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.tipo = new System.Windows.Forms.Label();
			this.montante = new System.Windows.Forms.Label();
			this.descricao = new System.Windows.Forms.Label();
			this.estado = new System.Windows.Forms.Label();
			this.data = new System.Windows.Forms.Label();
			this.pagamentos = new System.Windows.Forms.DataGridView();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.despachos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pareceres_tecnico)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pagamentos)).BeginInit();
			this.SuspendLayout();
			// 
			// despachos
			// 
			this.despachos.AllowUserToAddRows = false;
			this.despachos.AllowUserToDeleteRows = false;
			this.despachos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.despachos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column11,
            this.Column12,
            this.Column13});
			this.despachos.Location = new System.Drawing.Point(16, 520);
			this.despachos.Name = "despachos";
			this.despachos.ReadOnly = true;
			this.despachos.Size = new System.Drawing.Size(935, 398);
			this.despachos.TabIndex = 0;
			// 
			// pareceres_tecnico
			// 
			this.pareceres_tecnico.AllowUserToAddRows = false;
			this.pareceres_tecnico.AllowUserToDeleteRows = false;
			this.pareceres_tecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.pareceres_tecnico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
			this.pareceres_tecnico.Location = new System.Drawing.Point(16, 257);
			this.pareceres_tecnico.Name = "pareceres_tecnico";
			this.pareceres_tecnico.ReadOnly = true;
			this.pareceres_tecnico.Size = new System.Drawing.Size(528, 257);
			this.pareceres_tecnico.TabIndex = 1;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Decisão";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column7.HeaderText = "Texto";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Data de Criação";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
			this.label1.Location = new System.Drawing.Point(191, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Dados Promotor";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Designação : ";
			// 
			// designacao_promotor
			// 
			this.designacao_promotor.AutoSize = true;
			this.designacao_promotor.Location = new System.Drawing.Point(92, 38);
			this.designacao_promotor.Name = "designacao_promotor";
			this.designacao_promotor.Size = new System.Drawing.Size(0, 13);
			this.designacao_promotor.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nacionalidade : ";
			// 
			// nacionalidade
			// 
			this.nacionalidade.AutoSize = true;
			this.nacionalidade.Location = new System.Drawing.Point(103, 55);
			this.nacionalidade.Name = "nacionalidade";
			this.nacionalidade.Size = new System.Drawing.Size(0, 13);
			this.nacionalidade.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Nib : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 85);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Nif : ";
			// 
			// nib
			// 
			this.nib.AutoSize = true;
			this.nib.Location = new System.Drawing.Point(51, 72);
			this.nib.Name = "nib";
			this.nib.Size = new System.Drawing.Size(0, 13);
			this.nib.TabIndex = 9;
			// 
			// nif
			// 
			this.nif.AutoSize = true;
			this.nif.Location = new System.Drawing.Point(49, 85);
			this.nif.Name = "nif";
			this.nif.Size = new System.Drawing.Size(0, 13);
			this.nif.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(660, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(118, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Dados do Responsavel";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(557, 38);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Designação : ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(557, 55);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "Telefone : ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(560, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 13);
			this.label9.TabIndex = 14;
			this.label9.Text = "Email : ";
			// 
			// designacao_responsavel
			// 
			this.designacao_responsavel.AutoSize = true;
			this.designacao_responsavel.Location = new System.Drawing.Point(637, 38);
			this.designacao_responsavel.Name = "designacao_responsavel";
			this.designacao_responsavel.Size = new System.Drawing.Size(0, 13);
			this.designacao_responsavel.TabIndex = 15;
			// 
			// telefone
			// 
			this.telefone.AutoSize = true;
			this.telefone.Location = new System.Drawing.Point(622, 55);
			this.telefone.Name = "telefone";
			this.telefone.Size = new System.Drawing.Size(0, 13);
			this.telefone.TabIndex = 16;
			// 
			// email
			// 
			this.email.AutoSize = true;
			this.email.Location = new System.Drawing.Point(608, 72);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(0, 13);
			this.email.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label10.Location = new System.Drawing.Point(15, 147);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(107, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "Tecnico Associado : ";
			// 
			// tecnico
			// 
			this.tecnico.AutoSize = true;
			this.tecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.tecnico.Location = new System.Drawing.Point(131, 149);
			this.tecnico.Name = "tecnico";
			this.tecnico.Size = new System.Drawing.Size(0, 13);
			this.tecnico.TabIndex = 19;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F);
			this.label11.Location = new System.Drawing.Point(194, 103);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(85, 15);
			this.label11.TabIndex = 20;
			this.label11.Text = "Dados Projeto";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(16, 131);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(25, 13);
			this.label12.TabIndex = 21;
			this.label12.Text = "Id : ";
			// 
			// id
			// 
			this.id.AutoSize = true;
			this.id.Location = new System.Drawing.Point(48, 131);
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(0, 13);
			this.id.TabIndex = 22;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(16, 164);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(37, 13);
			this.label13.TabIndex = 23;
			this.label13.Text = "Tipo : ";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(16, 181);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(150, 13);
			this.label14.TabIndex = 24;
			this.label14.Text = "Montante De Financiamento : ";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(16, 198);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(64, 13);
			this.label15.TabIndex = 25;
			this.label15.Text = "Descrição : ";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(18, 215);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(49, 13);
			this.label16.TabIndex = 26;
			this.label16.Text = "Estado : ";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(19, 232);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(92, 13);
			this.label17.TabIndex = 27;
			this.label17.Text = "Data de criação : ";
			// 
			// tipo
			// 
			this.tipo.AutoSize = true;
			this.tipo.Location = new System.Drawing.Point(51, 164);
			this.tipo.Name = "tipo";
			this.tipo.Size = new System.Drawing.Size(0, 13);
			this.tipo.TabIndex = 28;
			// 
			// montante
			// 
			this.montante.AutoSize = true;
			this.montante.Location = new System.Drawing.Point(173, 181);
			this.montante.Name = "montante";
			this.montante.Size = new System.Drawing.Size(0, 13);
			this.montante.TabIndex = 29;
			// 
			// descricao
			// 
			this.descricao.AutoSize = true;
			this.descricao.Location = new System.Drawing.Point(81, 198);
			this.descricao.Name = "descricao";
			this.descricao.Size = new System.Drawing.Size(0, 13);
			this.descricao.TabIndex = 30;
			// 
			// estado
			// 
			this.estado.AutoSize = true;
			this.estado.Location = new System.Drawing.Point(65, 215);
			this.estado.Name = "estado";
			this.estado.Size = new System.Drawing.Size(0, 13);
			this.estado.TabIndex = 31;
			// 
			// data
			// 
			this.data.AutoSize = true;
			this.data.Location = new System.Drawing.Point(117, 232);
			this.data.Name = "data";
			this.data.Size = new System.Drawing.Size(0, 13);
			this.data.TabIndex = 32;
			// 
			// pagamentos
			// 
			this.pagamentos.AllowUserToAddRows = false;
			this.pagamentos.AllowUserToDeleteRows = false;
			this.pagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.pagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10});
			this.pagamentos.Location = new System.Drawing.Point(550, 257);
			this.pagamentos.Name = "pagamentos";
			this.pagamentos.ReadOnly = true;
			this.pagamentos.Size = new System.Drawing.Size(401, 257);
			this.pagamentos.TabIndex = 33;
			// 
			// Column9
			// 
			this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column9.HeaderText = "Montante";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			// 
			// Column10
			// 
			this.Column10.HeaderText = "Data";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Resultado";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Montante";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Custo Elegível";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Prazo de Execução";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Data de Criação";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column11
			// 
			this.Column11.HeaderText = "Período de bonificação";
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			// 
			// Column12
			// 
			this.Column12.HeaderText = "Taxa de bonificação";
			this.Column12.Name = "Column12";
			this.Column12.ReadOnly = true;
			// 
			// Column13
			// 
			this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column13.HeaderText = "Montante máximo de bonificação";
			this.Column13.Name = "Column13";
			this.Column13.ReadOnly = true;
			// 
			// FormConsultar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(963, 930);
			this.Controls.Add(this.pagamentos);
			this.Controls.Add(this.data);
			this.Controls.Add(this.estado);
			this.Controls.Add(this.descricao);
			this.Controls.Add(this.montante);
			this.Controls.Add(this.tipo);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.id);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.tecnico);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.email);
			this.Controls.Add(this.telefone);
			this.Controls.Add(this.designacao_responsavel);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nif);
			this.Controls.Add(this.nib);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nacionalidade);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.designacao_promotor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pareceres_tecnico);
			this.Controls.Add(this.despachos);
			this.Name = "FormConsultar";
			this.Text = "Gestor de Projetos de Financiamento";
			((System.ComponentModel.ISupportInitialize)(this.despachos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pareceres_tecnico)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pagamentos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView despachos;
        private System.Windows.Forms.DataGridView pareceres_tecnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label designacao_promotor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label nacionalidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nib;
        private System.Windows.Forms.Label nif;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label designacao_responsavel;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tecnico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label montante;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.Label estado;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridView pagamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
	}
}