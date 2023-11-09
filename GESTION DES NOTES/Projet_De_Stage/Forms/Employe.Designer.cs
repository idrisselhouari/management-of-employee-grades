using System.Windows.Forms;

namespace Projet_De_Stage.Forms
{
    partial class Employe
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_Service = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Date_Recrutement = new System.Windows.Forms.DateTimePicker();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Dote = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Grade = new System.Windows.Forms.ComboBox();
            this.Actualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Service";
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(400, 99);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(130, 20);
            this.txt_Nom.TabIndex = 6;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Location = new System.Drawing.Point(643, 99);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(130, 20);
            this.txt_Prenom.TabIndex = 7;
            // 
            // txt_Service
            // 
            this.txt_Service.Location = new System.Drawing.Point(400, 151);
            this.txt_Service.Name = "txt_Service";
            this.txt_Service.Size = new System.Drawing.Size(130, 20);
            this.txt_Service.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date Recrutement";
            // 
            // Date_Recrutement
            // 
            this.Date_Recrutement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Recrutement.Location = new System.Drawing.Point(648, 151);
            this.Date_Recrutement.MaxDate = new System.DateTime(4999, 12, 31, 0, 0, 0, 0);
            this.Date_Recrutement.Name = "Date_Recrutement";
            this.Date_Recrutement.Size = new System.Drawing.Size(126, 20);
            this.Date_Recrutement.TabIndex = 11;
            this.Date_Recrutement.Value = new System.DateTime(2022, 6, 21, 0, 0, 0, 0);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Ajouter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Location = new System.Drawing.Point(339, 206);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(70, 26);
            this.Ajouter.TabIndex = 12;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Modifier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier.Location = new System.Drawing.Point(492, 206);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(70, 26);
            this.Modifier.TabIndex = 13;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Supprimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supprimer.Location = new System.Drawing.Point(636, 206);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(70, 26);
            this.Supprimer.TabIndex = 14;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(130, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(643, 235);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dote";
            // 
            // txt_Dote
            // 
            this.txt_Dote.Location = new System.Drawing.Point(185, 99);
            this.txt_Dote.Name = "txt_Dote";
            this.txt_Dote.Size = new System.Drawing.Size(130, 20);
            this.txt_Dote.TabIndex = 5;
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
            this.label9.Location = new System.Drawing.Point(382, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "EMPLOYES";
            // 
            // txt_Grade
            // 
            this.txt_Grade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Grade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_Grade.FormattingEnabled = true;
            this.txt_Grade.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "H"});
            this.txt_Grade.Location = new System.Drawing.Point(185, 154);
            this.txt_Grade.Name = "txt_Grade";
            this.txt_Grade.Size = new System.Drawing.Size(130, 21);
            this.txt_Grade.TabIndex = 26;
            // 
            // Actualiser
            // 
            this.Actualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Actualiser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Actualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualiser.Location = new System.Drawing.Point(199, 206);
            this.Actualiser.Margin = new System.Windows.Forms.Padding(0);
            this.Actualiser.Name = "Actualiser";
            this.Actualiser.Size = new System.Drawing.Size(70, 26);
            this.Actualiser.TabIndex = 27;
            this.Actualiser.Text = "Actualiser";
            this.Actualiser.UseVisualStyleBackColor = false;
            this.Actualiser.Click += new System.EventHandler(this.Actualiser_Click);
            // 
            // Employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 522);
            this.Controls.Add(this.Actualiser);
            this.Controls.Add(this.txt_Grade);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Date_Recrutement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Service);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.txt_Dote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Employe";
            this.Text = "Employe";
            this.Load += new System.EventHandler(this.Employe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Nom;
        private TextBox txt_Prenom;
        private TextBox txt_Service;
        private Label label6;
        private DateTimePicker Date_Recrutement;
        private Button Ajouter;
        private Button Modifier;
        private Button Supprimer;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txt_Dote;
        private Panel panel1;
        private Label label9;
        private ComboBox txt_Grade;
        private Button Actualiser;
    }
}