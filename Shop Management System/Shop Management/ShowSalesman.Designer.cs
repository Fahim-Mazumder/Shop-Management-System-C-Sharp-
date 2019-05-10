namespace Shop_Management
{
    partial class ShowSalesman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSalesman));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retypePasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesmanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginDBDataSet9 = new Shop_Management.LoginDBDataSet9();
            this.addSalesmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDBDataSet3 = new Shop_Management.LoginDBDataSet3();
            this.addSalesmanTableAdapter = new Shop_Management.LoginDBDataSet3TableAdapters.AddSalesmanTableAdapter();
            this.metroButtonBack = new MetroFramework.Controls.MetroButton();
            this.metroButtonLogout = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.loginDBDataSet8 = new Shop_Management.LoginDBDataSet8();
            this.salesmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesmanTableAdapter = new Shop_Management.LoginDBDataSet8TableAdapters.SalesmanTableAdapter();
            this.salesmanTableAdapter1 = new Shop_Management.LoginDBDataSet9TableAdapters.SalesmanTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSalesmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNumberDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.retypePasswordDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.salesmanBindingSource1;
            this.dgv.Location = new System.Drawing.Point(37, 87);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(541, 164);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // retypePasswordDataGridViewTextBoxColumn
            // 
            this.retypePasswordDataGridViewTextBoxColumn.DataPropertyName = "RetypePassword";
            this.retypePasswordDataGridViewTextBoxColumn.HeaderText = "RetypePassword";
            this.retypePasswordDataGridViewTextBoxColumn.Name = "retypePasswordDataGridViewTextBoxColumn";
            // 
            // salesmanBindingSource1
            // 
            this.salesmanBindingSource1.DataMember = "Salesman";
            this.salesmanBindingSource1.DataSource = this.loginDBDataSet9;
            // 
            // loginDBDataSet9
            // 
            this.loginDBDataSet9.DataSetName = "LoginDBDataSet9";
            this.loginDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addSalesmanBindingSource
            // 
            this.addSalesmanBindingSource.DataMember = "AddSalesman";
            this.addSalesmanBindingSource.DataSource = this.loginDBDataSet3;
            // 
            // loginDBDataSet3
            // 
            this.loginDBDataSet3.DataSetName = "LoginDBDataSet3";
            this.loginDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addSalesmanTableAdapter
            // 
            this.addSalesmanTableAdapter.ClearBeforeFill = true;
            // 
            // metroButtonBack
            // 
            this.metroButtonBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonBack.Location = new System.Drawing.Point(345, 290);
            this.metroButtonBack.Name = "metroButtonBack";
            this.metroButtonBack.Size = new System.Drawing.Size(107, 53);
            this.metroButtonBack.TabIndex = 1;
            this.metroButtonBack.Text = "Back";
            this.metroButtonBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroButtonBack.UseSelectable = true;
            this.metroButtonBack.Click += new System.EventHandler(this.metroButtonBack_Click);
            // 
            // metroButtonLogout
            // 
            this.metroButtonLogout.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonLogout.Location = new System.Drawing.Point(487, 290);
            this.metroButtonLogout.Name = "metroButtonLogout";
            this.metroButtonLogout.Size = new System.Drawing.Size(100, 53);
            this.metroButtonLogout.TabIndex = 2;
            this.metroButtonLogout.Text = "Logout";
            this.metroButtonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroButtonLogout.UseSelectable = true;
            this.metroButtonLogout.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(250, 34);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(187, 20);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // loginDBDataSet8
            // 
            this.loginDBDataSet8.DataSetName = "LoginDBDataSet8";
            this.loginDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesmanBindingSource
            // 
            this.salesmanBindingSource.DataMember = "Salesman";
            this.salesmanBindingSource.DataSource = this.loginDBDataSet8;
            // 
            // salesmanTableAdapter
            // 
            this.salesmanTableAdapter.ClearBeforeFill = true;
            // 
            // salesmanTableAdapter1
            // 
            this.salesmanTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(190, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Print";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Shop_Management.Properties.Resources.logout;
            this.pictureBox3.Location = new System.Drawing.Point(480, 290);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Shop_Management.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(345, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shop_Management.Properties.Resources.print;
            this.pictureBox1.Location = new System.Drawing.Point(190, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // ShowSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 421);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButtonLogout);
            this.Controls.Add(this.metroButtonBack);
            this.Controls.Add(this.dgv);
            this.Name = "ShowSalesman";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowSalesman_Load);
            this.Load += new System.EventHandler(this.ShowSalesman_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSalesmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private LoginDBDataSet3 loginDBDataSet3;
        private System.Windows.Forms.BindingSource addSalesmanBindingSource;
        private LoginDBDataSet3TableAdapters.AddSalesmanTableAdapter addSalesmanTableAdapter;
        private MetroFramework.Controls.MetroButton metroButtonBack;
        private MetroFramework.Controls.MetroButton metroButtonLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private LoginDBDataSet8 loginDBDataSet8;
        private System.Windows.Forms.BindingSource salesmanBindingSource;
        private LoginDBDataSet8TableAdapters.SalesmanTableAdapter salesmanTableAdapter;
        private LoginDBDataSet9 loginDBDataSet9;
        private System.Windows.Forms.BindingSource salesmanBindingSource1;
        private LoginDBDataSet9TableAdapters.SalesmanTableAdapter salesmanTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retypePasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}