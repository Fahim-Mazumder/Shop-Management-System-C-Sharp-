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
    public partial class AddSalesman : MetroForm
    {
        SqlConnection con;
        int aid;
        public AddSalesman()
        {
            InitializeComponent();
            try
            {
                DataSet ds = new DataSet();
                con = DataAccess.Sqcon;
                ds = DataAccess.GetDataSet("SELECT  TOP  1 * FROM  Salesman  ORDER  BY UserID DESC");
                aid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Database Connection error");
            }
            aid = aid + 1;
            metroTextBoxID.Text = aid.ToString();
        }
        private void Add_Salesman_Load(object sender, EventArgs e)
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

        private void metroButtonAddSalesman(object sender, EventArgs e)
        {
            if (metroTextBoxID.Text != "" && metroTextBoxName.Text != "" && metroTextBoxMN.Text != "" && metroTextBoxPassword.Text != "" && metroTextBoxRetypePassword.Text != "" && metroTextBoxPassword.Text==metroTextBoxRetypePassword.Text)
            {
                
                    try
                    {
                    con = DataAccess.Sqcon;
                    DataAccess.ExecuteQuery("set identity_insert Salesman on");
                    DataAccess.ExecuteQuery("insert into Salesman(UserID,Name,MobileNumber,Password,RetypePassword) values(' " + aid + "','" + metroTextBoxName.Text + "','" + Convert.ToInt32(metroTextBoxMN.Text) + "','" + metroTextBoxPassword.Text + "','" + metroTextBoxRetypePassword.Text + "')");
                    DataAccess.ExecuteQuery("insert into Login(UserID,Password,Role) values(' " + aid + "','" + metroTextBoxPassword.Text + "','Salesman')");
                        con.Close();
                        MessageBox.Show("Saved Successfully");
                    aid = aid + 1;
                    metroTextBoxID.Text = aid.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("!! Insert Correct Mobile Number !!");
                    }

                
            }

            else if(metroTextBoxID.Text != "" && metroTextBoxName.Text != "" && metroTextBoxMN.Text != "" && metroTextBoxPassword.Text != "" && metroTextBoxRetypePassword.Text != "" && metroTextBoxPassword.Text!=metroTextBoxRetypePassword.Text)
            {
                MessageBox.Show("Password doesnot match");
            }
            else
            {
                MessageBox.Show("Please Provide all the Details!");
            }
            
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            metroTextBoxName.Text = "";
            metroTextBoxMN.Text = "";
            metroTextBoxPassword.Text = "";
            metroTextBoxRetypePassword.Text = "";


        }

        private void metroTextBoxName_Click(object sender, EventArgs e)
        {

        }
    }
}
