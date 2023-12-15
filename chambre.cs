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
    public partial class chambre : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eki\Desktop\projet c#\gestion_hotel\gestion_hotel.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public chambre()
        {
            InitializeComponent();
            chambre_Load();
        }

        private void chambre_Load(object sender, EventArgs e)
        {

        }
        private void chambre_Load()
        {
            int i = 0;
            dgvChambre.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM Chambres", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvChambre.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void dgvChambre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvChambre.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ChambreForm chambre = new ChambreForm(); // Issue here
                chambre.labelChambreId.Text = dgvChambre.Rows[e.RowIndex].Cells[0].Value.ToString();
                chambre.labelChambreId.Text = dgvChambre.Rows[e.RowIndex].Cells[0].Value.ToString();
                chambre.textChambreType.Text = dgvChambre.Rows[e.RowIndex].Cells[1].Value.ToString();
                chambre.textChambrePrix.Text = dgvChambre.Rows[e.RowIndex].Cells[2].Value.ToString();
                chambre.textChambreDispo.Text = dgvChambre.Rows[e.RowIndex].Cells[3].Value.ToString();
                chambre.textChambreDescription.Text = dgvChambre.Rows[e.RowIndex].Cells[4].Value.ToString();

                chambre.btnSave.Enabled = false;
                chambre.btnUpdate.Enabled = true;
                chambre.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Etes vous sûre de vouloir supprimer cette chambre?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM Chambres WHERE ID_Chambre LIKE '" + dgvChambre.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Chambre a été supprimé avec succée.");
                }
            }
            chambre_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChambreForm moduleForm = new ChambreForm();
            moduleForm.ShowDialog();
            chambre_Load();
        }
    }
}
