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
    public partial class DeleteSalesman : MetroForm
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        string id = "";
        public DeleteSalesman()
        {
            InitializeComponent();
        }

        private void DeleteSalesman_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet10.Salesman' table. You can move, or remove it, as needed.
            this.salesmanTableAdapter.Fill(this.loginDBDataSet10.Salesman);
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

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape2_Click(object sender, EventArgs e)
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
                MessageBox.Show("!! Salesman Information not found !!");
            }
        }

        void DisplayDataTable()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                sda = new SqlDataAdapter("select * from Salesman", con);
                sda.Fill(dt);
                dgv.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("!! Salesman not found !!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != "")
                {
                    try
                    {
                        cmd = new SqlCommand("delete Salesman where UserID='" + id + "'", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        DataAccess.ExecuteQuery("delete Login where UserID='" + id + "'");
                        MessageBox.Show("Salesman Deleted Successfully!");
                        textBoxSearch.Text = "";
                        DisplayDataTable();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("!! Please Select a Salesman to Delete !!");
                    }
                }
                else
                {
                    MessageBox.Show("!! Please Select a Salesman to Delete !!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("!! Please Select a Salesman to Delete !!");
            }
            
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
