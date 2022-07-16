namespace eshift
{
    partial class form_userDashboard
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_add = new System.Windows.Forms.TabPage();
            this.btn_removeItem = new System.Windows.Forms.Button();
            this.list_items = new System.Windows.Forms.ListBox();
            this.btn_selectItem = new System.Windows.Forms.Button();
            this.btn_req = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_endCity = new System.Windows.Forms.ComboBox();
            this.combo_startCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date_add = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_jobs = new System.Windows.Forms.TabPage();
            this.list_jobs = new System.Windows.Forms.ListBox();
            this.tab_account = new System.Windows.Forms.TabPage();
            this.link_pass = new System.Windows.Forms.LinkLabel();
            this.link_lname = new System.Windows.Forms.LinkLabel();
            this.link_fname = new System.Windows.Forms.LinkLabel();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.testBtn1 = new System.Windows.Forms.Button();
            this.box_job = new System.Windows.Forms.ListBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.eshiftDatabaseDataSet = new eshift.EshiftDatabaseDataSet();
            this.adminTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableTableAdapter = new eshift.EshiftDatabaseDataSetTableAdapters.adminTableTableAdapter();
            this.lbl_total = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_add.SuspendLayout();
            this.tab_jobs.SuspendLayout();
            this.tab_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eshiftDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(796, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_add);
            this.tabControl1.Controls.Add(this.tab_jobs);
            this.tabControl1.Controls.Add(this.tab_account);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 411);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tab_add
            // 
            this.tab_add.Controls.Add(this.lbl_total);
            this.tab_add.Controls.Add(this.testBtn1);
            this.tab_add.Controls.Add(this.btn_removeItem);
            this.tab_add.Controls.Add(this.list_items);
            this.tab_add.Controls.Add(this.btn_selectItem);
            this.tab_add.Controls.Add(this.btn_req);
            this.tab_add.Controls.Add(this.label4);
            this.tab_add.Controls.Add(this.combo_endCity);
            this.tab_add.Controls.Add(this.combo_startCity);
            this.tab_add.Controls.Add(this.label3);
            this.tab_add.Controls.Add(this.date_add);
            this.tab_add.Controls.Add(this.label2);
            this.tab_add.Controls.Add(this.label1);
            this.tab_add.Location = new System.Drawing.Point(4, 22);
            this.tab_add.Name = "tab_add";
            this.tab_add.Size = new System.Drawing.Size(875, 385);
            this.tab_add.TabIndex = 2;
            this.tab_add.Text = "Create new job";
            this.tab_add.UseVisualStyleBackColor = true;
            this.tab_add.Click += new System.EventHandler(this.tab_add_Click);
            this.tab_add.Enter += new System.EventHandler(this.tab_add_Enter);
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.Enabled = false;
            this.btn_removeItem.Location = new System.Drawing.Point(709, 350);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(82, 23);
            this.btn_removeItem.TabIndex = 11;
            this.btn_removeItem.Text = "Remove Item";
            this.btn_removeItem.UseVisualStyleBackColor = true;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // list_items
            // 
            this.list_items.FormattingEnabled = true;
            this.list_items.Location = new System.Drawing.Point(69, 121);
            this.list_items.Name = "list_items";
            this.list_items.Size = new System.Drawing.Size(553, 251);
            this.list_items.TabIndex = 10;
            this.list_items.SelectedIndexChanged += new System.EventHandler(this.list_items_SelectedIndexChanged);
            // 
            // btn_selectItem
            // 
            this.btn_selectItem.Location = new System.Drawing.Point(628, 350);
            this.btn_selectItem.Name = "btn_selectItem";
            this.btn_selectItem.Size = new System.Drawing.Size(75, 23);
            this.btn_selectItem.TabIndex = 9;
            this.btn_selectItem.Text = "Select item";
            this.btn_selectItem.UseVisualStyleBackColor = true;
            this.btn_selectItem.Click += new System.EventHandler(this.btn_selectItem_Click);
            // 
            // btn_req
            // 
            this.btn_req.Location = new System.Drawing.Point(797, 350);
            this.btn_req.Name = "btn_req";
            this.btn_req.Size = new System.Drawing.Size(75, 23);
            this.btn_req.TabIndex = 8;
            this.btn_req.Text = "Request Job";
            this.btn_req.UseVisualStyleBackColor = true;
            this.btn_req.Click += new System.EventHandler(this.btn_req_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Items :";
            // 
            // combo_endCity
            // 
            this.combo_endCity.FormattingEnabled = true;
            this.combo_endCity.Location = new System.Drawing.Point(63, 42);
            this.combo_endCity.Name = "combo_endCity";
            this.combo_endCity.Size = new System.Drawing.Size(121, 21);
            this.combo_endCity.TabIndex = 5;
            this.combo_endCity.DropDown += new System.EventHandler(this.combo_endCity_DropDown);
            // 
            // combo_startCity
            // 
            this.combo_startCity.FormattingEnabled = true;
            this.combo_startCity.Location = new System.Drawing.Point(63, 7);
            this.combo_startCity.Name = "combo_startCity";
            this.combo_startCity.Size = new System.Drawing.Size(121, 21);
            this.combo_startCity.TabIndex = 4;
            this.combo_startCity.DropDown += new System.EventHandler(this.combo_startCity_DropDown);
            this.combo_startCity.SelectedIndexChanged += new System.EventHandler(this.combo_startCity_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // date_add
            // 
            this.date_add.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_add.Location = new System.Drawing.Point(63, 80);
            this.date_add.Name = "date_add";
            this.date_add.Size = new System.Drawing.Size(84, 20);
            this.date_add.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "End City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start City";
            // 
            // tab_jobs
            // 
            this.tab_jobs.Controls.Add(this.box_job);
            this.tab_jobs.Controls.Add(this.list_jobs);
            this.tab_jobs.Location = new System.Drawing.Point(4, 22);
            this.tab_jobs.Name = "tab_jobs";
            this.tab_jobs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_jobs.Size = new System.Drawing.Size(875, 385);
            this.tab_jobs.TabIndex = 0;
            this.tab_jobs.Text = "View jobs";
            this.tab_jobs.UseVisualStyleBackColor = true;
            // 
            // list_jobs
            // 
            this.list_jobs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_jobs.FormattingEnabled = true;
            this.list_jobs.Location = new System.Drawing.Point(8, 6);
            this.list_jobs.Name = "list_jobs";
            this.list_jobs.Size = new System.Drawing.Size(371, 368);
            this.list_jobs.TabIndex = 0;
            this.list_jobs.SelectedValueChanged += new System.EventHandler(this.list_jobs_SelectedValueChanged);
            // 
            // tab_account
            // 
            this.tab_account.Controls.Add(this.btn_update);
            this.tab_account.Controls.Add(this.link_pass);
            this.tab_account.Controls.Add(this.link_lname);
            this.tab_account.Controls.Add(this.link_fname);
            this.tab_account.Controls.Add(this.txt_pass);
            this.tab_account.Controls.Add(this.label8);
            this.tab_account.Controls.Add(this.txt_email);
            this.tab_account.Controls.Add(this.label7);
            this.tab_account.Controls.Add(this.txt_lname);
            this.tab_account.Controls.Add(this.label6);
            this.tab_account.Controls.Add(this.txt_fname);
            this.tab_account.Controls.Add(this.label5);
            this.tab_account.Location = new System.Drawing.Point(4, 22);
            this.tab_account.Name = "tab_account";
            this.tab_account.Padding = new System.Windows.Forms.Padding(3);
            this.tab_account.Size = new System.Drawing.Size(875, 385);
            this.tab_account.TabIndex = 1;
            this.tab_account.Text = "Manage account";
            this.tab_account.UseVisualStyleBackColor = true;
            this.tab_account.Click += new System.EventHandler(this.tab_account_Click);
            // 
            // link_pass
            // 
            this.link_pass.AutoSize = true;
            this.link_pass.Location = new System.Drawing.Point(206, 95);
            this.link_pass.Name = "link_pass";
            this.link_pass.Size = new System.Drawing.Size(24, 13);
            this.link_pass.TabIndex = 10;
            this.link_pass.TabStop = true;
            this.link_pass.Text = "edit";
            this.link_pass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_pass_LinkClicked);
            // 
            // link_lname
            // 
            this.link_lname.AutoSize = true;
            this.link_lname.Location = new System.Drawing.Point(206, 43);
            this.link_lname.Name = "link_lname";
            this.link_lname.Size = new System.Drawing.Size(24, 13);
            this.link_lname.TabIndex = 9;
            this.link_lname.TabStop = true;
            this.link_lname.Text = "edit";
            this.link_lname.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lname_LinkClicked);
            // 
            // link_fname
            // 
            this.link_fname.AutoSize = true;
            this.link_fname.Location = new System.Drawing.Point(206, 18);
            this.link_fname.Name = "link_fname";
            this.link_fname.Size = new System.Drawing.Size(24, 13);
            this.link_fname.TabIndex = 8;
            this.link_fname.TabStop = true;
            this.link_fname.Text = "edit";
            this.link_fname.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_fname_LinkClicked);
            // 
            // txt_pass
            // 
            this.txt_pass.Enabled = false;
            this.txt_pass.Location = new System.Drawing.Point(100, 88);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(100, 20);
            this.txt_pass.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Password";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(100, 62);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email";
            // 
            // txt_lname
            // 
            this.txt_lname.Enabled = false;
            this.txt_lname.Location = new System.Drawing.Point(100, 36);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(100, 20);
            this.txt_lname.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Last Name";
            // 
            // txt_fname
            // 
            this.txt_fname.Enabled = false;
            this.txt_fname.Location = new System.Drawing.Point(100, 11);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(100, 20);
            this.txt_fname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "First Name";
            // 
            // testBtn1
            // 
            this.testBtn1.Location = new System.Drawing.Point(537, 63);
            this.testBtn1.Name = "testBtn1";
            this.testBtn1.Size = new System.Drawing.Size(75, 23);
            this.testBtn1.TabIndex = 12;
            this.testBtn1.Text = "TestFunc1";
            this.testBtn1.UseVisualStyleBackColor = true;
            this.testBtn1.Click += new System.EventHandler(this.testBtn1_Click);
            // 
            // box_job
            // 
            this.box_job.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.box_job.FormattingEnabled = true;
            this.box_job.Location = new System.Drawing.Point(385, 6);
            this.box_job.Name = "box_job";
            this.box_job.Size = new System.Drawing.Size(482, 368);
            this.box_job.TabIndex = 0;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.Location = new System.Drawing.Point(779, 356);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(93, 23);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Save changes";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // eshiftDatabaseDataSet
            // 
            this.eshiftDatabaseDataSet.DataSetName = "EshiftDatabaseDataSet";
            this.eshiftDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableBindingSource
            // 
            this.adminTableBindingSource.DataMember = "adminTable";
            this.adminTableBindingSource.DataSource = this.eshiftDatabaseDataSet;
            // 
            // adminTableTableAdapter
            // 
            this.adminTableTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(628, 334);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 13);
            this.lbl_total.TabIndex = 13;
            this.lbl_total.Text = "Total:";
            // 
            // form_userDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "form_userDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.form_userDashboard_Load);
            this.Click += new System.EventHandler(this.form_userDashboard_Click);
            this.Resize += new System.EventHandler(this.form_userDashboard_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tab_add.ResumeLayout(false);
            this.tab_add.PerformLayout();
            this.tab_jobs.ResumeLayout(false);
            this.tab_account.ResumeLayout(false);
            this.tab_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eshiftDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tab_jobs;
        private System.Windows.Forms.TabPage tab_account;
        private System.Windows.Forms.Button btn_req;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_endCity;
        private System.Windows.Forms.ComboBox combo_startCity;
        private System.Windows.Forms.Button btn_selectItem;
        private System.Windows.Forms.ListBox list_jobs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel link_pass;
        private System.Windows.Forms.LinkLabel link_lname;
        private System.Windows.Forms.LinkLabel link_fname;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.ListBox list_items;
        private System.Windows.Forms.Button btn_removeItem;
        private System.Windows.Forms.Button testBtn1;
        private System.Windows.Forms.ListBox box_job;
        private System.Windows.Forms.Button btn_update;
        private EshiftDatabaseDataSet eshiftDatabaseDataSet;
        private System.Windows.Forms.BindingSource adminTableBindingSource;
        private EshiftDatabaseDataSetTableAdapters.adminTableTableAdapter adminTableTableAdapter;
        private System.Windows.Forms.Label lbl_total;
    }
}