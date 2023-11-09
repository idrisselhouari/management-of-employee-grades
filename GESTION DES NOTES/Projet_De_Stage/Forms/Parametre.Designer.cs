namespace Projet_De_Stage.Forms
{
    partial class Parametre
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
            this.ModifierMotPasse = new System.Windows.Forms.Button();
            this.ModifierUtilisateur = new System.Windows.Forms.Button();
            this.panelParametre = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModifierMotPasse
            // 
            this.ModifierMotPasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.ModifierMotPasse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.ModifierMotPasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierMotPasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierMotPasse.Location = new System.Drawing.Point(171, 88);
            this.ModifierMotPasse.Name = "ModifierMotPasse";
            this.ModifierMotPasse.Size = new System.Drawing.Size(185, 42);
            this.ModifierMotPasse.TabIndex = 0;
            this.ModifierMotPasse.Text = "Modifier mot de passe";
            this.ModifierMotPasse.UseVisualStyleBackColor = false;
            this.ModifierMotPasse.Click += new System.EventHandler(this.ModifierMotPasse_Click);
            // 
            // ModifierUtilisateur
            // 
            this.ModifierUtilisateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.ModifierUtilisateur.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.ModifierUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierUtilisateur.Location = new System.Drawing.Point(552, 88);
            this.ModifierUtilisateur.Name = "ModifierUtilisateur";
            this.ModifierUtilisateur.Size = new System.Drawing.Size(185, 42);
            this.ModifierUtilisateur.TabIndex = 1;
            this.ModifierUtilisateur.Text = "Modifier l\'utilisateur";
            this.ModifierUtilisateur.UseVisualStyleBackColor = false;
            this.ModifierUtilisateur.Click += new System.EventHandler(this.ModifierUtilisateur_Click);
            // 
            // panelParametre
            // 
            this.panelParametre.Location = new System.Drawing.Point(158, 168);
            this.panelParametre.Name = "panelParametre";
            this.panelParametre.Size = new System.Drawing.Size(591, 268);
            this.panelParametre.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 59);
            this.panel1.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bell MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(364, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "PARAMETRES";
            // 
            // Parametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelParametre);
            this.Controls.Add(this.ModifierUtilisateur);
            this.Controls.Add(this.ModifierMotPasse);
            this.Name = "Parametre";
            this.Text = "Parametre";
            this.Load += new System.EventHandler(this.Parametre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Connexion;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_utilisateur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ModifierMotPasse;
        private System.Windows.Forms.Button ModifierUtilisateur;
        private System.Windows.Forms.Panel panelParametre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}