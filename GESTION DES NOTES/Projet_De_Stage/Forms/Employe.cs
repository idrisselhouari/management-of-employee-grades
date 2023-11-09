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

namespace Projet_De_Stage.Forms
{

    public partial class Employe : Form
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["GestionDesNotesDataBase"].ConnectionString);
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapt;
        int dote; int grade;

        public Employe()
        {
            InitializeComponent();
            DisplayData();
            Date_Recrutement.MaxDate = DateTime.Now.Date;
        }
        public void DisplayData()
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from Employes",con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();  
        }
        
        public void ClearData()
        {
            txt_Dote.Text = "";
            txt_Nom.Text = "";
            txt_Prenom.Text = "";
            txt_Grade.Text = "";
            txt_Service.Text = "";
            Date_Recrutement.Value = DateTime.Now.Date;
        }

        private void Actualiser_Click(object sender, EventArgs e)
        {
            ClearData(); DisplayData();
        }
        
        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (txt_Grade.Text != "" & txt_Nom.Text != "" & txt_Service.Text != "" & txt_Dote.Text != "" & txt_Prenom.Text != "" & Date_Recrutement.Text != "")
            {
                bool testDoteInt = int.TryParse(txt_Dote.Text, out dote);
                bool testGradeInt = int.TryParse(txt_Grade.Text, out grade);
                if (testDoteInt)
                {
                    if (testGradeInt)
                    {
                        if (grade > 4 && grade < 12)
                        {
                            con.Open();
                            adapt = new SqlDataAdapter("select * from Employes where Dote='" + dote + "'", con);
                            dt = new DataTable();
                            adapt.Fill(dt);
                            if (dt.Rows.Count >= 1)
                            {
                                con.Close();
                                MessageBox.Show("Ce dote déja existe");
                                txt_Dote.Text = ""; txt_Dote.Focus();
                            }
                            else
                            {
                                cmd = new SqlCommand("insert into Employes values(@dote,@nom,@prenom,@grade,@service,@dateRecrutement)", con);
                                cmd.Parameters.AddWithValue("@dote", dote);
                                cmd.Parameters.AddWithValue("@nom", txt_Nom.Text);
                                cmd.Parameters.AddWithValue("@prenom", txt_Prenom.Text);
                                cmd.Parameters.AddWithValue("@grade", grade);
                                cmd.Parameters.AddWithValue("@service", txt_Service.Text);
                                cmd.Parameters.AddWithValue("@dateRecrutement", Date_Recrutement.Value.Date);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Votre ligne ajouté avec succés");
                                con.Close();
                                ClearData();
                                DisplayData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Veuillez entrez un grade entre 5 et 11 ou H");
                            txt_Grade.Text = ""; txt_Grade.Focus();
                        }
                    }
                    else
                    {
                        if (txt_Grade.Text == "H")
                        {
                            con.Open();
                            adapt = new SqlDataAdapter("select * from Employes where Dote='" + dote + "'", con);
                            dt = new DataTable();
                            adapt.Fill(dt);
                            if (dt.Rows.Count >= 1)
                            {
                                con.Close();
                                MessageBox.Show("Ce dote déja existe");
                                txt_Dote.Text = ""; txt_Dote.Focus();
                            }
                            else
                            {
                                cmd = new SqlCommand("insert into Employes values(@dote,@nom,@prenom,@grade,@service,@dateRecrutement)", con);
                                cmd.Parameters.AddWithValue("@dote", dote);
                                cmd.Parameters.AddWithValue("@nom", txt_Nom.Text);
                                cmd.Parameters.AddWithValue("@prenom", txt_Prenom.Text);
                                cmd.Parameters.AddWithValue("@grade", txt_Grade.Text);
                                cmd.Parameters.AddWithValue("@service", txt_Service.Text);
                                cmd.Parameters.AddWithValue("@dateRecrutement", Date_Recrutement.Value.Date);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Votre ligne ajouté avec succés");
                                con.Close();
                                ClearData();
                                DisplayData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Veuillez entrez un grade entre 5 et 11 ou H");
                            txt_Grade.Text = ""; txt_Grade.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez entrez un nombre entier pour le dote");
                    txt_Dote.Text = ""; txt_Dote.Focus();
                }
               
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner Enregistrer pour mettre à jour");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (txt_Grade.Text != "" & txt_Nom.Text != "" & txt_Service.Text != "" & txt_Dote.Text != "" & txt_Prenom.Text != "" & Date_Recrutement.Text != "")
            {
                if ((txt_Grade.Text == "H") || (int.Parse(txt_Grade.Text) > 4 && int.Parse(txt_Grade.Text) < 12))
                {
                    con.Open();
                    cmd = new SqlCommand("update Employes set Nom=@nom , Prenom=@prenom , Grade=@grade , Service=@service, [Date Recrutement]=@dateRecrutement where Dote=@dotePrecident", con);

                    cmd.Parameters.AddWithValue("@nom", txt_Nom.Text);
                    cmd.Parameters.AddWithValue("@prenom", txt_Prenom.Text);
                    cmd.Parameters.AddWithValue("@grade", txt_Grade.Text);
                    cmd.Parameters.AddWithValue("@service", txt_Service.Text);
                    cmd.Parameters.AddWithValue("@dateRecrutement", Date_Recrutement.Value.Date);
                    cmd.Parameters.AddWithValue("@dotePrecident", int.Parse(txt_Dote.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Enregistrement mis à jour avec succès");
                    ClearData();
                    DisplayData();
                }
                else
                {
                    MessageBox.Show("Veuillez entrez un grade entre 5 et 11 ou H");
                    txt_Grade.Text = ""; txt_Grade.Focus();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner Enregistrer pour mettre à jour");
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez-vous vraiment supprimer ce ligne ?", "Suppression d'un note", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open(); 
                dote = (int)dataGridView1.CurrentRow.Cells[0].Value;
                cmd = new SqlCommand("delete from Employes where Dote=@dote", con);
                cmd.Parameters.AddWithValue("@dote", dote);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Suppression faite avec succée");
                DisplayData();
                ClearData(); 
            }
        }

               
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Dote.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Nom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Prenom.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Grade.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Service.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Date_Recrutement.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_Dote.Enabled = false;
        }

        private void Employe_Load(object sender, EventArgs e)
        {

        }
    }
}
