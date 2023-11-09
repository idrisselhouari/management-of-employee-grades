using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_De_Stage.Forms
{
    public partial class Parametre : Form
    {
        private Form activeForm;

        public Parametre()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelParametre.Controls.Add(childForm);
            this.panelParametre.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void ModifierUtilisateur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new parametreForms.ModifierNomUtilisateur(), sender);
        }

        private void ModifierMotPasse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new parametreForms.ModifierMotDePasse(), sender);
        }

        private void Parametre_Load(object sender, EventArgs e)
        {

        }
    }
}
