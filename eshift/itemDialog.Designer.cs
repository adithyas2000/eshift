namespace eshift
{
    partial class itemDialog
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
            this.combo_item = new System.Windows.Forms.ComboBox();
            this.num_items = new System.Windows.Forms.NumericUpDown();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_items)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_item
            // 
            this.combo_item.FormattingEnabled = true;
            this.combo_item.Location = new System.Drawing.Point(12, 12);
            this.combo_item.Name = "combo_item";
            this.combo_item.Size = new System.Drawing.Size(372, 21);
            this.combo_item.TabIndex = 0;
            // 
            // num_items
            // 
            this.num_items.Location = new System.Drawing.Point(390, 13);
            this.num_items.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_items.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_items.Name = "num_items";
            this.num_items.Size = new System.Drawing.Size(52, 20);
            this.num_items.TabIndex = 1;
            this.num_items.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(448, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(528, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // itemDialog
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(615, 46);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.num_items);
            this.Controls.Add(this.combo_item);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "itemDialog";
            this.Text = "Add item";
            this.Load += new System.EventHandler(this.itemDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_item;
        private System.Windows.Forms.NumericUpDown num_items;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
    }
}