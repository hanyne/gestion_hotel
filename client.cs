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
    public partial class client : Form

    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eki\Desktop\projet c#\gestion_hotel\gestion_hotel\gestion_hotel.mdf;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public client()
        {
            InitializeComponent();
            client_Load();
        }

        private void client_Load(object sender, EventArgs e)
        {


        }
        private void client_Load()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM clients", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvCustomer.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();

        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustumerModule customerModule = new CustumerModule();
                customerModule.labelCustomerId.Text = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                customerModule.textCustomerLastName.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                customerModule.textCustomerFirstName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                customerModule.textCustomerAddress.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                customerModule.textCustomerPhone.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                customerModule.textCustomerEmail.Text = dgvCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();

                customerModule.btnSave.Enabled = false;
                customerModule.btnUpdate.Enabled = true;
                customerModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Etes vous sûre de vouloir supprimer ce client?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM clients WHERE ID_Client LIKE '" + dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Client a été supprimé avec succée.");
                }
            }
            client_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustumerModule moduleForm = new CustumerModule();
            moduleForm.ShowDialog();
            client_Load();
        }
    }
}
