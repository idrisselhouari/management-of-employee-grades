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
    public partial class Afficher_les_notes : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["GestionDesNotesDataBase"].ConnectionString);
        SqlDataAdapter adapt;
        DataTable dt;
        public Afficher_les_notes()
        {
            InitializeComponent();
            afficher_notes();
        }

        private void afficher_notes()
        {
            con.Open();
            adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement],Note,[Date Note] from Employes e, Notes n where e.Dote=n.[Dote id] order by [Date Note] Desc", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Trier_Dote_Click(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement],Note,[Date Note] from Employes e, Notes n where e.Dote=n.[Dote id] order by Dote ", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Trier_Service_Click(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement],Note,[Date Note] from Employes e, Notes n where e.Dote=n.[Dote id] order by Service ", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Actualiser_Click(object sender, EventArgs e)
        {
            afficher_notes();
        }
        //Pour le recherche d'un employe 
        private void Rechercher_Click(object sender, EventArgs e)
        {   
            if((Rechercher_Dote.Text != "" & Rechercher_Nom.Text != "") || (Rechercher_Nom.Text != "" & Rechercher_Prenom.Text != "") || (Rechercher_Prenom.Text != "" & Rechercher_Dote.Text != ""))
            {
                MessageBox.Show("zefml,emlf");
            }
            else if (Rechercher_Dote.Text != "")
            {
                con.Open();
                adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement],Note,[Date Note] from Employes e, Notes n where e.Dote=n.[Dote id]  and Dote='" + Rechercher_Dote.Text + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                Rechercher_Dote.Text = "";
            }
            else if (Rechercher_Nom.Text != "")
            {
                    con.Open();
                    adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement],Note,[Date Note] from Employes e, Notes n where e.Dote=n.[Dote id]  and Nom='" + Rechercher_Nom.Text + "'", con);
                    dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    Rechercher_Nom.Text = "";
            }
            else if (Rechercher_Prenom.Text != "")
            {
                con.Open();
                adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement],Note,[Date Note] from Employes e, Notes n where e.Dote=n.[Dote id]  and Prenom='" + Rechercher_Prenom.Text + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                Rechercher_Prenom.Text = "";
            }
            else
            {
                MessageBox.Show("Entrer le mot souhaitant rechercher");
            }
        }

        private void Afficher_les_notes_Load(object sender, EventArgs e)
        {

        }
        //Pour le calcule des moyen 10ans et 6ans et 3ans
        private void Moyen10_Click(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement],SUM(Note)/10 as Moyen from Employes e, Notes n where e.Dote=n.[Dote id] and [Date Note]>DATEADD(year,-10,GETDATE()) group by Dote,Nom,Prenom,Grade,Service,[Date Recrutement] having COUNT(Note)>=10", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Moyen6_Click(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement],SUM(Note)/6 as Moyen from Employes e, Notes n where e.Dote=n.[Dote id] and [Date Note]>DATEADD(year,-6,GETDATE()) group by Dote,Nom,Prenom,Grade,Service,[Date Recrutement] having COUNT(Note)>=6", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Moyen3_Click(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement],SUM(Note)/3 as Moyen from Employes e, Notes n where e.Dote=n.[Dote id] and [Date Note]>DATEADD(year,-3,GETDATE()) group by Dote,Nom,Prenom,Grade,Service,[Date Recrutement] having COUNT(Note)>=3", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Nouvel_Employe_Click(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement] from Employes e, Notes n where e.Dote=n.[Dote id] group by Dote,Nom,Prenom,Grade,Service,[Date Recrutement] having COUNT(Note)<3", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void AucunNote_Click(object sender, EventArgs e)
        {
            con.Open();
            adapt = new SqlDataAdapter("select Dote,Nom,Prenom,Grade,Service,[Date Recrutement] from Employes where Dote NOT IN (SELECT [Dote Id] FROM Notes)", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
