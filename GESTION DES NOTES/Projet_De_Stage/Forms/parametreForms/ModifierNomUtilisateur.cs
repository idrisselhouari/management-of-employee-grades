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
using System.Configuration;

namespace Projet_De_Stage.Forms.parametreForms
{
    public partial class ModifierNomUtilisateur : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["GestionDesNotesDataBase"].ConnectionString);
        SqlDataAdapter adapt;
        SqlCommand command;
        DataTable dt;

        public ModifierNomUtilisateur()
        {
            InitializeComponent();
        }

        private void ModifierNomUtilisateur_Load(object sender, EventArgs e)
        {

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (txt_encienNomUt.Text != "" & txt_nouvelNomUt.Text != "" & txt_conNouvelNomUt.Text != "")
            {
                con.Open();
                adapt = new SqlDataAdapter("select * from Admin WHERE utilisateur='" + txt_encienNomUt.Text + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    if (txt_nouvelNomUt.Text == txt_conNouvelNomUt.Text)
                    {
                        command = new SqlCommand("update Admin set utilisateur=@nouvelUtilisateur where utilisateur=@ancienUtilisateur", con);
                        command.Parameters.AddWithValue("@nouvelUtilisateur", txt_nouvelNomUt.Text);
                        command.Parameters.AddWithValue("@ancienUtilisateur", txt_encienNomUt.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("modification faite avec succee");
                        txt_encienNomUt.Text = "";
                        txt_nouvelNomUt.Text = "";
                        txt_conNouvelNomUt.Text = "";
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                        txt_conNouvelNomUt.Text = "";
                        MessageBox.Show("Erreur de vocabulaire ,veulliez reconfirmer le nouveau utilisateur");
                    }
                }
                else
                {
                    con.Close();
                    MessageBox.Show(" Aucun utilisateur n'est trouvé");
                }
            }
            else
            {
                MessageBox.Show("S'il vous plait, veuillez remplir toutes les champs");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
