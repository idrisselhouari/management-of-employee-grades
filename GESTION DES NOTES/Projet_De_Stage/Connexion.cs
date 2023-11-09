using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Projet_De_Stage
{
    public partial class ConnexionAdmin : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["GestionDesNotesDataBase"].ConnectionString);
        SqlDataAdapter adapt;
        DataTable dt;

        public ConnexionAdmin()
        {
            InitializeComponent();
        }

        private void ConnexionAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Connexion_Click(object sender, EventArgs e)
        {
            if (txt_utilisateur.Text != "" & txt_pwd.Text != "")
            {
                con.Open();
                adapt = new SqlDataAdapter("select * from Admin where utilisateur='" + txt_utilisateur.Text + "' and mot_de_passe='" + txt_pwd.Text + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Accueil objForm1 = new Accueil();
                    this.Hide();
                    con.Close();
                    objForm1.Show();
                }
                else
                {
                    MessageBox.Show("L'utilisateur ou le mot de passe est incorrect");
                }
            }
            else
            {
                MessageBox.Show("Entez l'utilisateur et le mot de passe!!");
            }
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
