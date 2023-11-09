using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projet_De_Stage
{
    public partial class Accueil : Form
    {
        private Form activeForm;

        public Accueil()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null) { 
                activeForm.Close();
            }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDesktopPane.Controls.Add(childForm);
                this.panelDesktopPane.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }
        private void btnaccueil_Click(object sender, EventArgs e)
        {
            this.panelDesktopPane.Controls.Remove(activeForm);
        }
        private void btnemplye_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Employe(), sender);
        }

        private void Ajouter_Notes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Ajouter_Notes(), sender);
        }

        private void Afficher_Notes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Afficher_les_notes(), sender);
        }

        private void Parametres_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Parametre(), sender);
        }

        private void Deconnexion_Click(object sender, EventArgs e)
        {
            ConnexionAdmin objConnexionAdmin = new ConnexionAdmin();
            this.Close();
            objConnexionAdmin.Show();
        }

        
    }
}
