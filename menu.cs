using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_hotel
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            panel1.Size = new Size(229, 612);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 229)
            {
                panel1.Size = new Size(82, 612);
            }
            else
            {
                panel1.Size = new Size(229, 612);
            }
        }


        private void openChildForm(Form childForm)
        {
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlafficher.Controls.Add(childForm);
            pnlafficher.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pnlBut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            openChildForm(new client());
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlafficher_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnreservation_Click(object sender, EventArgs e)
        {
            
        }

        private void btnchambre_Click(object sender, EventArgs e)
        {
            openChildForm(new chambre());
        }

        private void btnemploye_Click(object sender, EventArgs e)
        {

        }

        private void btnfacture_Click(object sender, EventArgs e)
        {

        }
    }
}
