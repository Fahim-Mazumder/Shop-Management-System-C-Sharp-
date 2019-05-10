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
    public partial class AddNewItem : MetroForm
    {
        SqlConnection con;
        int aid;
        public AddNewItem()
        {
            InitializeComponent();
            try
            {
                DataSet ds = new DataSet();
                con = DataAccess.Sqcon;
                ds = DataAccess.GetDataSet("SELECT  TOP  1 * FROM  Product  ORDER  BY ProductID DESC");
                aid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database Connection error");
            }
            aid = aid + 1;
            metroTextBoxProductID.Text = aid.ToString();
        }

        private void AddNewItem_Load(object sender, EventArgs e)
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
        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (metroTextBoxProductID.Text != "" && metroTextBoxProductName.Text != "" && metroTextBoxQuantity.Text != "" && metroTextBoxBuyingPrice.Text != "" && metroTextBoxSellingPrice.Text != "")

            {
                try
                {
                    con = DataAccess.Sqcon;
                    DataAccess.ExecuteQuery("set identity_insert Product on");
                    DataAccess.ExecuteQuery("insert into Product(ProductID, ProductName,Quantity,BuyingPrice,SellingPrice) values(' " + metroTextBoxProductID.Text + "','" + metroTextBoxProductName.Text + "','" + metroTextBoxQuantity.Text + "','" + metroTextBoxBuyingPrice.Text + "','" + metroTextBoxSellingPrice.Text + "')");
                    con.Close();
                    MessageBox.Show("Saved Successfully");
                    aid = aid + 1;
                    metroTextBoxProductID.Text = aid.ToString();

                }
                catch (Exception)
                {
                    MessageBox.Show("!! Provide Correct Details !!" );
                }
            }
            else
            {
                MessageBox.Show("Please Provide all the Details!");
            }
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            metroTextBoxProductName.Text = "";
            metroTextBoxQuantity.Text = "";
            metroTextBoxSellingPrice.Text = "";
            metroTextBoxBuyingPrice.Text = "";
        }
    }
}
