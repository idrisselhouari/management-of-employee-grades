namespace Projet_De_Stage.Forms.parametreForms
{
    partial class ModifierMotDePasse
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
            this.Annuler = new System.Windows.Forms.Button();
            this.txt_conNouvelMotP = new System.Windows.Forms.TextBox();
            this.txt_nouvelMotP = new System.Windows.Forms.TextBox();
            this.txt_encienMotP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Modifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Annuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.Location = new System.Drawing.Point(295, 189);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(76, 30);
            this.Annuler.TabIndex = 15;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            // 
            // txt_conNouvelMotP
            // 
            this.txt_conNouvelMotP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conNouvelMotP.Location = new System.Drawing.Point(334, 138);
            this.txt_conNouvelMotP.Name = "txt_conNouvelMotP";
            this.txt_conNouvelMotP.PasswordChar = '*';
            this.txt_conNouvelMotP.Size = new System.Drawing.Size(164, 23);
            this.txt_conNouvelMotP.TabIndex = 14;
            // 
            // txt_nouvelMotP
            // 
            this.txt_nouvelMotP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nouvelMotP.Location = new System.Drawing.Point(334, 83);
            this.txt_nouvelMotP.Name = "txt_nouvelMotP";
            this.txt_nouvelMotP.PasswordChar = '*';
            this.txt_nouvelMotP.Size = new System.Drawing.Size(164, 23);
            this.txt_nouvelMotP.TabIndex = 13;
            // 
            // txt_encienMotP
            // 
            this.txt_encienMotP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_encienMotP.Location = new System.Drawing.Point(334, 29);
            this.txt_encienMotP.Name = "txt_encienMotP";
            this.txt_encienMotP.PasswordChar = '*';
            this.txt_encienMotP.Size = new System.Drawing.Size(164, 23);
            this.txt_encienMotP.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Confirmer nouvel mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Entrer nouvel mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Entrer encien mot de passe";
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.Modifier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(155)))));
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(175, 189);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(76, 30);
            this.Modifier.TabIndex = 8;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // ModifierMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 237);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.txt_conNouvelMotP);
            this.Controls.Add(this.txt_nouvelMotP);
            this.Controls.Add(this.txt_encienMotP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Modifier);
            this.Name = "ModifierMotDePasse";
            this.Text = "ModifierMotDePasse";
            this.Load += new System.EventHandler(this.ModifierMotDePasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.TextBox txt_conNouvelMotP;
        private System.Windows.Forms.TextBox txt_nouvelMotP;
        private System.Windows.Forms.TextBox txt_encienMotP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Modifier;
    }
}