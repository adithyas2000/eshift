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
            this.tab_account = new System.Windows.Forms.TabPage();
            this.btn_logout = new System.Windows.Forms.Button();
            this.tab_items = new System.Windows.Forms.TabPage();
            this.list_jobs = new System.Windows.Forms.ListBox();
            this.group_details = new System.Windows.Forms.GroupBox();
            this.list_items = new System.Windows.Forms.ListBox();
            this.box_editItem = new System.Windows.Forms.GroupBox();
            this.box_addItem = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tab_review.SuspendLayout();
            this.tab_items.SuspendLayout();
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
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tab_review
            // 
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
            // tab_account
            // 
            this.tab_account.Location = new System.Drawing.Point(4, 22);
            this.tab_account.Name = "tab_account";
            this.tab_account.Padding = new System.Windows.Forms.Padding(3);
            this.tab_account.Size = new System.Drawing.Size(792, 377);
            this.tab_account.TabIndex = 1;
            this.tab_account.Text = "Manage account";
            this.tab_account.UseVisualStyleBackColor = true;
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
            // list_jobs
            // 
            this.list_jobs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_jobs.FormattingEnabled = true;
            this.list_jobs.Location = new System.Drawing.Point(8, 8);
            this.list_jobs.Name = "list_jobs";
            this.list_jobs.Size = new System.Drawing.Size(359, 355);
            this.list_jobs.TabIndex = 0;
            // 
            // group_details
            // 
            this.group_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.group_details.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.group_details.Location = new System.Drawing.Point(373, 8);
            this.group_details.Name = "group_details";
            this.group_details.Size = new System.Drawing.Size(411, 355);
            this.group_details.TabIndex = 1;
            this.group_details.TabStop = false;
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
            // 
            // box_editItem
            // 
            this.box_editItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.box_editItem.Location = new System.Drawing.Point(400, 8);
            this.box_editItem.Name = "box_editItem";
            this.box_editItem.Size = new System.Drawing.Size(384, 212);
            this.box_editItem.TabIndex = 1;
            this.box_editItem.TabStop = false;
            this.box_editItem.Text = "Edit Item";
            // 
            // box_addItem
            // 
            this.box_addItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_addItem.Location = new System.Drawing.Point(8, 226);
            this.box_addItem.Name = "box_addItem";
            this.box_addItem.Size = new System.Drawing.Size(776, 148);
            this.box_addItem.TabIndex = 2;
            this.box_addItem.TabStop = false;
            this.box_addItem.Text = "Add Item";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_review;
        private System.Windows.Forms.TabPage tab_account;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.TabPage tab_items;
        private System.Windows.Forms.GroupBox group_details;
        private System.Windows.Forms.ListBox list_jobs;
        private System.Windows.Forms.GroupBox box_addItem;
        private System.Windows.Forms.GroupBox box_editItem;
        private System.Windows.Forms.ListBox list_items;
    }
}