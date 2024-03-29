﻿namespace GestorDeProjetosDeFinanciamento.apresentacao.tecnico.vista
{
    partial class FormMenuTecnico
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
            this.menuTecnicoLabel = new System.Windows.Forms.Label();
            this.apresentarCandidatura = new System.Windows.Forms.Button();
            this.reenquadrarProjeto = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.consulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuTecnicoLabel
            // 
            this.menuTecnicoLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTecnicoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTecnicoLabel.Location = new System.Drawing.Point(0, 0);
            this.menuTecnicoLabel.Name = "menuTecnicoLabel";
            this.menuTecnicoLabel.Size = new System.Drawing.Size(466, 42);
            this.menuTecnicoLabel.TabIndex = 0;
            this.menuTecnicoLabel.Text = "Menu Técnico";
            this.menuTecnicoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // apresentarCandidatura
            // 
            this.apresentarCandidatura.Location = new System.Drawing.Point(121, 217);
            this.apresentarCandidatura.Name = "apresentarCandidatura";
            this.apresentarCandidatura.Size = new System.Drawing.Size(110, 59);
            this.apresentarCandidatura.TabIndex = 1;
            this.apresentarCandidatura.Text = "Apresentar Candidatura";
            this.apresentarCandidatura.UseVisualStyleBackColor = true;
            this.apresentarCandidatura.Click += new System.EventHandler(this.button1_Click);
            // 
            // reenquadrarProjeto
            // 
            this.reenquadrarProjeto.Location = new System.Drawing.Point(237, 217);
            this.reenquadrarProjeto.Name = "reenquadrarProjeto";
            this.reenquadrarProjeto.Size = new System.Drawing.Size(111, 59);
            this.reenquadrarProjeto.TabIndex = 2;
            this.reenquadrarProjeto.Text = "Reenquadrar Projeto";
            this.reenquadrarProjeto.UseVisualStyleBackColor = true;
            this.reenquadrarProjeto.Click += new System.EventHandler(this.button2_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 74);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(20, 91);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 13);
            this.username.TabIndex = 6;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(360, 54);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 7;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // consulta
            // 
            this.consulta.Location = new System.Drawing.Point(346, 83);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(100, 39);
            this.consulta.TabIndex = 11;
            this.consulta.Text = "Consultar";
            this.consulta.UseVisualStyleBackColor = true;
            this.consulta.Click += new System.EventHandler(this.consulta_Click);
            // 
            // FormMenuTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(466, 288);
            this.Controls.Add(this.consulta);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.username);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.reenquadrarProjeto);
            this.Controls.Add(this.apresentarCandidatura);
            this.Controls.Add(this.menuTecnicoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenuTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Projetos de Financiamento";
            this.Load += new System.EventHandler(this.FormMenuTecnico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuTecnicoLabel;
        private System.Windows.Forms.Button apresentarCandidatura;
        private System.Windows.Forms.Button reenquadrarProjeto;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label username;
		private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button consulta;
    }
}