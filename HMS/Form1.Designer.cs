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
            this.WELCOME = new System.Windows.Forms.Label();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnemp = new System.Windows.Forms.Button();
            this.txtbname = new System.Windows.Forms.TextBox();
            this.txtbpass = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtadmin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WELCOME
            // 
            this.WELCOME.Location = new System.Drawing.Point(334, 61);
            this.WELCOME.Name = "WELCOME";
            this.WELCOME.Size = new System.Drawing.Size(185, 29);
            this.WELCOME.TabIndex = 2;
            this.WELCOME.Text = "Hotel Managment System | HMS";
            // 
            // btnadmin
            // 
            this.btnadmin.Location = new System.Drawing.Point(660, 121);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(118, 46);
            this.btnadmin.TabIndex = 3;
            this.btnadmin.Text = "ADMIN";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.Location = new System.Drawing.Point(46, 125);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(127, 42);
            this.btncustomer.TabIndex = 4;
            this.btncustomer.Text = "CUSTOMER";
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnemp
            // 
            this.btnemp.Location = new System.Drawing.Point(46, 256);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(127, 43);
            this.btnemp.TabIndex = 5;
            this.btnemp.Text = "Employee";
            this.btnemp.UseVisualStyleBackColor = true;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // txtbname
            // 
            this.txtbname.Location = new System.Drawing.Point(46, 332);
            this.txtbname.Name = "txtbname";
            this.txtbname.Size = new System.Drawing.Size(100, 20);
            this.txtbname.TabIndex = 6;
            this.txtbname.TextChanged += new System.EventHandler(this.txtbname_TextChanged);
            // 
            // txtbpass
            // 
            this.txtbpass.Location = new System.Drawing.Point(46, 379);
            this.txtbpass.Name = "txtbpass";
            this.txtbpass.Size = new System.Drawing.Size(100, 20);
            this.txtbpass.TabIndex = 7;
            this.txtbpass.TextChanged += new System.EventHandler(this.txtbpass_TextChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(43, 316);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(41, 13);
            this.lblname.TabIndex = 8;
            this.lblname.Text = "Name :";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(43, 363);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(59, 13);
            this.lblpass.TabIndex = 9;
            this.lblpass.Text = "Password :";
            // 
            // txtadmin
            // 
            this.txtadmin.Location = new System.Drawing.Point(660, 187);
            this.txtadmin.Name = "txtadmin";
            this.txtadmin.Size = new System.Drawing.Size(100, 20);
            this.txtadmin.TabIndex = 10;
            this.txtadmin.TextChanged += new System.EventHandler(this.txtadmin_TextChanged);
            // 
            // welcome1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.txtadmin);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtbpass);
            this.Controls.Add(this.txtbname);
            this.Controls.Add(this.btnemp);
            this.Controls.Add(this.btncustomer);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.WELCOME);
            this.Name = "welcome1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label WELCOME;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.TextBox txtbname;
        private System.Windows.Forms.TextBox txtbpass;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtadmin;
    }
}

