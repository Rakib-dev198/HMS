namespace HMS
{
    partial class Receipt
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
            this.coupon = new System.Windows.Forms.Label();
            this.txtCoupon = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnreceipt = new System.Windows.Forms.Button();
            this.rbyes = new System.Windows.Forms.RadioButton();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.richbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpayment = new System.Windows.Forms.Label();
            this.btncard = new System.Windows.Forms.Button();
            this.lblcard = new System.Windows.Forms.Label();
            this.txtcard = new System.Windows.Forms.TextBox();
            this.lblcash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coupon
            // 
            this.coupon.AutoSize = true;
            this.coupon.Location = new System.Drawing.Point(21, 293);
            this.coupon.Name = "coupon";
            this.coupon.Size = new System.Drawing.Size(104, 13);
            this.coupon.TabIndex = 1;
            this.coupon.Text = "Discount Available ?";
            // 
            // txtCoupon
            // 
            this.txtCoupon.Enabled = false;
            this.txtCoupon.Location = new System.Drawing.Point(105, 325);
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Size = new System.Drawing.Size(100, 20);
            this.txtCoupon.TabIndex = 3;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(21, 328);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(78, 13);
            this.pass.TabIndex = 4;
            this.pass.Text = "Enter Coupon :";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(13, 415);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // btnreceipt
            // 
            this.btnreceipt.Location = new System.Drawing.Point(339, 328);
            this.btnreceipt.Name = "btnreceipt";
            this.btnreceipt.Size = new System.Drawing.Size(121, 65);
            this.btnreceipt.TabIndex = 6;
            this.btnreceipt.Text = "Generate Reciept";
            this.btnreceipt.UseVisualStyleBackColor = true;
            this.btnreceipt.Click += new System.EventHandler(this.btnreceipt_Click);
            // 
            // rbyes
            // 
            this.rbyes.AutoSize = true;
            this.rbyes.Location = new System.Drawing.Point(135, 291);
            this.rbyes.Name = "rbyes";
            this.rbyes.Size = new System.Drawing.Size(43, 17);
            this.rbyes.TabIndex = 7;
            this.rbyes.TabStop = true;
            this.rbyes.Text = "Yes";
            this.rbyes.UseVisualStyleBackColor = true;
            this.rbyes.CheckedChanged += new System.EventHandler(this.rbyes_CheckedChanged);
            this.rbyes.Click += new System.EventHandler(this.rbyes_Click);
            // 
            // rbno
            // 
            this.rbno.AutoSize = true;
            this.rbno.Location = new System.Drawing.Point(184, 291);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(39, 17);
            this.rbno.TabIndex = 8;
            this.rbno.TabStop = true;
            this.rbno.Text = "No";
            this.rbno.UseVisualStyleBackColor = true;
            // 
            // richbox
            // 
            this.richbox.Location = new System.Drawing.Point(524, 163);
            this.richbox.Name = "richbox";
            this.richbox.Size = new System.Drawing.Size(241, 110);
            this.richbox.TabIndex = 9;
            this.richbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Complain? fill this form : (Help us Improve Our System)";
            // 
            // lblpayment
            // 
            this.lblpayment.AutoSize = true;
            this.lblpayment.Location = new System.Drawing.Point(33, 23);
            this.lblpayment.Name = "lblpayment";
            this.lblpayment.Size = new System.Drawing.Size(157, 13);
            this.lblpayment.TabIndex = 11;
            this.lblpayment.Text = "Choose Your Payment Method :";
            // 
            // btncard
            // 
            this.btncard.Location = new System.Drawing.Point(36, 125);
            this.btncard.Name = "btncard";
            this.btncard.Size = new System.Drawing.Size(75, 23);
            this.btncard.TabIndex = 12;
            this.btncard.Text = "Pay Now";
            this.btncard.UseVisualStyleBackColor = true;
            this.btncard.Click += new System.EventHandler(this.btncard_Click);
            // 
            // lblcard
            // 
            this.lblcard.AutoSize = true;
            this.lblcard.Location = new System.Drawing.Point(33, 61);
            this.lblcard.Name = "lblcard";
            this.lblcard.Size = new System.Drawing.Size(125, 13);
            this.lblcard.TabIndex = 13;
            this.lblcard.Text = "Enter Your Card Number:";
            // 
            // txtcard
            // 
            this.txtcard.Location = new System.Drawing.Point(36, 92);
            this.txtcard.Name = "txtcard";
            this.txtcard.Size = new System.Drawing.Size(100, 20);
            this.txtcard.TabIndex = 14;
            this.txtcard.TextChanged += new System.EventHandler(this.txtcard_TextChanged);
            // 
            // lblcash
            // 
            this.lblcash.AutoSize = true;
            this.lblcash.Location = new System.Drawing.Point(322, 405);
            this.lblcash.Name = "lblcash";
            this.lblcash.Size = new System.Drawing.Size(155, 13);
            this.lblcash.TabIndex = 15;
            this.lblcash.Text = "If You Want to Pay With Cash :";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcash);
            this.Controls.Add(this.txtcard);
            this.Controls.Add(this.lblcard);
            this.Controls.Add(this.btncard);
            this.Controls.Add(this.lblpayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richbox);
            this.Controls.Add(this.rbno);
            this.Controls.Add(this.rbyes);
            this.Controls.Add(this.btnreceipt);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.txtCoupon);
            this.Controls.Add(this.coupon);
            this.Name = "Receipt";
            this.Text = "Payment | Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label coupon;
        private System.Windows.Forms.TextBox txtCoupon;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnreceipt;
        private System.Windows.Forms.RadioButton rbyes;
        private System.Windows.Forms.RadioButton rbno;
        private System.Windows.Forms.RichTextBox richbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpayment;
        private System.Windows.Forms.Button btncard;
        private System.Windows.Forms.Label lblcard;
        private System.Windows.Forms.TextBox txtcard;
        private System.Windows.Forms.Label lblcash;
    }
}