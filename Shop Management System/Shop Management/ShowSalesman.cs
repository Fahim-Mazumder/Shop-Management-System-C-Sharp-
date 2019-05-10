using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using DataAccessLayer;

namespace Shop_Management
{
    public partial class ShowSalesman : MetroForm
    {
        SqlConnection con;
        SqlDataAdapter sda;
        public ShowSalesman()
        {
            InitializeComponent();
        }

        public DataGridView DGV
        {
            get { return this.dgv; }
            set { this.dgv = value; }
        }

        private void ShowSalesman_Load(object sender, EventArgs e)
        {
                       
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void metroButtonBack_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
             ad.Show();
            this.Hide();

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = DataAccess.Sqcon;
                sda = new SqlDataAdapter("select * from Salesman where UserID like '" + textBoxSearch.Text + "%' OR Name like '" + textBoxSearch.Text + "%' OR MobileNumber like '" + textBoxSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("!! This User ID is not available !!");
            }
        }

        private void ShowSalesman_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet9.Salesman' table. You can move, or remove it, as needed.
            this.salesmanTableAdapter1.Fill(this.loginDBDataSet9.Salesman);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objbit = new Bitmap(this.dgv.Width, this.dgv.Height);
            dgv.DrawToBitmap(objbit, new Rectangle(0, 0, this.dgv.Width, this.dgv.Height));
            e.Graphics.DrawImage(objbit, 200, 150);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
