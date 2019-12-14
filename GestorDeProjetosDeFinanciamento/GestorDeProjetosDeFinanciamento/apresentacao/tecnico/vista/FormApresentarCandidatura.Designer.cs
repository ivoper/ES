namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista
{
    partial class ApresentarCandidatura
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.designacaolabel = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.tituloLabel.Location = new System.Drawing.Point(0, 9);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(543, 46);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "Apresentar Candidatura";
            this.tituloLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // designacaolabel
            // 
            this.designacaolabel.AutoSize = true;
            this.designacaolabel.Location = new System.Drawing.Point(12, 65);
            this.designacaolabel.Name = "designacaolabel";
            this.designacaolabel.Size = new System.Drawing.Size(64, 13);
            this.designacaolabel.TabIndex = 1;
            this.designacaolabel.Text = "Designação";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(15, 81);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(515, 66);
            this.descricaoTextBox.TabIndex = 2;
            this.descricaoTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ApresentarCandidatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 486);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.designacaolabel);
            this.Controls.Add(this.tituloLabel);
            this.Name = "ApresentarCandidatura";
            this.Text = "Gestor de Projetos de Financiamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label designacaolabel;
        private System.Windows.Forms.TextBox descricaoTextBox;
    }
}