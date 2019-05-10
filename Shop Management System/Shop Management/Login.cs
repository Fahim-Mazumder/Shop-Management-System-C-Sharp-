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
    public partial class Login : MetroForm
    {
        SqlConnection con;
        SqlDataAdapter sda;
        public Login()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con = DataAccess.Sqcon;
                sda = new SqlDataAdapter("select * from login where UserID='" + metroTextBoxUserName.Text + "' and Password='" + metroTextBoxPassword.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
               if(dt.Rows.Count==1)
                {
                    switch (dt.Rows[0]["Role"] as string)
                    {
                        case "Admin":
                            {
                                this.Hide();
                                Admin ad = new Admin();
                                ad.Show();
                                break;
                            }

                        case "Salesman":
                            {
                                this.Hide();
                                Salesman sa = new Salesman();
                                sa.Show();
                                break;
                            }

                        default:
                            {
                                break;
                            }
                    }
                }
               else
                {
                    MessageBox.Show("!! Insert correct username & password !!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    metroTextBoxUserName.Text = "";
                    metroTextBoxPassword.Text = "";

                }
            }
            catch (Exception)
            {
                     MessageBox.Show("!! Insert correct username & password !!", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroTextBoxUserName.Text = "";
                metroTextBoxPassword.Text = "";

            }
        }
    }
}
