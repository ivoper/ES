namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista
{
    partial class FormRealizarDespachoBonificacao
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
            this.montante_maximo = new System.Windows.Forms.TextBox();
            this.taxa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // montante_maximo
            // 
            this.montante_maximo.Location = new System.Drawing.Point(15, 188);
            this.montante_maximo.Name = "montante_maximo";
            this.montante_maximo.Size = new System.Drawing.Size(100, 20);
            this.montante_maximo.TabIndex = 21;
            // 
            // taxa
            // 
            this.taxa.Location = new System.Drawing.Point(15, 90);
            this.taxa.Name = "taxa";
            this.taxa.Size = new System.Drawing.Size(100, 20);
            this.taxa.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Montante máximo de bonificação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Taxa de bonificação";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Período de bonificação";
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(226, 96);
            this.data.Name = "data";
            this.data.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(86, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bonificação - Preencha Campos Obrigatórios";
            // 
            // confirmar
            // 
            this.confirmar.Location = new System.Drawing.Point(195, 270);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(75, 23);
            this.confirmar.TabIndex = 24;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // FormRealizarDespachoBonificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 300);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.montante_maximo);
            this.Controls.Add(this.taxa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRealizarDespachoBonificacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Projetos de Financiamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox montante_maximo;
        private System.Windows.Forms.TextBox taxa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MonthCalendar data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmar;
    }
}