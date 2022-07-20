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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_review = new System.Windows.Forms.TabPage();
            this.group_details = new System.Windows.Forms.ListBox();
            this.list_jobs = new System.Windows.Forms.ListBox();
            this.tab_items = new System.Windows.Forms.TabPage();
            this.box_addItem = new System.Windows.Forms.GroupBox();
            this.box_editItem = new System.Windows.Forms.GroupBox();
            this.list_items = new System.Windows.Forms.ListBox();
            this.tab_account = new System.Windows.Forms.TabPage();
            this.testBtn1 = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_reject = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.group_manage = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_editName = new System.Windows.Forms.TextBox();
            this.txt_editCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_editCode = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_newCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_newCost = new System.Windows.Forms.TextBox();
            this.txt_newName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_review.SuspendLayout();
            this.tab_items.SuspendLayout();
            this.box_addItem.SuspendLayout();
            this.box_editItem.SuspendLayout();
            this.tab_account.SuspendLayout();
            this.group_manage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_review);
            this.tabControl1.Controls.Add(this.tab_items);
            this.tabControl1.Controls.Add(this.tab_account);
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
            this.box_addItem.Controls.Add(this.button1);
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
            // box_editItem
            // 
            this.box_editItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            // tab_account
            // 
            this.tab_account.Controls.Add(this.testBtn1);
            this.tab_account.Location = new System.Drawing.Point(4, 22);
            this.tab_account.Name = "tab_account";
            this.tab_account.Padding = new System.Windows.Forms.Padding(3);
            this.tab_account.Size = new System.Drawing.Size(792, 377);
            this.tab_account.TabIndex = 1;
            this.tab_account.Text = "Manage account";
            this.tab_account.UseVisualStyleBackColor = true;
            // 
            // testBtn1
            // 
            this.testBtn1.Location = new System.Drawing.Point(37, 35);
            this.testBtn1.Name = "testBtn1";
            this.testBtn1.Size = new System.Drawing.Size(75, 23);
            this.testBtn1.TabIndex = 0;
            this.testBtn1.Text = "testFunc1";
            this.testBtn1.UseVisualStyleBackColor = true;
            this.testBtn1.Click += new System.EventHandler(this.testBtn1_Click);
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
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(168, 19);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(83, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete record";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // group_manage
            // 
            this.group_manage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.group_manage.Controls.Add(this.btn_accept);
            this.group_manage.Controls.Add(this.btn_delete);
            this.group_manage.Controls.Add(this.btn_reject);
            this.group_manage.Location = new System.Drawing.Point(8, 200);
            this.group_manage.Name = "group_manage";
            this.group_manage.Size = new System.Drawing.Size(359, 163);
            this.group_manage.TabIndex = 5;
            this.group_manage.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unit Cost";
            // 
            // txt_editName
            // 
            this.txt_editName.Enabled = false;
            this.txt_editName.Location = new System.Drawing.Point(67, 43);
            this.txt_editName.Name = "txt_editName";
            this.txt_editName.Size = new System.Drawing.Size(100, 20);
            this.txt_editName.TabIndex = 2;
            // 
            // txt_editCost
            // 
            this.txt_editCost.Enabled = false;
            this.txt_editCost.Location = new System.Drawing.Point(67, 69);
            this.txt_editCost.Name = "txt_editCost";
            this.txt_editCost.Size = new System.Drawing.Size(100, 20);
            this.txt_editCost.TabIndex = 3;
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
            // txt_editCode
            // 
            this.txt_editCode.Enabled = false;
            this.txt_editCode.Location = new System.Drawing.Point(67, 17);
            this.txt_editCode.Name = "txt_editCode";
            this.txt_editCode.Size = new System.Drawing.Size(100, 20);
            this.txt_editCode.TabIndex = 6;
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(9, 183);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
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
            // txt_newCost
            // 
            this.txt_newCost.Location = new System.Drawing.Point(67, 77);
            this.txt_newCost.Name = "txt_newCost";
            this.txt_newCost.Size = new System.Drawing.Size(100, 20);
            this.txt_newCost.TabIndex = 11;
            // 
            // txt_newName
            // 
            this.txt_newName.Location = new System.Drawing.Point(67, 51);
            this.txt_newName.Name = "txt_newName";
            this.txt_newName.Size = new System.Drawing.Size(100, 20);
            this.txt_newName.TabIndex = 10;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // adminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.tabControl1);
            this.Name = "adminDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.adminDashboard_Load);
            this.Resize += new System.EventHandler(this.adminDashboard_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tab_review.ResumeLayout(false);
            this.tab_items.ResumeLayout(false);
            this.box_addItem.ResumeLayout(false);
            this.box_addItem.PerformLayout();
            this.box_editItem.ResumeLayout(false);
            this.box_editItem.PerformLayout();
            this.tab_account.ResumeLayout(false);
            this.group_manage.ResumeLayout(false);
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
        private System.Windows.Forms.Button testBtn1;
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
        private System.Windows.Forms.Button button1;
    }
}