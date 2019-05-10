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
    public partial class UpdateItem : MetroForm
    {
        SqlConnection con;
        public UpdateItem()
        {
            InitializeComponent();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonLogout_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }

        private void metroButtonBack_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                con = DataAccess.Sqcon;
                DataSet ds = new DataSet();
                ds = DataAccess.GetDataSet("select * from Product where ProductID = '" + metroTextBox1.Text + "'");
                string productid, productname, quantity, buyingprice,sellingprice;
                productid = ds.Tables[0].Rows[0][0].ToString();
                productname = ds.Tables[0].Rows[0][1].ToString();
                quantity = ds.Tables[0].Rows[0][2].ToString();
                buyingprice = ds.Tables[0].Rows[0][3].ToString();
                sellingprice = ds.Tables[0].Rows[0][4].ToString();
                metroTextBox6.Text = productid;
                metroTextBox2.Text = productname;
                metroTextBox3.Text = quantity;
                metroTextBox4.Text = buyingprice;
                metroTextBox5.Text = sellingprice;
            }
            catch (Exception)
            {
                MessageBox.Show("!! This Product ID is not available !!");
                metroTextBox6.Text = "";
                metroTextBox2.Text = "";
                metroTextBox3.Text = "";
                metroTextBox4.Text = "";
                metroTextBox5.Text = "";
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                con = DataAccess.Sqcon;

                DialogResult dr = MessageBox.Show("Are you sure?", "Update Product!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    DataAccess.ExecuteQuery("update Product set ProductName ='" + metroTextBox2.Text + "',Quantity ='" + metroTextBox3.Text + "',BuyingPrice ='" + metroTextBox4.Text + "',SellingPrice ='" + metroTextBox5.Text + "' where ProductID='" + metroTextBox6.Text + "'");
                    MessageBox.Show("Update Successful");
                    metroTextBox6.Text = "";
                    metroTextBox2.Text = "";
                    metroTextBox3.Text = "";
                    metroTextBox4.Text = "";
                    metroTextBox5.Text = "";
                    metroTextBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("!! Update not Successful !!");
                }
                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("!! Provide Correct Details !!");



            }
        }
    }
}
