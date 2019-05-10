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
    public partial class AdminInfo : MetroForm
    {
        SqlConnection con;
        int aid=1001;
        public AdminInfo()
        {
            InitializeComponent();
            try
            {
                DataSet ds = new DataSet();
                con = DataAccess.Sqcon;
                ds = DataAccess.GetDataSet("SELECT  TOP  1 * FROM  Admin  ORDER  BY AdminID DESC");
                aid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Database Connection error");
            }
            aid = aid + 1;
            metroTextBoxAdminID.Text = aid.ToString();
        }

        private void AdminInfo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
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

        private void metroButtonInsert_Click(object sender, EventArgs e)
        {
            if (metroTextBoxAdminID.Text != "" && metroTextBoxAdminName.Text != "" && metroTextBoxMobile.Text != "" && metroTextBoxPassword.Text != "" && metroTextBoxRetypePass.Text != "" && metroTextBoxPassword.Text == metroTextBoxRetypePass.Text)
            {

                try
                {
                    con = DataAccess.Sqcon;
                    DataAccess.ExecuteQuery("set identity_insert Admin on");
                    DataAccess.ExecuteQuery("insert into Admin(AdminID,Name,MobileNumber,Password,RetypePassword) values(' " + aid + "','" + metroTextBoxAdminName.Text + "','" + Convert.ToInt32(metroTextBoxMobile.Text) + "','" + metroTextBoxPassword.Text + "','" + metroTextBoxRetypePass.Text + "')");
                    DataAccess.ExecuteQuery("insert into Login(UserID,Password,Role) values(' " + aid + "','" + metroTextBoxPassword.Text + "','Admin')");
                    con.Close();
                    MessageBox.Show("Saved Successfully");
                    aid = aid + 1;
                    metroTextBoxAdminID.Text = aid.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("!! Insert Correct Mobile Number !!");
                }


            }

            else if (metroTextBoxAdminID.Text != "" && metroTextBoxAdminName.Text != "" && metroTextBoxMobile.Text != "" && metroTextBoxPassword.Text != "" && metroTextBoxRetypePass.Text != "" && metroTextBoxPassword.Text != metroTextBoxRetypePass.Text)
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
            metroTextBoxAdminName.Text = "";
            metroTextBoxMobile.Text = "";
            metroTextBoxPassword.Text = "";
            metroTextBoxRetypePass.Text="";
        }
    }
}
