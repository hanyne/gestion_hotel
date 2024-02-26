using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_hotel
{
    public partial class ChambreForm : Form

    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eki\Desktop\projet c#\gestion_hotel\gestion_hotel\gestion_hotel.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public ChambreForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textCustomerAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChambreForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Etes vous sure que vous voulez ajouter cette chambre?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO Chambres(TypeChambre, PrixNuit, Disponibilite, Description)VALUES(@TypeChambre,@PrixNuit,@Disponibilite,@Description)", con);
                    cm.Parameters.AddWithValue("@TypeChambre", textChambreType.Text);
                    cm.Parameters.AddWithValue("@PrixNuit", textChambrePrix.Text);
                    cm.Parameters.AddWithValue("@Disponibilite", textChambreDispo.Text);
                    cm.Parameters.AddWithValue("@Description", textChambreDescription.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Chambre à été enregistré avec succée.");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            public void Clear()
            {
                textChambreType.Clear();
                textChambrePrix.Clear();
                textChambreDispo.Clear();
                textChambreDescription.Clear();
            }
        

        private void textChambreDispo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Êtes-vous sûr de vouloir mettre à jour cette chambre?", "Mise à jour de l'enregistrement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE Chambres SET TypeChambre=@TypeChambre, PrixNuit=@PrixNuit, Disponibilite=@Disponibilite, Description=@Description WHERE ID_Chambre = @ID", con);
                    cm.Parameters.AddWithValue("@TypeChambre", textChambreType.Text);
                    cm.Parameters.AddWithValue("@PrixNuit", textChambrePrix.Text);
                    cm.Parameters.AddWithValue("@Disponibilite", textChambreDispo.Text);
                    cm.Parameters.AddWithValue("@Description", textChambreDescription.Text);
                    cm.Parameters.AddWithValue("@ID", labelChambreId.Text); // Assuming labelChambreId contains the ID value
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("La mise à jour de la chambre a été effectuée avec succès !");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelChambreId_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
