namespace GestorDeProjetosDeFinanciamento.apresentacao.comissao_de_financiamento.vista
{
    partial class FormRealizarDespachoIncentivo
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
            this.data = new System.Windows.Forms.MonthCalendar();
            this.custoElegivel = new System.Windows.Forms.TextBox();
            this.montante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(206, 72);
            this.data.MaxSelectionCount = 1;
            this.data.Name = "data";
            this.data.TabIndex = 14;
            // 
            // custoElegivel
            // 
            this.custoElegivel.Location = new System.Drawing.Point(15, 72);
            this.custoElegivel.Name = "custoElegivel";
            this.custoElegivel.Size = new System.Drawing.Size(100, 20);
            this.custoElegivel.TabIndex = 13;
            // 
            // montante
            // 
            this.montante.Location = new System.Drawing.Point(12, 144);
            this.montante.Name = "montante";
            this.montante.Size = new System.Drawing.Size(100, 20);
            this.montante.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prazo de Execução";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Custo Elegivel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Montante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Incentivo - Preencha Campos Obrigatórios";
            // 
            // confirmar
            // 
            this.confirmar.Location = new System.Drawing.Point(182, 258);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(75, 23);
            this.confirmar.TabIndex = 25;
            this.confirmar.Text = "Confirmar";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRealizarDespachoIncentivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 293);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.custoElegivel);
            this.Controls.Add(this.montante);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormRealizarDespachoIncentivo";
            this.Text = "Gestor de Projetos de Financiamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar data;
        private System.Windows.Forms.TextBox custoElegivel;
        private System.Windows.Forms.TextBox montante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmar;
    }
}