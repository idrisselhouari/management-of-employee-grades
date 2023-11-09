namespace Projet_De_Stage.Forms
{
    partial class Afficher_les_notes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Trier_Dote = new System.Windows.Forms.Button();
            this.Trier_Service = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Rechercher_Dote = new System.Windows.Forms.TextBox();
            this.Rechercher_Prenom = new System.Windows.Forms.TextBox();
            this.Rechercher_Nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Actualiser = new System.Windows.Forms.Button();
            this.Moyen10 = new System.Windows.Forms.Button();
            this.Moyen6 = new System.Windows.Forms.Button();
            this.Moyen3 = new System.Windows.Forms.Button();
            this.Nouvel_Employe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.AucunNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 193);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(843, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trier par :";
            // 
            // Trier_Dote
            // 
            this.Trier_Dote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Trier_Dote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Trier_Dote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trier_Dote.Location = new System.Drawing.Point(383, 118);
            this.Trier_Dote.Name = "Trier_Dote";
            this.Trier_Dote.Size = new System.Drawing.Size(75, 23);
            this.Trier_Dote.TabIndex = 3;
            this.Trier_Dote.Text = "Dote";
            this.Trier_Dote.UseVisualStyleBackColor = false;
            this.Trier_Dote.Click += new System.EventHandler(this.Trier_Dote_Click);
            // 
            // Trier_Service
            // 
            this.Trier_Service.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Trier_Service.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Trier_Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trier_Service.Location = new System.Drawing.Point(504, 118);
            this.Trier_Service.Name = "Trier_Service";
            this.Trier_Service.Size = new System.Drawing.Size(75, 23);
            this.Trier_Service.TabIndex = 4;
            this.Trier_Service.Text = "Service";
            this.Trier_Service.UseVisualStyleBackColor = false;
            this.Trier_Service.Click += new System.EventHandler(this.Trier_Service_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rechercher par :";
            // 
            // Rechercher_Dote
            // 
            this.Rechercher_Dote.Location = new System.Drawing.Point(285, 75);
            this.Rechercher_Dote.Name = "Rechercher_Dote";
            this.Rechercher_Dote.Size = new System.Drawing.Size(100, 20);
            this.Rechercher_Dote.TabIndex = 16;
            // 
            // Rechercher_Prenom
            // 
            this.Rechercher_Prenom.Location = new System.Drawing.Point(617, 75);
            this.Rechercher_Prenom.Name = "Rechercher_Prenom";
            this.Rechercher_Prenom.Size = new System.Drawing.Size(100, 20);
            this.Rechercher_Prenom.TabIndex = 15;
            // 
            // Rechercher_Nom
            // 
            this.Rechercher_Nom.Location = new System.Drawing.Point(446, 74);
            this.Rechercher_Nom.Name = "Rechercher_Nom";
            this.Rechercher_Nom.Size = new System.Drawing.Size(100, 20);
            this.Rechercher_Nom.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dote";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nom";
            // 
            // Rechercher
            // 
            this.Rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Rechercher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rechercher.Location = new System.Drawing.Point(738, 73);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(75, 23);
            this.Rechercher.TabIndex = 17;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = false;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Actualiser
            // 
            this.Actualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.Actualiser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Actualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualiser.Location = new System.Drawing.Point(33, 170);
            this.Actualiser.Margin = new System.Windows.Forms.Padding(0);
            this.Actualiser.Name = "Actualiser";
            this.Actualiser.Size = new System.Drawing.Size(75, 23);
            this.Actualiser.TabIndex = 18;
            this.Actualiser.Text = "Actualiser";
            this.Actualiser.UseVisualStyleBackColor = false;
            this.Actualiser.Click += new System.EventHandler(this.Actualiser_Click);
            // 
            // Moyen10
            // 
            this.Moyen10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.Moyen10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Moyen10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Moyen10.Location = new System.Drawing.Point(108, 170);
            this.Moyen10.Margin = new System.Windows.Forms.Padding(0);
            this.Moyen10.Name = "Moyen10";
            this.Moyen10.Size = new System.Drawing.Size(100, 23);
            this.Moyen10.TabIndex = 19;
            this.Moyen10.Text = "Moyen 10 ans";
            this.Moyen10.UseVisualStyleBackColor = false;
            this.Moyen10.Click += new System.EventHandler(this.Moyen10_Click);
            // 
            // Moyen6
            // 
            this.Moyen6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.Moyen6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Moyen6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Moyen6.Location = new System.Drawing.Point(208, 170);
            this.Moyen6.Margin = new System.Windows.Forms.Padding(0);
            this.Moyen6.Name = "Moyen6";
            this.Moyen6.Size = new System.Drawing.Size(100, 23);
            this.Moyen6.TabIndex = 20;
            this.Moyen6.Text = "Moyen 6 ans";
            this.Moyen6.UseVisualStyleBackColor = false;
            this.Moyen6.Click += new System.EventHandler(this.Moyen6_Click);
            // 
            // Moyen3
            // 
            this.Moyen3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.Moyen3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Moyen3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Moyen3.Location = new System.Drawing.Point(308, 170);
            this.Moyen3.Margin = new System.Windows.Forms.Padding(0);
            this.Moyen3.Name = "Moyen3";
            this.Moyen3.Size = new System.Drawing.Size(100, 23);
            this.Moyen3.TabIndex = 21;
            this.Moyen3.Text = "Moyen 3 ans";
            this.Moyen3.UseVisualStyleBackColor = false;
            this.Moyen3.Click += new System.EventHandler(this.Moyen3_Click);
            // 
            // Nouvel_Employe
            // 
            this.Nouvel_Employe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.Nouvel_Employe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Nouvel_Employe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nouvel_Employe.Location = new System.Drawing.Point(408, 170);
            this.Nouvel_Employe.Margin = new System.Windows.Forms.Padding(0);
            this.Nouvel_Employe.Name = "Nouvel_Employe";
            this.Nouvel_Employe.Size = new System.Drawing.Size(100, 23);
            this.Nouvel_Employe.TabIndex = 22;
            this.Nouvel_Employe.Text = "2 ans";
            this.Nouvel_Employe.UseVisualStyleBackColor = false;
            this.Nouvel_Employe.Click += new System.EventHandler(this.Nouvel_Employe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 59);
            this.panel1.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bell MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(305, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "AFFICHAGE DES NOTES";
            // 
            // AucunNote
            // 
            this.AucunNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.AucunNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.AucunNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AucunNote.Location = new System.Drawing.Point(508, 170);
            this.AucunNote.Margin = new System.Windows.Forms.Padding(0);
            this.AucunNote.Name = "AucunNote";
            this.AucunNote.Size = new System.Drawing.Size(100, 23);
            this.AucunNote.TabIndex = 26;
            this.AucunNote.Text = "Aucun";
            this.AucunNote.UseVisualStyleBackColor = false;
            this.AucunNote.Click += new System.EventHandler(this.AucunNote_Click);
            // 
            // Afficher_les_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(911, 522);
            this.Controls.Add(this.AucunNote);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Nouvel_Employe);
            this.Controls.Add(this.Moyen3);
            this.Controls.Add(this.Moyen6);
            this.Controls.Add(this.Moyen10);
            this.Controls.Add(this.Actualiser);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Rechercher_Dote);
            this.Controls.Add(this.Rechercher_Prenom);
            this.Controls.Add(this.Rechercher_Nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Trier_Service);
            this.Controls.Add(this.Trier_Dote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Afficher_les_notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afficher_les_notes";
            this.Load += new System.EventHandler(this.Afficher_les_notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Trier_Dote;
        private System.Windows.Forms.Button Trier_Service;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rechercher_Dote;
        private System.Windows.Forms.TextBox Rechercher_Prenom;
        private System.Windows.Forms.TextBox Rechercher_Nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Button Actualiser;
        private System.Windows.Forms.Button Moyen10;
        private System.Windows.Forms.Button Moyen6;
        private System.Windows.Forms.Button Moyen3;
        private System.Windows.Forms.Button Nouvel_Employe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AucunNote;
    }
}