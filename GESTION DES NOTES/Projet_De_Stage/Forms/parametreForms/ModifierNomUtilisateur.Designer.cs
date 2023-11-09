namespace Projet_De_Stage.Forms.parametreForms
{
    partial class ModifierNomUtilisateur
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
            this.Modifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_encienNomUt = new System.Windows.Forms.TextBox();
            this.txt_nouvelNomUt = new System.Windows.Forms.TextBox();
            this.txt_conNouvelNomUt = new System.Windows.Forms.TextBox();
            this.Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Modifier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(172, 189);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(76, 30);
            this.Modifier.TabIndex = 0;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrer encien nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrer nouvel nom d\'utilisateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmer nouvel nom d\'utilisateur";
            // 
            // txt_encienNomUt
            // 
            this.txt_encienNomUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_encienNomUt.Location = new System.Drawing.Point(331, 29);
            this.txt_encienNomUt.Name = "txt_encienNomUt";
            this.txt_encienNomUt.Size = new System.Drawing.Size(164, 23);
            this.txt_encienNomUt.TabIndex = 4;
            this.txt_encienNomUt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_nouvelNomUt
            // 
            this.txt_nouvelNomUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nouvelNomUt.Location = new System.Drawing.Point(331, 83);
            this.txt_nouvelNomUt.Name = "txt_nouvelNomUt";
            this.txt_nouvelNomUt.Size = new System.Drawing.Size(164, 23);
            this.txt_nouvelNomUt.TabIndex = 5;
            // 
            // txt_conNouvelNomUt
            // 
            this.txt_conNouvelNomUt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conNouvelNomUt.Location = new System.Drawing.Point(331, 138);
            this.txt_conNouvelNomUt.Name = "txt_conNouvelNomUt";
            this.txt_conNouvelNomUt.Size = new System.Drawing.Size(164, 23);
            this.txt_conNouvelNomUt.TabIndex = 6;
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Annuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.Location = new System.Drawing.Point(292, 189);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(76, 30);
            this.Annuler.TabIndex = 7;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            // 
            // ModifierNomUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 237);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.txt_conNouvelNomUt);
            this.Controls.Add(this.txt_nouvelNomUt);
            this.Controls.Add(this.txt_encienNomUt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Modifier);
            this.Name = "ModifierNomUtilisateur";
            this.Text = "ModifierNomUtilisateur";
            this.Load += new System.EventHandler(this.ModifierNomUtilisateur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_encienNomUt;
        private System.Windows.Forms.TextBox txt_nouvelNomUt;
        private System.Windows.Forms.TextBox txt_conNouvelNomUt;
        private System.Windows.Forms.Button Annuler;
    }
}