using System.Windows.Forms;

namespace Projet_De_Stage
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Deconnexion = new System.Windows.Forms.Button();
            this.Parametres = new System.Windows.Forms.Button();
            this.Afficher_Notes = new System.Windows.Forms.Button();
            this.Ajouter_Notes = new System.Windows.Forms.Button();
            this.btnemplye = new System.Windows.Forms.Button();
            this.btnaccueil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDesktopPane.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.Deconnexion);
            this.panel1.Controls.Add(this.Parametres);
            this.panel1.Controls.Add(this.Afficher_Notes);
            this.panel1.Controls.Add(this.Ajouter_Notes);
            this.panel1.Controls.Add(this.btnemplye);
            this.panel1.Controls.Add(this.btnaccueil);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 560);
            this.panel1.TabIndex = 0;
            // 
            // Deconnexion
            // 
            this.Deconnexion.Dock = System.Windows.Forms.DockStyle.Top;
            this.Deconnexion.FlatAppearance.BorderSize = 0;
            this.Deconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deconnexion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Deconnexion.Image = ((System.Drawing.Image)(resources.GetObject("Deconnexion.Image")));
            this.Deconnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deconnexion.Location = new System.Drawing.Point(0, 361);
            this.Deconnexion.Name = "Deconnexion";
            this.Deconnexion.Size = new System.Drawing.Size(193, 51);
            this.Deconnexion.TabIndex = 7;
            this.Deconnexion.Text = "  Deconnexion";
            this.Deconnexion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Deconnexion.UseVisualStyleBackColor = true;
            this.Deconnexion.Click += new System.EventHandler(this.Deconnexion_Click);
            // 
            // Parametres
            // 
            this.Parametres.Dock = System.Windows.Forms.DockStyle.Top;
            this.Parametres.FlatAppearance.BorderSize = 0;
            this.Parametres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Parametres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parametres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Parametres.Image = ((System.Drawing.Image)(resources.GetObject("Parametres.Image")));
            this.Parametres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Parametres.Location = new System.Drawing.Point(0, 306);
            this.Parametres.Name = "Parametres";
            this.Parametres.Size = new System.Drawing.Size(193, 55);
            this.Parametres.TabIndex = 5;
            this.Parametres.Text = " Parametres";
            this.Parametres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Parametres.UseVisualStyleBackColor = true;
            this.Parametres.Click += new System.EventHandler(this.Parametres_Click);
            // 
            // Afficher_Notes
            // 
            this.Afficher_Notes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Afficher_Notes.FlatAppearance.BorderSize = 0;
            this.Afficher_Notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Afficher_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afficher_Notes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Afficher_Notes.Image = ((System.Drawing.Image)(resources.GetObject("Afficher_Notes.Image")));
            this.Afficher_Notes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Afficher_Notes.Location = new System.Drawing.Point(0, 251);
            this.Afficher_Notes.Name = "Afficher_Notes";
            this.Afficher_Notes.Size = new System.Drawing.Size(193, 55);
            this.Afficher_Notes.TabIndex = 4;
            this.Afficher_Notes.Text = "  Afficher les notes";
            this.Afficher_Notes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Afficher_Notes.UseVisualStyleBackColor = true;
            this.Afficher_Notes.Click += new System.EventHandler(this.Afficher_Notes_Click);
            // 
            // Ajouter_Notes
            // 
            this.Ajouter_Notes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ajouter_Notes.FlatAppearance.BorderSize = 0;
            this.Ajouter_Notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter_Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter_Notes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ajouter_Notes.Image = ((System.Drawing.Image)(resources.GetObject("Ajouter_Notes.Image")));
            this.Ajouter_Notes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajouter_Notes.Location = new System.Drawing.Point(0, 196);
            this.Ajouter_Notes.MaximumSize = new System.Drawing.Size(911, 59);
            this.Ajouter_Notes.Name = "Ajouter_Notes";
            this.Ajouter_Notes.Size = new System.Drawing.Size(193, 55);
            this.Ajouter_Notes.TabIndex = 3;
            this.Ajouter_Notes.Text = "  Ajouter les notes";
            this.Ajouter_Notes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajouter_Notes.UseVisualStyleBackColor = true;
            this.Ajouter_Notes.Click += new System.EventHandler(this.Ajouter_Notes_Click);
            // 
            // btnemplye
            // 
            this.btnemplye.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnemplye.FlatAppearance.BorderSize = 0;
            this.btnemplye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemplye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemplye.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnemplye.Image = ((System.Drawing.Image)(resources.GetObject("btnemplye.Image")));
            this.btnemplye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemplye.Location = new System.Drawing.Point(0, 141);
            this.btnemplye.Name = "btnemplye";
            this.btnemplye.Size = new System.Drawing.Size(193, 55);
            this.btnemplye.TabIndex = 2;
            this.btnemplye.Text = " Employes";
            this.btnemplye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnemplye.UseVisualStyleBackColor = true;
            this.btnemplye.Click += new System.EventHandler(this.btnemplye_Click);
            // 
            // btnaccueil
            // 
            this.btnaccueil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnaccueil.FlatAppearance.BorderSize = 0;
            this.btnaccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccueil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnaccueil.Image = ((System.Drawing.Image)(resources.GetObject("btnaccueil.Image")));
            this.btnaccueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaccueil.Location = new System.Drawing.Point(0, 90);
            this.btnaccueil.Name = "btnaccueil";
            this.btnaccueil.Size = new System.Drawing.Size(193, 51);
            this.btnaccueil.TabIndex = 1;
            this.btnaccueil.Text = "  Accueil";
            this.btnaccueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaccueil.UseVisualStyleBackColor = true;
            this.btnaccueil.Click += new System.EventHandler(this.btnaccueil_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 90);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktopPane.BackColor = System.Drawing.Color.White;
            this.panelDesktopPane.Controls.Add(this.panel3);
            this.panelDesktopPane.Controls.Add(this.label3);
            this.panelDesktopPane.Controls.Add(this.label2);
            this.panelDesktopPane.Controls.Add(this.label1);
            this.panelDesktopPane.Location = new System.Drawing.Point(190, 0);
            this.panelDesktopPane.MinimumSize = new System.Drawing.Size(935, 560);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(935, 560);
            this.panelDesktopPane.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 59);
            this.panel3.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bell MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(394, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "ACCUEIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Chef de Bureau Administratif:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mr. Omar Rhrissi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(56, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(834, 78);
            this.label1.TabIndex = 27;
            this.label1.Text = " La Direction Provinciale de l’équipement du transport,\r\n de la logistique et de " +
    "l’eau :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 560);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des notes";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button Ajouter_Notes;
        private Button btnemplye;
        private Button btnaccueil;
        private Panel panel2;
        private Panel panelDesktopPane;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button Parametres;
        private Button Afficher_Notes;
        private PictureBox pictureBox1;
        private Button Deconnexion;
        private Panel panel3;
        private Label label9;
    }
}

