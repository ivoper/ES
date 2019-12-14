namespace GestorDeProjetosDeFinanciamento.apresentacao.geral.vista
{
    partial class FormDeErro
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
            this.mensagemDeErro = new System.Windows.Forms.Label();
            this.copiar = new System.Windows.Forms.Button();
            this.fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mensagemDeErro
            // 
            this.mensagemDeErro.Location = new System.Drawing.Point(12, 9);
            this.mensagemDeErro.MaximumSize = new System.Drawing.Size(400, 150);
            this.mensagemDeErro.Name = "mensagemDeErro";
            this.mensagemDeErro.Size = new System.Drawing.Size(400, 150);
            this.mensagemDeErro.TabIndex = 0;
            // 
            // copiar
            // 
            this.copiar.Location = new System.Drawing.Point(254, 166);
            this.copiar.Name = "copiar";
            this.copiar.Size = new System.Drawing.Size(75, 23);
            this.copiar.TabIndex = 1;
            this.copiar.Text = "Copiar";
            this.copiar.UseVisualStyleBackColor = true;
            this.copiar.Click += new System.EventHandler(this.copiar_Click);
            // 
            // fechar
            // 
            this.fechar.Location = new System.Drawing.Point(335, 166);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(75, 23);
            this.fechar.TabIndex = 2;
            this.fechar.Text = "Fechar";
            this.fechar.UseVisualStyleBackColor = true;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // FormDeErro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 201);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.copiar);
            this.Controls.Add(this.mensagemDeErro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDeErro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagem de Erro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mensagemDeErro;
        private System.Windows.Forms.Button copiar;
        private System.Windows.Forms.Button fechar;
    }
}