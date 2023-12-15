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
    public partial class CustumerModule : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eki\Desktop\projet c#\gestion_hotel\gestion_hotel.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public CustumerModule()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CustumerModule_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Etes vous sure que vous voulez ajouter ce client?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO clients(Nom, Prenom, Adresse, NumeroTel, Email)VALUES(@Nom_Client,@Prenom_Client,@Adresse_Client,@Telephone_Client,@Email)", con);
                    cm.Parameters.AddWithValue("@Nom_Client", textCustomerFirstName.Text);
                    cm.Parameters.AddWithValue("@Prenom_Client", textCustomerLastName.Text);
                    cm.Parameters.AddWithValue("@Adresse_Client", textCustomerAddress.Text);
                    cm.Parameters.AddWithValue("@Telephone_Client", textCustomerPhone.Text);
                    cm.Parameters.AddWithValue("@Email", textCustomerEmail.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Client à été enregistré avec succée.");
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
            textCustomerFirstName.Clear();
            textCustomerLastName.Clear();
            textCustomerEmail.Clear();
            textCustomerAddress.Clear();
            textCustomerPhone.Clear();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Etes vous sure que vous voulez mettre à jour ce client?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE clients SET Nom=@Nom_Client, Prenom=@Prenom_Client, Adresse=@Adresse_Client, NumeroTel=@Telephone_Client, Email=@Email WHERE ID_Client LIKE '" + labelCustomerId.Text + "'", con);
                    cm.Parameters.AddWithValue("@Nom_Client", textCustomerFirstName.Text);
                    cm.Parameters.AddWithValue("@Prenom_Client", textCustomerLastName.Text);
                    cm.Parameters.AddWithValue("@Adresse_Client", textCustomerAddress.Text);
                    cm.Parameters.AddWithValue("@Telephone_Client", textCustomerPhone.Text);
                    cm.Parameters.AddWithValue("@Email", textCustomerEmail.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Mise à jour du client a été complit avec succée!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Etes vous sure que vous voulez mettre à jour ce client?", "Updating Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE clients SET Nom=@Nom_Client, Prenom=@Prenom_Client, Adresse=@Adresse_Client, NumeroTel=@Telephone_Client, Email=@Email WHERE ID_Client LIKE '" + labelCustomerId.Text + "'", con);
                    cm.Parameters.AddWithValue("@Nom_Client", textCustomerFirstName.Text);
                    cm.Parameters.AddWithValue("@Prenom_Client", textCustomerLastName.Text);
                    cm.Parameters.AddWithValue("@Adresse_Client", textCustomerAddress.Text);
                    cm.Parameters.AddWithValue("@Telephone_Client", textCustomerPhone.Text);
                    cm.Parameters.AddWithValue("@Email", textCustomerEmail.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Mise à jour du client a été complit avec succée!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelCustomerId_Click(object sender, EventArgs e)
        {

        }
    }
}
