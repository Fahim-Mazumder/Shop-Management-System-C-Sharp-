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

namespace Shop_Management
{
    public partial class Graph : MetroForm
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDBDataSet15.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter2.Fill(this.loginDBDataSet15.Product);
            // TODO: This line of code loads data into the 'loginDBDataSet14.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.loginDBDataSet14.Product);
            // TODO: This line of code loads data into the 'loginDBDataSet13.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.loginDBDataSet13.Product);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            chart1.Series.Add("ProductID");
            chart1.Series["ProductID"].XValueMember ="ProductID";
            chart1.Series["ProductID"].YValueMembers = "SellingPrice";
            chart1.DataSource = loginDBDataSet13.Product;
            chart1.DataBind();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            chart2.Series.Add("ProductID");
            chart2.Series["ProductID"].XValueMember = "ProductID";
            chart2.Series["ProductID"].YValueMembers = "BuyingPrice";
            chart2.DataSource = loginDBDataSet14.Product;
            chart2.DataBind();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
