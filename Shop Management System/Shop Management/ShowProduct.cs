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
using System.Data.EntityClient;

namespace Shop_Management
{
    public partial class ShowProduct : MetroForm
    {
        SqlConnection con;
        SqlDataAdapter sda;
        public ShowProduct()
        {
            InitializeComponent();
        }

        public DataGridView DGV
        {
            get { return this.dgv; }
            set { this.dgv = value; }
        }
        private void ShowProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet11.Product' table. You can move, or remove it, as needed.
           // using (north)
                this.productTableAdapter.Fill(this.loginDBDataSet11.Product); 
            
            
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButtonLogout_Click(object sender, EventArgs e)
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

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = DataAccess.Sqcon;
                sda = new SqlDataAdapter("select * from Product where ProductID like '" + textBoxSearch.Text + "%' OR ProductName like '" + textBoxSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("!! This Product is not available !!");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objbit = new Bitmap(this.dgv.Width, this.dgv.Height);
            dgv.DrawToBitmap(objbit, new Rectangle(0, 0, this.dgv.Width, this.dgv.Height));
            e.Graphics.DrawImage(objbit, 200, 150);


        }


        /*private void buttonPrint_Click(object sender, EventArgs e)
        {

            
        }*/

        private void buttonPrint_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
