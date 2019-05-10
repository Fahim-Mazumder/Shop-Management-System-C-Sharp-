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
using DataAccessLayer;
using System.Data.SqlClient;

namespace Shop_Management
{
    public partial class Salesman : MetroForm
    {
        SqlConnection con;
        SqlDataAdapter sda;
        int a=0;
        public Salesman()
        {
            InitializeComponent();
        }

        private void Salesman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet16.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.loginDBDataSet16.Product);
          //  productBindingSource.DataSource = new List<Receipt>();

        }
        public DataGridView DGV
        {
            get { return this.dgv; }
            set { this.dgv = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = DataAccess.Sqcon;
                sda = new SqlDataAdapter("select * from Product where ProductID like '" + textBoxProductName.Text + "%' OR ProductName like '" + textBoxProductName.Text + "%'", con);
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

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxCost.Text = Convert.ToString(int.Parse(textBoxQuantity.Text) * int.Parse(textBoxPrice.Text));
            }
            catch(Exception)
            {
                MessageBox.Show("!! Insert Quantity & Price !!");
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* 
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv.Rows[index];
            textBoxProductName.Text = selectedRow.Cells[1].Value.ToString();
            labelPrice.Text = selectedRow.Cells[3].Value.ToString(); */
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                con = DataAccess.Sqcon;
                DataSet ds = new DataSet();
                ds = DataAccess.GetDataSet("select * from Product where ProductID like '" + textBoxProductName.Text + "%' OR ProductName like '" + textBoxProductName.Text + "%'");
                string productname, sellingprice;
                productname = ds.Tables[0].Rows[0][1].ToString();
                sellingprice = ds.Tables[0].Rows[0][4].ToString();
               // textBoxProductName.Text = productname;
                textBoxPrice.Text = sellingprice;
                textBoxQuantity.Text = "";
                textBoxCost.Text = "";

            }
            catch (Exception)
            {
                MessageBox.Show("!! This Product is not available !!");
                textBoxProductName.Text = "";
                textBoxPrice.Text = "";
            } 

        }

        private void metroButtonTotalCost_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxTotalCost.Text = Convert.ToString(a + Convert.ToInt32(textBoxCost.Text));
                a = 0 + Convert.ToInt32(textBoxTotalCost.Text);
                textBoxCost.Text = "";
                textBoxQuantity.Text = "";
                textBoxPrice.Text = "";
                textBoxProductName.Text = "";
            }
            catch(Exception)
            {
                MessageBox.Show("!! Total Cost Not Found !!");
            }
            
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxCash.Text) > Convert.ToInt32(textBoxTotalCost.Text))
                {
                    textBoxCashBack.Text = Convert.ToString(Convert.ToInt32(textBoxCash.Text) - Convert.ToInt32(textBoxTotalCost.Text));
                }
                else
                {
                    MessageBox.Show("!! Insert Bigger Amount !!");
                    textBoxCash.Text = "";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("!! Insert Cash Amount !!");
            }
            
            
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            textBoxProductName.Text = "";
            textBoxQuantity.Text = "";
            textBoxPrice.Text = "";
            textBoxCost.Text = "";
            textBoxTotalCost.Text = "";
            textBoxCash.Text = "";
            textBoxCashBack.Text = "";
            a = 0;
        }

        private void metroButtonPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objbit = new Bitmap(this.dgv.Width, this.dgv.Height);
            //dgv.DrawToBitmap(objbit, new Rectangle(0, 0, this.dgv.Width, this.dgv.Height));
            //e.Graphics.DrawImage(objbit, 200, 150);
            e.Graphics.DrawString(labelBestBuy.Text, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300,30));
            //e.Graphics.DrawString(label1.Text, new Font("Verdana", 20, FontStyle.Regular), Brushes.Black, new Point(300, 100));
            e.Graphics.DrawString(label4.Text, new Font("Verdana", 20, FontStyle.Regular), Brushes.Black, new Point(300, 100));
            e.Graphics.DrawString(textBoxTotalCost.Text, new Font("Verdana", 20, FontStyle.Regular), Brushes.Black, new Point(500, 100));
            e.Graphics.DrawString(label3.Text, new Font("Verdana", 20, FontStyle.Regular), Brushes.Black, new Point(300, 150));
            e.Graphics.DrawString(textBoxCash.Text, new Font("Verdana", 20, FontStyle.Regular), Brushes.Black, new Point(500, 150));
            e.Graphics.DrawString(labelCashBack.Text, new Font("Verdana", 20, FontStyle.Regular), Brushes.Black, new Point(300, 200));
            e.Graphics.DrawString(textBoxCashBack.Text, new Font("Verdana", 20, FontStyle.Regular), Brushes.Black, new Point(500, 200));
        }
    }
}
