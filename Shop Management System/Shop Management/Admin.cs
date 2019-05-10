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
    public partial class Admin : MetroForm
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddSalesman a = new AddSalesman();
            a.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            UpdateSalesman us = new UpdateSalesman();
            us.Show();
            this.Hide();
        }

        private void DeleteSalesman_Click(object sender, EventArgs e)
        {
            DeleteSalesman ds = new DeleteSalesman();
            ds.Show();
            this.Hide();
        }

        private void metroButtonAddNewItem_Click(object sender, EventArgs e)
        {
            AddNewItem ai = new AddNewItem();
            ai.Show();
            this.Hide();
        }

        private void metroButtonLogout_Click(object sender, EventArgs e)
        {
            Login li = new Login();
            li.Show();
            this.Hide();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            UpdateItem ui = new UpdateItem();
            ui.Show();
            this.Hide();
        }

        private void metroButtonDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteItem di = new DeleteItem();
            di.Show();
            this.Hide();
        }

        private void metroButtonShowAllSalesman_Click(object sender, EventArgs e)
        {
            ShowSalesman ss = new ShowSalesman();
            ss.Show();
            this.Hide();
        }

        private void metroButtonShowAllProduct_Click(object sender, EventArgs e)
        {
            ShowProduct sp = new ShowProduct();
            sp.Show();
            this.Hide();
                
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Graph gr = new Graph();
            gr.Show();
            this.Hide();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            Message m = new Message();
            m.Show();
            this.Hide();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            AdminInfo ai = new AdminInfo();
            ai.Show();
            this.Hide();
        }
    }
}
