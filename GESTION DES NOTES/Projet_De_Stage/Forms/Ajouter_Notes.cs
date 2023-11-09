using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Projet_De_Stage.Forms
{
    public partial class Ajouter_Notes : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["GestionDesNotesDataBase"].ConnectionString);
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapt;
        DateTime dateNotePrecident;

        public Ajouter_Notes()
        {
            InitializeComponent();
            Date_Note.MaxDate = DateTime.Now.Date;
            Disable_Box();
            DisplayData();
            Modifier.Enabled= false;
            Supprimer.Enabled= false;
            panelRecherche.Visible = false;
        }
        public void Disable_Box()
        {
            txt_Dote.Enabled = false;
            txt_Grade.Enabled = false;
            txt_Nom.Enabled = false;
            txt_Prenom.Enabled = false;
            txt_Service.Enabled = false;
            Date_Recrutement.Enabled = false;

            txt_Note.Enabled = false;
            Date_Note.Enabled=false;
        }
        public void DisplayData()
        {
            con.Open();
            adapt = new SqlDataAdapter("select * from Employes", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        public void ClearData()
        {
            txt_Dote.Text = "";
            txt_Grade.Text = "";
            txt_Nom.Text = "";
            txt_Prenom.Text = "";
            txt_Service.Text = "";
            txt_Note.Text = "";
            Date_Note.Value = DateTime.Now.Date;
            Disable_Box();
        }
        private void Actualiser_Click(object sender, EventArgs e)
        {   
            panelRecherche.Visible = false;
            dataGridView2.Visible = false; 
            dataGridView1.Visible = true;
            Modifier.Enabled = false;
            Supprimer.Enabled = false;
            Ajouter.Enabled = true;
            
            ClearData();
            DisplayData();
        }
        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (txt_Note.Text != "" & Date_Note.Text != "")
            {
                decimal note;
                bool testNoteDecimal = decimal.TryParse(txt_Note.Text, out note);
                if (testNoteDecimal)
                {
                    if (note <= 20 & note >= 1)
                    {
                        con.Open();
                        adapt = new SqlDataAdapter("select * from Notes where [Dote id]=" + txt_Dote.Text + " and YEAR([Date Note])=" + Date_Note.Value.Date.Year, con);
                        dt = new DataTable();
                        adapt.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            con.Close();
                            MessageBox.Show("La note de ce employé pour l'année " + Date_Note.Value.Date.Year + " est déja existe");
                        }
                        else
                        {
                            cmd = new SqlCommand("insert into Notes values(@dote,@note,@dateNote)", con);
                            cmd.Parameters.AddWithValue("@dote", txt_Dote.Text);
                            cmd.Parameters.AddWithValue("@note", decimal.Parse(txt_Note.Text));
                            cmd.Parameters.AddWithValue("@dateNote", Date_Note.Value.Date);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Votre ligne ajouté avec succés");
                            ClearData();
                            DisplayData();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez entrer un nombre comprix entre 1 et 20");

                    }
                }
                else
                {
                    MessageBox.Show("Veuillez entrez un nombre decimal pour la note");
                    txt_Note.Text = "";txt_Note.Focus();
                }
            }
            else
            {                    
                MessageBox.Show("Veuillez Entrez la note");
            }
        }
        private void Modifier_Click(object sender, EventArgs e)
        {
            decimal note;
            bool testNoteDecimal = decimal.TryParse(txt_Note.Text, out note);
            if (testNoteDecimal)
            {
                if (note <= 20 & note >= 1)
                {
                    cmd = new SqlCommand("update Notes set Note=@note,[Date Note]=@dateNote where [Dote id]=@dote and [Date Note]=@dateNotePrecident", con);
                    con.Open();

                    cmd.Parameters.AddWithValue("@note", note) ;
                    cmd.Parameters.AddWithValue("@dateNote", Date_Note.Value.Date) ;
                    cmd.Parameters.AddWithValue("@dote", txt_Dote.Text);
                    cmd.Parameters.AddWithValue("@dateNotePrecident", dateNotePrecident.Date);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cette note mis à jour avec succès");
                    AfficherNotes();
                }
                else
                {
                    MessageBox.Show("Veuillez entrer un nombre entre 1 et 20");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrez un nombre decimal pour la note");
                txt_Note.Text = ""; txt_Note.Focus();
            }
        }                   
        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("voulez-vous vraiment supprimer ce ligne ?", "Suppression d'un note", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                int dote = (int)dataGridView2.CurrentRow.Cells[0].Value;
                DateTime date = (DateTime)dataGridView2.CurrentRow.Cells[7].Value;
                cmd = new SqlCommand("delete from Notes where [Dote id]=@dote and [Date Note]=@dateNote", con);
                cmd.Parameters.AddWithValue("@dote", dote);
                cmd.Parameters.AddWithValue("@dateNote",date );
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Suppression faite avec succée");
                AfficherNotes();
            }
        }
        private void AfficherNotes()
        {
            ClearData();
            con.Open();
            panelRecherche.Visible = true;
            adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement],Note,[Date Note] from Employes e, Notes n where e.Dote=n.[Dote id] order by [Date Note] Desc", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }
        private void Afficher_Notes_Click(object sender, EventArgs e)
        {
            AfficherNotes();
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            Ajouter.Enabled = false;
            Modifier.Enabled = true;
            Supprimer.Enabled = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Dote.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Nom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Prenom.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Grade.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); 
            txt_Service.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Date_Recrutement.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_Note.Enabled = true;
            Date_Note.Enabled = true;
            txt_Note.Focus();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Dote.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Nom.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Prenom.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Grade.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Service.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            Date_Recrutement.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_Note.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            Date_Note.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt_Note.Enabled = true;
            Date_Note.Enabled = true;
            dateNotePrecident = Date_Note.Value;
            txt_Note.Focus();

        }
        private void Rechercher_Click(object sender, EventArgs e)
        {
            if ((Rechercher_Dote.Text != "" & Rechercher_Nom.Text != "") || (Rechercher_Nom.Text != "" & Rechercher_Prenom.Text != "") || (Rechercher_Prenom.Text != "" & Rechercher_Dote.Text != ""))
            {
                MessageBox.Show("zefml,emlf");
            }
            else if (Rechercher_Dote.Text != "")
            {
                con.Open();
                adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement],Note,[Date Note] from Employes e, Notes n where e.Dote=n.[Dote id]  and Dote='" + Rechercher_Dote.Text + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
                Rechercher_Dote.Text = "";
            }
            else if (Rechercher_Nom.Text != "")
            {
                con.Open();
                adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement],Note,[Date Note] from Employes e, Notes n where e.Dote=n.[Dote id]  and Nom='" + Rechercher_Nom.Text + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
                Rechercher_Nom.Text = "";
            }
            else if (Rechercher_Prenom.Text != "")
            {
                con.Open();
                adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement],Note,[Date Note] from Employes e, Notes n where e.Dote=n.[Dote id]  and Prenom='" + Rechercher_Prenom.Text + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
                Rechercher_Prenom.Text = "";
            }
            else
            {
                MessageBox.Show("Entrer le mot souhaitant rechercher");
            }
        }
        private void Ajouter_Notes_Load(object sender, EventArgs e)
        {

        }
    }
}
