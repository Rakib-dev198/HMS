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
            this.SuspendLayout();
            // 
            // coupon
            // 
            this.coupon.AutoSize = true;
            this.coupon.Location = new System.Drawing.Point(6, 194);
            this.coupon.Name = "coupon";
            this.coupon.Size = new System.Drawing.Size(104, 13);
            this.coupon.TabIndex = 1;
            this.coupon.Text = "Discount Available ?";
            // 
            // txtCoupon
            // 
            this.txtCoupon.Enabled = false;
            this.txtCoupon.Location = new System.Drawing.Point(116, 222);
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Size = new System.Drawing.Size(100, 20);
            this.txtCoupon.TabIndex = 3;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(32, 225);
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
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnreceipt
            // 
            this.btnreceipt.Location = new System.Drawing.Point(339, 352);
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
            this.rbyes.Location = new System.Drawing.Point(116, 192);
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
            this.rbno.Location = new System.Drawing.Point(165, 192);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(39, 17);
            this.rbno.TabIndex = 8;
            this.rbno.TabStop = true;
            this.rbno.Text = "No";
            this.rbno.UseVisualStyleBackColor = true;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbno);
            this.Controls.Add(this.rbyes);
            this.Controls.Add(this.btnreceipt);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.txtCoupon);
            this.Controls.Add(this.coupon);
            this.Name = "Receipt";
            this.Text = "Receipt";
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
    }
}