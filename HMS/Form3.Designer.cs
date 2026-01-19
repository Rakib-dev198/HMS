namespace HMS
{
    partial class register
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblmob = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.btnreg = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.cbmale = new System.Windows.Forms.CheckBox();
            this.cbfemale = new System.Windows.Forms.CheckBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblcpass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtCpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(203, 55);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(24, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID :";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(183, 97);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 13);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "NAME :";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(182, 136);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(45, 13);
            this.lblemail.TabIndex = 2;
            this.lblemail.Text = "EMAIL :";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(168, 167);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(59, 13);
            this.lblgender.TabIndex = 3;
            this.lblgender.Text = "GENDER :";
            // 
            // lblmob
            // 
            this.lblmob.AutoSize = true;
            this.lblmob.Location = new System.Drawing.Point(174, 200);
            this.lblmob.Name = "lblmob";
            this.lblmob.Size = new System.Drawing.Size(53, 13);
            this.lblmob.TabIndex = 4;
            this.lblmob.Text = "MOBILE :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(253, 55);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(253, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(253, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(253, 200);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(100, 20);
            this.txtMobile.TabIndex = 9;
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(633, 340);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(113, 62);
            this.btnreg.TabIndex = 11;
            this.btnreg.Text = "REGISTER !";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(13, 415);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // cbmale
            // 
            this.cbmale.AutoSize = true;
            this.cbmale.Location = new System.Drawing.Point(253, 167);
            this.cbmale.Name = "cbmale";
            this.cbmale.Size = new System.Drawing.Size(49, 17);
            this.cbmale.TabIndex = 13;
            this.cbmale.Text = "Male";
            this.cbmale.UseVisualStyleBackColor = true;
            this.cbmale.CheckedChanged += new System.EventHandler(this.cbmale_CheckedChanged);
            // 
            // cbfemale
            // 
            this.cbfemale.AutoSize = true;
            this.cbfemale.Location = new System.Drawing.Point(308, 167);
            this.cbfemale.Name = "cbfemale";
            this.cbfemale.Size = new System.Drawing.Size(60, 17);
            this.cbfemale.TabIndex = 14;
            this.cbfemale.Text = "Female";
            this.cbfemale.UseVisualStyleBackColor = true;
            this.cbfemale.CheckedChanged += new System.EventHandler(this.cbfemale_CheckedChanged);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(168, 249);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(59, 13);
            this.lblpass.TabIndex = 15;
            this.lblpass.Text = "Password :";
            // 
            // lblcpass
            // 
            this.lblcpass.AutoSize = true;
            this.lblcpass.Location = new System.Drawing.Point(130, 289);
            this.lblcpass.Name = "lblcpass";
            this.lblcpass.Size = new System.Drawing.Size(97, 13);
            this.lblcpass.TabIndex = 16;
            this.lblcpass.Text = "Confirm Password :";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(253, 249);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 17;
            // 
            // txtCpass
            // 
            this.txtCpass.Location = new System.Drawing.Point(253, 289);
            this.txtCpass.Name = "txtCpass";
            this.txtCpass.Size = new System.Drawing.Size(100, 20);
            this.txtCpass.TabIndex = 18;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.txtCpass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblcpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.cbfemale);
            this.Controls.Add(this.cbmale);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblmob);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblid);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblmob;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.CheckBox cbmale;
        private System.Windows.Forms.CheckBox cbfemale;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblcpass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtCpass;
    }
}