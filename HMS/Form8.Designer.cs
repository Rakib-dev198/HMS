namespace HMS
{
    partial class tables
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
            this.customer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.checkout = new System.Windows.Forms.Button();
            this.emp = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtrole = new System.Windows.Forms.TextBox();
            this.txtattendence = new System.Windows.Forms.TextBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(12, 315);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(106, 38);
            this.customer.TabIndex = 0;
            this.customer.Text = "Show Customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(473, 297);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(263, 344);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(77, 23);
            this.update.TabIndex = 3;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(263, 315);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(77, 23);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(12, 415);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // checkout
            // 
            this.checkout.Location = new System.Drawing.Point(124, 315);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(106, 38);
            this.checkout.TabIndex = 6;
            this.checkout.Text = "Checkout";
            this.checkout.UseVisualStyleBackColor = true;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // emp
            // 
            this.emp.Location = new System.Drawing.Point(12, 359);
            this.emp.Name = "emp";
            this.emp.Size = new System.Drawing.Size(106, 39);
            this.emp.TabIndex = 7;
            this.emp.Text = "Show Employee";
            this.emp.UseVisualStyleBackColor = true;
            this.emp.Click += new System.EventHandler(this.emp_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(643, 47);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 8;
            // 
            // txtrole
            // 
            this.txtrole.Location = new System.Drawing.Point(643, 92);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(100, 20);
            this.txtrole.TabIndex = 9;
            // 
            // txtattendence
            // 
            this.txtattendence.Location = new System.Drawing.Point(643, 136);
            this.txtattendence.Name = "txtattendence";
            this.txtattendence.Size = new System.Drawing.Size(100, 20);
            this.txtattendence.TabIndex = 10;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(643, 172);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(100, 20);
            this.txtstatus.TabIndex = 11;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(643, 215);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(100, 20);
            this.txtsalary.TabIndex = 12;
            // 
            // tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtattendence);
            this.Controls.Add(this.txtrole);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.emp);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.customer);
            this.Name = "tables";
            this.Text = "Table | Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button checkout;
        private System.Windows.Forms.Button emp;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtrole;
        private System.Windows.Forms.TextBox txtattendence;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtsalary;
    }
}