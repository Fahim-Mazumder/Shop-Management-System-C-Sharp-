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
    public partial class UpdateSalesman : MetroForm
    {
        SqlConnection con;       
        public UpdateSalesman()
        {
            InitializeComponent();
        }

        private void Update_Salesman_Load(object sender, EventArgs e)
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

        private void metroTextBoxSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con = DataAccess.Sqcon;
                DataSet ds = new DataSet();
                ds = DataAccess.GetDataSet("select * from Salesman where UserID = '" + metroTextBoxSearch.Text + "'");
                string name, mobilenumber, userid, password;
                userid = ds.Tables[0].Rows[0][0].ToString();
                name = ds.Tables[0].Rows[0][1].ToString();
                mobilenumber = ds.Tables[0].Rows[0][2].ToString();
                password = ds.Tables[0].Rows[0][3].ToString();
                metroTextBox2.Text = userid;
                metroTextBox3.Text = name;
                metroTextBox4.Text = mobilenumber;
                metroTextBox5.Text = password;
            }
            catch (Exception)
            {
                MessageBox.Show("!! This User ID is not available !!");
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
                
                DialogResult dr = MessageBox.Show("Are you sure?", "Update Salesman!!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dr==DialogResult.Yes && metroTextBox5.Text==metroTextBox6.Text)
                {
                    DataAccess.ExecuteQuery("update Salesman set Name ='" + metroTextBox3.Text + "',MobileNumber ='" + metroTextBox4.Text + "',Password ='" + metroTextBox5.Text + "',RetypePassword ='" + metroTextBox6.Text + "' where UserID='" + metroTextBox2.Text + "'");
                    MessageBox.Show("Update successful");
                    metroTextBox2.Text = "";
                    metroTextBox3.Text = "";
                    metroTextBox4.Text = "";
                    metroTextBox5.Text = "";
                    metroTextBox6.Text = "";
                    metroTextBoxSearch.Text = "";
                }
                else
                {
                    MessageBox.Show("!! Password does not match !!");
                }
                con.Close();
            }
            catch(Exception)
            {
                
                    MessageBox.Show("!! Insert Correct Mobile Number !!");
                
                
                
            }
        }
    }
}
