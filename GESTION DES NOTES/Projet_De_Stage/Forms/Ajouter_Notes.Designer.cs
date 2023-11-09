using System.Windows.Forms;

namespace Projet_De_Stage.Forms
{
    partial class Ajouter_Notes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_Dote = new System.Windows.Forms.TextBox();
            this.txt_Service = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Date_Recrutement = new System.Windows.Forms.DateTimePicker();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Date_Note = new System.Windows.Forms.DateTimePicker();
            this.Modifier = new System.Windows.Forms.Button();
            this.Afficher_Notes = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Actualiser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Rechercher_Dote = new System.Windows.Forms.TextBox();
            this.Rechercher_Prenom = new System.Windows.Forms.TextBox();
            this.Rechercher_Nom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelRecherche = new System.Windows.Forms.Panel();
            this.txt_Grade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dote";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Service";
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(363, 71);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(100, 20);
            this.txt_Nom.TabIndex = 6;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Location = new System.Drawing.Point(550, 71);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(100, 20);
            this.txt_Prenom.TabIndex = 7;
            // 
            // txt_Dote
            // 
            this.txt_Dote.Location = new System.Drawing.Point(136, 74);
            this.txt_Dote.Name = "txt_Dote";
            this.txt_Dote.Size = new System.Drawing.Size(100, 20);
            this.txt_Dote.TabIndex = 8;
            // 
            // txt_Service
            // 
            this.txt_Service.Location = new System.Drawing.Point(136, 119);
            this.txt_Service.Name = "txt_Service";
            this.txt_Service.Size = new System.Drawing.Size(100, 20);
            this.txt_Service.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date Recrutement";
            // 
            // Date_Recrutement
            // 
            this.Date_Recrutement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Recrutement.Location = new System.Drawing.Point(363, 118);
            this.Date_Recrutement.Name = "Date_Recrutement";
            this.Date_Recrutement.Size = new System.Drawing.Size(100, 20);
            this.Date_Recrutement.TabIndex = 11;
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Ajouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Location = new System.Drawing.Point(405, 161);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(98, 26);
            this.Ajouter.TabIndex = 12;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Supprimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supprimer.Location = new System.Drawing.Point(660, 161);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(98, 26);
            this.Supprimer.TabIndex = 14;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(643, 250);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Note";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(550, 116);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(100, 20);
            this.txt_Note.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Date Note";
            // 
            // Date_Note
            // 
            this.Date_Note.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Note.Location = new System.Drawing.Point(732, 116);
            this.Date_Note.MaxDate = new System.DateTime(4999, 12, 31, 0, 0, 0, 0);
            this.Date_Note.Name = "Date_Note";
            this.Date_Note.Size = new System.Drawing.Size(100, 20);
            this.Date_Note.TabIndex = 19;
            this.Date_Note.Value = new System.DateTime(2022, 6, 21, 0, 0, 0, 0);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Modifier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier.Location = new System.Drawing.Point(531, 161);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(98, 26);
            this.Modifier.TabIndex = 20;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Afficher_Notes
            // 
            this.Afficher_Notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Afficher_Notes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Afficher_Notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Afficher_Notes.Location = new System.Drawing.Point(280, 161);
            this.Afficher_Notes.Name = "Afficher_Notes";
            this.Afficher_Notes.Size = new System.Drawing.Size(98, 26);
            this.Afficher_Notes.TabIndex = 21;
            this.Afficher_Notes.Text = "Afficher les notes";
            this.Afficher_Notes.UseVisualStyleBackColor = false;
            this.Afficher_Notes.Click += new System.EventHandler(this.Afficher_Notes_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 243);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(843, 270);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Actualiser
            // 
            this.Actualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Actualiser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Actualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualiser.Location = new System.Drawing.Point(152, 161);
            this.Actualiser.Margin = new System.Windows.Forms.Padding(0);
            this.Actualiser.Name = "Actualiser";
            this.Actualiser.Size = new System.Drawing.Size(98, 26);
            this.Actualiser.TabIndex = 23;
            this.Actualiser.Text = "Actualiser";
            this.Actualiser.UseVisualStyleBackColor = false;
            this.Actualiser.Click += new System.EventHandler(this.Actualiser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 59);
            this.panel1.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bell MT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(306, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(271, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "AJOUTER DES NOTES";
            // 
            // Rechercher
            // 
            this.Rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Rechercher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rechercher.Location = new System.Drawing.Point(658, 7);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(75, 23);
            this.Rechercher.TabIndex = 33;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = false;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Rechercher_Dote
            // 
            this.Rechercher_Dote.Location = new System.Drawing.Point(205, 9);
            this.Rechercher_Dote.Name = "Rechercher_Dote";
            this.Rechercher_Dote.Size = new System.Drawing.Size(100, 20);
            this.Rechercher_Dote.TabIndex = 32;
            // 
            // Rechercher_Prenom
            // 
            this.Rechercher_Prenom.Location = new System.Drawing.Point(537, 9);
            this.Rechercher_Prenom.Name = "Rechercher_Prenom";
            this.Rechercher_Prenom.Size = new System.Drawing.Size(100, 20);
            this.Rechercher_Prenom.TabIndex = 31;
            // 
            // Rechercher_Nom
            // 
            this.Rechercher_Nom.Location = new System.Drawing.Point(366, 8);
            this.Rechercher_Nom.Name = "Rechercher_Nom";
            this.Rechercher_Nom.Size = new System.Drawing.Size(100, 20);
            this.Rechercher_Nom.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Dote";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(488, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Prenom";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(331, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Nom";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Rechercher par :";
            // 
            // panelRecherche
            // 
            this.panelRecherche.Controls.Add(this.Rechercher_Dote);
            this.panelRecherche.Controls.Add(this.Rechercher);
            this.panelRecherche.Controls.Add(this.label13);
            this.panelRecherche.Controls.Add(this.label12);
            this.panelRecherche.Controls.Add(this.Rechercher_Prenom);
            this.panelRecherche.Controls.Add(this.label11);
            this.panelRecherche.Controls.Add(this.Rechercher_Nom);
            this.panelRecherche.Controls.Add(this.label10);
            this.panelRecherche.Location = new System.Drawing.Point(71, 193);
            this.panelRecherche.Name = "panelRecherche";
            this.panelRecherche.Size = new System.Drawing.Size(773, 38);
            this.panelRecherche.TabIndex = 34;
            // 
            // txt_Grade
            // 
            this.txt_Grade.FormattingEnabled = true;
            this.txt_Grade.Location = new System.Drawing.Point(729, 70);
            this.txt_Grade.Name = "txt_Grade";
            this.txt_Grade.Size = new System.Drawing.Size(103, 21);
            this.txt_Grade.TabIndex = 35;
            // 
            // Ajouter_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 522);
            this.Controls.Add(this.txt_Grade);
            this.Controls.Add(this.panelRecherche);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Actualiser);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Afficher_Notes);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Date_Note);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Date_Recrutement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Service);
            this.Controls.Add(this.txt_Dote);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ajouter_Notes";
            this.Text = "Ajouter_Notes";
            this.Load += new System.EventHandler(this.Ajouter_Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRecherche.ResumeLayout(false);
            this.panelRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Nom;
        private TextBox txt_Prenom;
        private TextBox txt_Dote;
        private TextBox txt_Service;
        private Label label6;
        private DateTimePicker Date_Recrutement;
        private Button Ajouter;
        private Button Supprimer;
        private DataGridView dataGridView1;
        private Label label7;
        private TextBox txt_Note;
        private Label label8;
        private DateTimePicker Date_Note;
        private Button Modifier;
        private Button Afficher_Notes;
        private DataGridView dataGridView2;
        private Button Actualiser;
        private Panel panel1;
        private Label label9;
        private Button Rechercher;
        private TextBox Rechercher_Dote;
        private TextBox Rechercher_Prenom;
        private TextBox Rechercher_Nom;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Panel panelRecherche;
        private ComboBox txt_Grade;
    }
}