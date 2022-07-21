namespace eshift
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.rad_admin = new System.Windows.Forms.RadioButton();
            this.rad_user = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(12, 147);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 45);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(93, 147);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(75, 45);
            this.btn_signup.TabIndex = 1;
            this.btn_signup.Text = "SIGN-UP";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // rad_admin
            // 
            this.rad_admin.AutoSize = true;
            this.rad_admin.Location = new System.Drawing.Point(12, 12);
            this.rad_admin.Name = "rad_admin";
            this.rad_admin.Size = new System.Drawing.Size(54, 17);
            this.rad_admin.TabIndex = 2;
            this.rad_admin.TabStop = true;
            this.rad_admin.Text = "Admin";
            this.rad_admin.UseVisualStyleBackColor = true;
            this.rad_admin.CheckedChanged += new System.EventHandler(this.rad_admin_CheckedChanged);
            // 
            // rad_user
            // 
            this.rad_user.AutoSize = true;
            this.rad_user.Location = new System.Drawing.Point(12, 35);
            this.rad_user.Name = "rad_user";
            this.rad_user.Size = new System.Drawing.Size(47, 17);
            this.rad_user.TabIndex = 3;
            this.rad_user.TabStop = true;
            this.rad_user.Text = "User";
            this.rad_user.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(178, 204);
            this.Controls.Add(this.rad_user);
            this.Controls.Add(this.rad_admin);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.btn_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Welcome";
            this.Text = " Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.RadioButton rad_admin;
        private System.Windows.Forms.RadioButton rad_user;
    }
}

