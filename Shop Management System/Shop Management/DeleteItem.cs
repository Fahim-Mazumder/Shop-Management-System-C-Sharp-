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
    public partial class DeleteItem : MetroForm
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        int id = 0;
        public DeleteItem()
        {
            InitializeComponent();
        }

        private void DeleteItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet12.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.loginDBDataSet12.Product);
        }

        void DisplayDataTable()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter("select * from Product", con);
                sda.Fill(dt);
                dgv.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("!! Product Information not found !!");
            }
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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = DataAccess.Sqcon;
                sda = new SqlDataAdapter("select * from Product where ProductID like '" + textBoxSearch.Text + "%' OR ProductName like '"+ textBoxSearch.Text+"%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("!! Product not available !!");
            }
        }

        private void metroButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    try
                    {
                        cmd = new SqlCommand("delete Product where ProductID='" + id + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Product Deleted Successfully!");
                        textBoxSearch.Text = "";
                        DisplayDataTable();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("!! Please Select a Product to Delete !!");
                    }
                }
                else
                {
                    MessageBox.Show("!! Please Select a Product to Delete !!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("!! Please Select a Product to Delete !!");
            }
            
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
