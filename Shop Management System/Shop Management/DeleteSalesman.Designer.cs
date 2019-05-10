namespace Shop_Management
{
    partial class DeleteSalesman
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
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButtonLogout = new MetroFramework.Controls.MetroButton();
            this.metroButtonBack = new MetroFramework.Controls.MetroButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retypePasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDBDataSet10 = new Shop_Management.LoginDBDataSet10();
            this.addSalesmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDBDataSet6 = new Shop_Management.LoginDBDataSet6();
            this.addSalesmanTableAdapter = new Shop_Management.LoginDBDataSet6TableAdapters.AddSalesmanTableAdapter();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonDeleteSalesman = new System.Windows.Forms.Button();
            this.salesmanTableAdapter = new Shop_Management.LoginDBDataSet10TableAdapters.SalesmanTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSalesmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackgroundImage = global::Shop_Management.Properties.Resources.color;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.Location = new System.Drawing.Point(47, 3);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(653, 69);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(20, 60);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(760, 425);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackgroundImage = global::Shop_Management.Properties.Resources.color;
            this.rectangleShape2.BorderWidth = 3;
            this.rectangleShape2.Location = new System.Drawing.Point(43, 91);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(657, 275);
            this.rectangleShape2.Click += new System.EventHandler(this.rectangleShape2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Salesman";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(198, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Search";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Delete Salesman";
            // 
            // metroButtonLogout
            // 
            this.metroButtonLogout.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonLogout.Location = new System.Drawing.Point(562, 433);
            this.metroButtonLogout.Name = "metroButtonLogout";
            this.metroButtonLogout.Size = new System.Drawing.Size(118, 39);
            this.metroButtonLogout.TabIndex = 18;
            this.metroButtonLogout.Text = "Logout";
            this.metroButtonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroButtonLogout.UseSelectable = true;
            this.metroButtonLogout.Click += new System.EventHandler(this.metroButtonLogout_Click);
            // 
            // metroButtonBack
            // 
            this.metroButtonBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonBack.Location = new System.Drawing.Point(409, 433);
            this.metroButtonBack.Name = "metroButtonBack";
            this.metroButtonBack.Size = new System.Drawing.Size(116, 39);
            this.metroButtonBack.TabIndex = 19;
            this.metroButtonBack.Text = "Back";
            this.metroButtonBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroButtonBack.UseSelectable = true;
            this.metroButtonBack.Click += new System.EventHandler(this.metroButtonBack_Click);
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNumberDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.retypePasswordDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.salesmanBindingSource;
            this.dgv.Location = new System.Drawing.Point(123, 163);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(538, 221);
            this.dgv.TabIndex = 20;
            this.dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RowHeaderMouseClick);
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
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            this.mobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // retypePasswordDataGridViewTextBoxColumn
            // 
            this.retypePasswordDataGridViewTextBoxColumn.DataPropertyName = "RetypePassword";
            this.retypePasswordDataGridViewTextBoxColumn.HeaderText = "RetypePassword";
            this.retypePasswordDataGridViewTextBoxColumn.Name = "retypePasswordDataGridViewTextBoxColumn";
            this.retypePasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesmanBindingSource
            // 
            this.salesmanBindingSource.DataMember = "Salesman";
            this.salesmanBindingSource.DataSource = this.loginDBDataSet10;
            // 
            // loginDBDataSet10
            // 
            this.loginDBDataSet10.DataSetName = "LoginDBDataSet10";
            this.loginDBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addSalesmanBindingSource
            // 
            this.addSalesmanBindingSource.DataMember = "AddSalesman";
            this.addSalesmanBindingSource.DataSource = this.loginDBDataSet6;
            // 
            // loginDBDataSet6
            // 
            this.loginDBDataSet6.DataSetName = "LoginDBDataSet6";
            this.loginDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addSalesmanTableAdapter
            // 
            this.addSalesmanTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(310, 97);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(207, 20);
            this.textBoxSearch.TabIndex = 21;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonDeleteSalesman
            // 
            this.buttonDeleteSalesman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSalesman.Location = new System.Drawing.Point(310, 390);
            this.buttonDeleteSalesman.Name = "buttonDeleteSalesman";
            this.buttonDeleteSalesman.Size = new System.Drawing.Size(125, 37);
            this.buttonDeleteSalesman.TabIndex = 22;
            this.buttonDeleteSalesman.Text = "Delete";
            this.buttonDeleteSalesman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteSalesman.UseVisualStyleBackColor = true;
            this.buttonDeleteSalesman.Click += new System.EventHandler(this.button1_Click);
            // 
            // salesmanTableAdapter
            // 
            this.salesmanTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shop_Management.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(409, 433);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Shop_Management.Properties.Resources.logout;
            this.pictureBox2.Location = new System.Drawing.Point(562, 433);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Shop_Management.Properties.Resources.delete;
            this.pictureBox3.Location = new System.Drawing.Point(310, 390);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // DeleteSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDeleteSalesman);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.metroButtonBack);
            this.Controls.Add(this.metroButtonLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "DeleteSalesman";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeleteSalesman_Load);
            this.Load += new System.EventHandler(this.DeleteSalesman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addSalesmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButtonLogout;
        private MetroFramework.Controls.MetroButton metroButtonBack;
        private System.Windows.Forms.DataGridView dgv;
        private LoginDBDataSet6 loginDBDataSet6;
        private System.Windows.Forms.BindingSource addSalesmanBindingSource;
        private LoginDBDataSet6TableAdapters.AddSalesmanTableAdapter addSalesmanTableAdapter;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonDeleteSalesman;
        private LoginDBDataSet10 loginDBDataSet10;
        private System.Windows.Forms.BindingSource salesmanBindingSource;
        private LoginDBDataSet10TableAdapters.SalesmanTableAdapter salesmanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retypePasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}