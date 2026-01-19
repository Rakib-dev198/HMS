namespace HMS
{
    partial class welcome1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WELCOME = new System.Windows.Forms.Label();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // WELCOME
            // 
            this.WELCOME.Location = new System.Drawing.Point(338, 48);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(96, 29);
            this.WELCOME.TabIndex = 2;
            this.WELCOME.Text = "WELCOME";
            // 
            // btnadmin
            // 
            this.btnadmin.Location = new System.Drawing.Point(189, 194);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(97, 23);
            this.btnadmin.TabIndex = 3;
            this.btnadmin.Text = "ADMIN";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.Location = new System.Drawing.Point(458, 194);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(102, 23);
            this.btncustomer.TabIndex = 4;
            this.btncustomer.Text = "CUSTOMER";
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnemp
            // 
            this.btnemp.Location = new System.Drawing.Point(331, 263);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(75, 23);
            this.btnemp.TabIndex = 5;
            this.btnemp.Text = "Employee";
            this.btnemp.UseVisualStyleBackColor = true;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // welcome1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.btnemp);
            this.Controls.Add(this.btncustomer);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.WELCOME);
            this.Name = "welcome1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Label WELCOME;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnemp;
    }
}

