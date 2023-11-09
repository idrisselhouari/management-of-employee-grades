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
    public partial class ModifierMotDePasse : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["GestionDesNotesDataBase"].ConnectionString);
        SqlDataAdapter adapt;
        SqlCommand command;
        DataTable dt;

        public ModifierMotDePasse()
        {
            InitializeComponent();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
                if (txt_encienMotP.Text != "" & txt_nouvelMotP.Text != "" & txt_conNouvelMotP.Text != "")
                {
                    con.Open();
                    adapt = new SqlDataAdapter("select * from Admin WHERE mot_de_passe='" + txt_encienMotP.Text + "'", con);
                    dt = new DataTable();
                    adapt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        if (txt_nouvelMotP.Text == txt_conNouvelMotP.Text)
                        {
                            
                            command = new SqlCommand("update Admin set mot_de_passe=@nouvelMotPass where mot_de_passe=@ancienMotPass", con);
                            command.Parameters.AddWithValue("@nouvelMotPass", txt_nouvelMotP.Text);
                            command.Parameters.AddWithValue("@ancienMotPass", txt_encienMotP.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("modification faite avec succee");
                            txt_encienMotP.Text = "";
                            txt_nouvelMotP.Text = "";
                            txt_conNouvelMotP.Text = "";
                            con.Close();
                            
                        }
                        else
                        {
                        con.Close();
                        txt_conNouvelMotP.Text = "";
                            MessageBox.Show("Erreur de vocabulaire ,veulliez reconfirmer le nouveau utilisateur");
                        }
                    }
                    else
                    {
                    con.Close();
                    MessageBox.Show("Aucun utilisateur n'est trouvé");
                    }
                }
                else
                {
                    MessageBox.Show("S'il vous plait, veuillez remplir toutes les champs");
                }
        }

        private void ModifierMotDePasse_Load(object sender, EventArgs e)
        {

        }
    }
}
