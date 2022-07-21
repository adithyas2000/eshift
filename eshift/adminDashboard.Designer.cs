namespace eshift
{
    partial class adminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashboard));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_review = new System.Windows.Forms.TabPage();
            this.group_manage = new System.Windows.Forms.GroupBox();
            this.btn_finished = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reject = new System.Windows.Forms.Button();
            this.group_details = new System.Windows.Forms.ListBox();
            this.list_jobs = new System.Windows.Forms.ListBox();
            this.tab_items = new System.Windows.Forms.TabPage();
            this.box_addItem = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_newCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_newCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_newName = new System.Windows.Forms.TextBox();
            this.box_editItem = new System.Windows.Forms.GroupBox();
            this.check_available = new System.Windows.Forms.CheckBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_editCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_editCost = new System.Windows.Forms.TextBox();
            this.txt_editName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.list_items = new System.Windows.Forms.ListBox();
            this.tab_cities = new System.Windows.Forms.TabPage();
            this.txt_cityNew = new System.Windows.Forms.TextBox();
            this.btn_addCity = new System.Windows.Forms.Button();
            this.btn_removeCity = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.list_cities = new System.Windows.Forms.ListBox();
            this.tab_account = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_editAdminName = new System.Windows.Forms.TextBox();
            this.link_editName = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_editAdminPass = new System.Windows.Forms.TextBox();
            this.link_editPass = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_editMail = new System.Windows.Forms.TextBox();
            this.btn_updateAdmin = new System.Windows.Forms.Button();
            this.tab_reprots = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_allJobs = new System.Windows.Forms.RadioButton();
            this.rad_allUsers = new System.Windows.Forms.RadioButton();
            this.data_report = new System.Windows.Forms.DataGridView();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_review.SuspendLayout();
            this.group_manage.SuspendLayout();
            this.tab_items.SuspendLayout();
            this.box_addItem.SuspendLayout();
            this.box_editItem.SuspendLayout();
            this.tab_cities.SuspendLayout();
            this.tab_account.SuspendLayout();
            this.tab_reprots.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_report)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_review);
            this.tabControl1.Controls.Add(this.tab_items);
            this.tabControl1.Controls.Add(this.tab_cities);
            this.tabControl1.Controls.Add(this.tab_account);
            this.tabControl1.Controls.Add(this.tab_reprots);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 403);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tab_review
            // 
            this.tab_review.Controls.Add(this.group_manage);
            this.tab_review.Controls.Add(this.group_details);
            this.tab_review.Controls.Add(this.list_jobs);
            this.tab_review.Location = new System.Drawing.Point(4, 22);
            this.tab_review.Name = "tab_review";
            this.tab_review.Padding = new System.Windows.Forms.Padding(3);
            this.tab_review.Size = new System.Drawing.Size(792, 377);
            this.tab_review.TabIndex = 0;
            this.tab_review.Text = "Review Jobs";
            this.tab_review.UseVisualStyleBackColor = true;
            // 
            // group_manage
            // 
            this.group_manage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.group_manage.Controls.Add(this.btn_finished);
            this.group_manage.Controls.Add(this.btn_accept);
            this.group_manage.Controls.Add(this.btn_delete);
            this.group_manage.Controls.Add(this.btn_reject);
            this.group_manage.Location = new System.Drawing.Point(8, 200);
            this.group_manage.Name = "group_manage";
            this.group_manage.Size = new System.Drawing.Size(359, 163);
            this.group_manage.TabIndex = 5;
            this.group_manage.TabStop = false;
            // 
            // btn_finished
            // 
            this.btn_finished.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_finished.Enabled = false;
            this.btn_finished.Location = new System.Drawing.Point(257, 19);
            this.btn_finished.Name = "btn_finished";
            this.btn_finished.Size = new System.Drawing.Size(75, 23);
            this.btn_finished.TabIndex = 5;
            this.btn_finished.Text = "Finished";
            this.btn_finished.UseVisualStyleBackColor = false;
            this.btn_finished.Click += new System.EventHandler(this.btn_finished_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(6, 19);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 2;
            this.btn_accept.Text = "Accept Job";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_delete.Location = new System.Drawing.Point(168, 19);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(83, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete record";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_reject
            // 
            this.btn_reject.Location = new System.Drawing.Point(87, 19);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(75, 23);
            this.btn_reject.TabIndex = 3;
            this.btn_reject.Text = "Reject Job";
            this.btn_reject.UseVisualStyleBackColor = true;
            this.btn_reject.Click += new System.EventHandler(this.btn_reject_Click);
            // 
            // group_details
            // 
            this.group_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_details.FormattingEnabled = true;
            this.group_details.Location = new System.Drawing.Point(373, 8);
            this.group_details.Name = "group_details";
            this.group_details.Size = new System.Drawing.Size(411, 355);
            this.group_details.TabIndex = 1;
            // 
            // list_jobs
            // 
            this.list_jobs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_jobs.FormattingEnabled = true;
            this.list_jobs.Location = new System.Drawing.Point(8, 8);
            this.list_jobs.Name = "list_jobs";
            this.list_jobs.Size = new System.Drawing.Size(359, 186);
            this.list_jobs.TabIndex = 0;
            this.list_jobs.SelectedIndexChanged += new System.EventHandler(this.list_jobs_SelectedIndexChanged);
            // 
            // tab_items
            // 
            this.tab_items.Controls.Add(this.box_addItem);
            this.tab_items.Controls.Add(this.box_editItem);
            this.tab_items.Controls.Add(this.list_items);
            this.tab_items.Location = new System.Drawing.Point(4, 22);
            this.tab_items.Name = "tab_items";
            this.tab_items.Size = new System.Drawing.Size(792, 377);
            this.tab_items.TabIndex = 2;
            this.tab_items.Text = "Manage Items";
            this.tab_items.UseVisualStyleBackColor = true;
            // 
            // box_addItem
            // 
            this.box_addItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_addItem.Controls.Add(this.btn_add);
            this.box_addItem.Controls.Add(this.txt_newCode);
            this.box_addItem.Controls.Add(this.label4);
            this.box_addItem.Controls.Add(this.label6);
            this.box_addItem.Controls.Add(this.txt_newCost);
            this.box_addItem.Controls.Add(this.label5);
            this.box_addItem.Controls.Add(this.txt_newName);
            this.box_addItem.Location = new System.Drawing.Point(8, 226);
            this.box_addItem.Name = "box_addItem";
            this.box_addItem.Size = new System.Drawing.Size(776, 148);
            this.box_addItem.TabIndex = 2;
            this.box_addItem.TabStop = false;
            this.box_addItem.Text = "Add Item";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(6, 119);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add Item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_newCode
            // 
            this.txt_newCode.Enabled = false;
            this.txt_newCode.Location = new System.Drawing.Point(67, 25);
            this.txt_newCode.Name = "txt_newCode";
            this.txt_newCode.Size = new System.Drawing.Size(100, 20);
            this.txt_newCode.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Item Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name";
            // 
            // txt_newCost
            // 
            this.txt_newCost.Location = new System.Drawing.Point(67, 77);
            this.txt_newCost.Name = "txt_newCost";
            this.txt_newCost.Size = new System.Drawing.Size(100, 20);
            this.txt_newCost.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unit Cost";
            // 
            // txt_newName
            // 
            this.txt_newName.Location = new System.Drawing.Point(67, 51);
            this.txt_newName.Name = "txt_newName";
            this.txt_newName.Size = new System.Drawing.Size(100, 20);
            this.txt_newName.TabIndex = 10;
            // 
            // box_editItem
            // 
            this.box_editItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.box_editItem.Controls.Add(this.check_available);
            this.box_editItem.Controls.Add(this.btn_update);
            this.box_editItem.Controls.Add(this.txt_editCode);
            this.box_editItem.Controls.Add(this.label3);
            this.box_editItem.Controls.Add(this.txt_editCost);
            this.box_editItem.Controls.Add(this.txt_editName);
            this.box_editItem.Controls.Add(this.label2);
            this.box_editItem.Controls.Add(this.label1);
            this.box_editItem.Location = new System.Drawing.Point(400, 8);
            this.box_editItem.Name = "box_editItem";
            this.box_editItem.Size = new System.Drawing.Size(384, 212);
            this.box_editItem.TabIndex = 1;
            this.box_editItem.TabStop = false;
            this.box_editItem.Text = "Edit Item";
            // 
            // check_available
            // 
            this.check_available.AutoSize = true;
            this.check_available.Checked = true;
            this.check_available.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_available.Location = new System.Drawing.Point(9, 160);
            this.check_available.Name = "check_available";
            this.check_available.Size = new System.Drawing.Size(104, 17);
            this.check_available.TabIndex = 8;
            this.check_available.Text = "Available to pick";
            this.check_available.UseVisualStyleBackColor = true;
            this.check_available.CheckedChanged += new System.EventHandler(this.check_available_CheckedChanged);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(9, 183);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_editCode
            // 
            this.txt_editCode.Enabled = false;
            this.txt_editCode.Location = new System.Drawing.Point(67, 17);
            this.txt_editCode.Name = "txt_editCode";
            this.txt_editCode.Size = new System.Drawing.Size(100, 20);
            this.txt_editCode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Code";
            // 
            // txt_editCost
            // 
            this.txt_editCost.Enabled = false;
            this.txt_editCost.Location = new System.Drawing.Point(67, 69);
            this.txt_editCost.Name = "txt_editCost";
            this.txt_editCost.Size = new System.Drawing.Size(100, 20);
            this.txt_editCost.TabIndex = 3;
            // 
            // txt_editName
            // 
            this.txt_editName.Enabled = false;
            this.txt_editName.Location = new System.Drawing.Point(67, 43);
            this.txt_editName.Name = "txt_editName";
            this.txt_editName.Size = new System.Drawing.Size(100, 20);
            this.txt_editName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unit Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // list_items
            // 
            this.list_items.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_items.FormattingEnabled = true;
            this.list_items.Location = new System.Drawing.Point(8, 8);
            this.list_items.Name = "list_items";
            this.list_items.Size = new System.Drawing.Size(386, 212);
            this.list_items.TabIndex = 0;
            this.list_items.SelectedIndexChanged += new System.EventHandler(this.list_items_SelectedIndexChanged);
            // 
            // tab_cities
            // 
            this.tab_cities.Controls.Add(this.txt_cityNew);
            this.tab_cities.Controls.Add(this.btn_addCity);
            this.tab_cities.Controls.Add(this.btn_removeCity);
            this.tab_cities.Controls.Add(this.label10);
            this.tab_cities.Controls.Add(this.list_cities);
            this.tab_cities.Location = new System.Drawing.Point(4, 22);
            this.tab_cities.Name = "tab_cities";
            this.tab_cities.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cities.Size = new System.Drawing.Size(792, 377);
            this.tab_cities.TabIndex = 4;
            this.tab_cities.Text = "Manage Cities";
            this.tab_cities.UseVisualStyleBackColor = true;
            // 
            // txt_cityNew
            // 
            this.txt_cityNew.Location = new System.Drawing.Point(228, 7);
            this.txt_cityNew.Name = "txt_cityNew";
            this.txt_cityNew.Size = new System.Drawing.Size(100, 20);
            this.txt_cityNew.TabIndex = 4;
            this.txt_cityNew.TextChanged += new System.EventHandler(this.txt_cityNew_TextChanged);
            // 
            // btn_addCity
            // 
            this.btn_addCity.Enabled = false;
            this.btn_addCity.Location = new System.Drawing.Point(179, 33);
            this.btn_addCity.Name = "btn_addCity";
            this.btn_addCity.Size = new System.Drawing.Size(149, 23);
            this.btn_addCity.TabIndex = 3;
            this.btn_addCity.Text = "Add City";
            this.btn_addCity.UseVisualStyleBackColor = true;
            this.btn_addCity.Click += new System.EventHandler(this.btn_addCity_Click);
            // 
            // btn_removeCity
            // 
            this.btn_removeCity.Enabled = false;
            this.btn_removeCity.Location = new System.Drawing.Point(4, 348);
            this.btn_removeCity.Name = "btn_removeCity";
            this.btn_removeCity.Size = new System.Drawing.Size(167, 23);
            this.btn_removeCity.TabIndex = 2;
            this.btn_removeCity.Text = "Remove City";
            this.btn_removeCity.UseVisualStyleBackColor = true;
            this.btn_removeCity.Click += new System.EventHandler(this.btn_removeCity_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Add City";
            // 
            // list_cities
            // 
            this.list_cities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_cities.FormattingEnabled = true;
            this.list_cities.Location = new System.Drawing.Point(4, 7);
            this.list_cities.Name = "list_cities";
            this.list_cities.Size = new System.Drawing.Size(167, 329);
            this.list_cities.TabIndex = 0;
            this.list_cities.SelectedIndexChanged += new System.EventHandler(this.list_cities_SelectedIndexChanged);
            // 
            // tab_account
            // 
            this.tab_account.Controls.Add(this.label9);
            this.tab_account.Controls.Add(this.txt_editAdminName);
            this.tab_account.Controls.Add(this.link_editName);
            this.tab_account.Controls.Add(this.label8);
            this.tab_account.Controls.Add(this.txt_editAdminPass);
            this.tab_account.Controls.Add(this.link_editPass);
            this.tab_account.Controls.Add(this.label7);
            this.tab_account.Controls.Add(this.txt_editMail);
            this.tab_account.Controls.Add(this.btn_updateAdmin);
            this.tab_account.Location = new System.Drawing.Point(4, 22);
            this.tab_account.Name = "tab_account";
            this.tab_account.Padding = new System.Windows.Forms.Padding(3);
            this.tab_account.Size = new System.Drawing.Size(792, 377);
            this.tab_account.TabIndex = 1;
            this.tab_account.Text = "Manage account";
            this.tab_account.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Name";
            // 
            // txt_editAdminName
            // 
            this.txt_editAdminName.Location = new System.Drawing.Point(62, 40);
            this.txt_editAdminName.Name = "txt_editAdminName";
            this.txt_editAdminName.Size = new System.Drawing.Size(100, 20);
            this.txt_editAdminName.TabIndex = 9;
            // 
            // link_editName
            // 
            this.link_editName.AutoSize = true;
            this.link_editName.Location = new System.Drawing.Point(168, 43);
            this.link_editName.Name = "link_editName";
            this.link_editName.Size = new System.Drawing.Size(24, 13);
            this.link_editName.TabIndex = 8;
            this.link_editName.TabStop = true;
            this.link_editName.Text = "edit";
            this.link_editName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_editName_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Password";
            // 
            // txt_editAdminPass
            // 
            this.txt_editAdminPass.Location = new System.Drawing.Point(62, 66);
            this.txt_editAdminPass.Name = "txt_editAdminPass";
            this.txt_editAdminPass.PasswordChar = '#';
            this.txt_editAdminPass.Size = new System.Drawing.Size(100, 20);
            this.txt_editAdminPass.TabIndex = 6;
            // 
            // link_editPass
            // 
            this.link_editPass.AutoSize = true;
            this.link_editPass.Location = new System.Drawing.Point(168, 69);
            this.link_editPass.Name = "link_editPass";
            this.link_editPass.Size = new System.Drawing.Size(24, 13);
            this.link_editPass.TabIndex = 5;
            this.link_editPass.TabStop = true;
            this.link_editPass.Text = "edit";
            this.link_editPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_editPass_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email";
            // 
            // txt_editMail
            // 
            this.txt_editMail.Enabled = false;
            this.txt_editMail.Location = new System.Drawing.Point(62, 14);
            this.txt_editMail.Name = "txt_editMail";
            this.txt_editMail.Size = new System.Drawing.Size(100, 20);
            this.txt_editMail.TabIndex = 3;
            // 
            // btn_updateAdmin
            // 
            this.btn_updateAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_updateAdmin.Location = new System.Drawing.Point(685, 348);
            this.btn_updateAdmin.Name = "btn_updateAdmin";
            this.btn_updateAdmin.Size = new System.Drawing.Size(99, 23);
            this.btn_updateAdmin.TabIndex = 1;
            this.btn_updateAdmin.Text = "Save Changes";
            this.btn_updateAdmin.UseVisualStyleBackColor = true;
            this.btn_updateAdmin.Click += new System.EventHandler(this.btn_updateAdmin_Click);
            // 
            // tab_reprots
            // 
            this.tab_reprots.Controls.Add(this.groupBox1);
            this.tab_reprots.Controls.Add(this.data_report);
            this.tab_reprots.Location = new System.Drawing.Point(4, 22);
            this.tab_reprots.Name = "tab_reprots";
            this.tab_reprots.Padding = new System.Windows.Forms.Padding(3);
            this.tab_reprots.Size = new System.Drawing.Size(792, 377);
            this.tab_reprots.TabIndex = 3;
            this.tab_reprots.Text = "Reports";
            this.tab_reprots.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.rad_allJobs);
            this.groupBox1.Controls.Add(this.rad_allUsers);
            this.groupBox1.Location = new System.Drawing.Point(652, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 365);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select report to view";
            // 
            // rad_allJobs
            // 
            this.rad_allJobs.AutoSize = true;
            this.rad_allJobs.Location = new System.Drawing.Point(7, 43);
            this.rad_allJobs.Name = "rad_allJobs";
            this.rad_allJobs.Size = new System.Drawing.Size(58, 17);
            this.rad_allJobs.TabIndex = 1;
            this.rad_allJobs.Text = "All jobs";
            this.rad_allJobs.UseVisualStyleBackColor = true;
            this.rad_allJobs.CheckedChanged += new System.EventHandler(this.rad_allJobs_CheckedChanged);
            // 
            // rad_allUsers
            // 
            this.rad_allUsers.AutoSize = true;
            this.rad_allUsers.Checked = true;
            this.rad_allUsers.Location = new System.Drawing.Point(7, 20);
            this.rad_allUsers.Name = "rad_allUsers";
            this.rad_allUsers.Size = new System.Drawing.Size(64, 17);
            this.rad_allUsers.TabIndex = 0;
            this.rad_allUsers.TabStop = true;
            this.rad_allUsers.Text = "All users";
            this.rad_allUsers.UseVisualStyleBackColor = true;
            this.rad_allUsers.CheckedChanged += new System.EventHandler(this.rad_allUsers_CheckedChanged);
            // 
            // data_report
            // 
            this.data_report.AllowUserToAddRows = false;
            this.data_report.AllowUserToDeleteRows = false;
            this.data_report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_report.Location = new System.Drawing.Point(3, 6);
            this.data_report.Name = "data_report";
            this.data_report.ReadOnly = true;
            this.data_report.Size = new System.Drawing.Size(643, 368);
            this.data_report.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.IndianRed;
            this.btn_logout.Location = new System.Drawing.Point(713, 410);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.adminDashboard_Load);
            this.Resize += new System.EventHandler(this.adminDashboard_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tab_review.ResumeLayout(false);
            this.group_manage.ResumeLayout(false);
            this.tab_items.ResumeLayout(false);
            this.box_addItem.ResumeLayout(false);
            this.box_addItem.PerformLayout();
            this.box_editItem.ResumeLayout(false);
            this.box_editItem.PerformLayout();
            this.tab_cities.ResumeLayout(false);
            this.tab_cities.PerformLayout();
            this.tab_account.ResumeLayout(false);
            this.tab_account.PerformLayout();
            this.tab_reprots.ResumeLayout(false);
            this.tab_reprots.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_review;
        private System.Windows.Forms.TabPage tab_account;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.TabPage tab_items;
        private System.Windows.Forms.ListBox list_jobs;
        private System.Windows.Forms.GroupBox box_addItem;
        private System.Windows.Forms.GroupBox box_editItem;
        private System.Windows.Forms.ListBox list_items;
        private System.Windows.Forms.ListBox group_details;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reject;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.GroupBox group_manage;
        private System.Windows.Forms.TextBox txt_editCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_editCost;
        private System.Windows.Forms.TextBox txt_editName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_newCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_newCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_newName;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_editMail;
        private System.Windows.Forms.Button btn_updateAdmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_editAdminName;
        private System.Windows.Forms.LinkLabel link_editName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_editAdminPass;
        private System.Windows.Forms.LinkLabel link_editPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_finished;
        private System.Windows.Forms.TabPage tab_reprots;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_allJobs;
        private System.Windows.Forms.RadioButton rad_allUsers;
        private System.Windows.Forms.DataGridView data_report;
        private System.Windows.Forms.CheckBox check_available;
        private System.Windows.Forms.TabPage tab_cities;
        private System.Windows.Forms.TextBox txt_cityNew;
        private System.Windows.Forms.Button btn_addCity;
        private System.Windows.Forms.Button btn_removeCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox list_cities;
    }
}