namespace HMS
{
    partial class Booking
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
            this.name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnbook = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbyes = new System.Windows.Forms.RadioButton();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.rbsingle = new System.Windows.Forms.RadioButton();
            this.rbdouble = new System.Windows.Forms.RadioButton();
            this.rbsuite = new System.Windows.Forms.RadioButton();
            this.cbcleaning = new System.Windows.Forms.CheckBox();
            this.cbLaundry = new System.Windows.Forms.CheckBox();
            this.cbFood = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(47, 100);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 13);
            this.name.TabIndex = 2;
            this.name.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtName.Location = new System.Drawing.Point(102, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Roon Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "CheckInDate :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "CheckOutDate :";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(15, 397);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(105, 41);
            this.btnback.TabIndex = 14;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnbook
            // 
            this.btnbook.Location = new System.Drawing.Point(359, 356);
            this.btnbook.Name = "btnbook";
            this.btnbook.Size = new System.Drawing.Size(123, 82);
            this.btnbook.TabIndex = 15;
            this.btnbook.Text = "Confirm!";
            this.btnbook.UseVisualStyleBackColor = true;
            this.btnbook.Click += new System.EventHandler(this.btnbook_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(102, 211);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Room Service :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Parking :";
            // 
            // rbyes
            // 
            this.rbyes.AutoSize = true;
            this.rbyes.Location = new System.Drawing.Point(6, 19);
            this.rbyes.Name = "rbyes";
            this.rbyes.Size = new System.Drawing.Size(43, 17);
            this.rbyes.TabIndex = 26;
            this.rbyes.TabStop = true;
            this.rbyes.Text = "Yes";
            this.rbyes.UseVisualStyleBackColor = true;
            // 
            // rbno
            // 
            this.rbno.AutoSize = true;
            this.rbno.Location = new System.Drawing.Point(67, 19);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(39, 17);
            this.rbno.TabIndex = 27;
            this.rbno.TabStop = true;
            this.rbno.Text = "No";
            this.rbno.UseVisualStyleBackColor = true;
            // 
            // rbsingle
            // 
            this.rbsingle.AutoSize = true;
            this.rbsingle.Location = new System.Drawing.Point(117, 144);
            this.rbsingle.Name = "rbsingle";
            this.rbsingle.Size = new System.Drawing.Size(54, 17);
            this.rbsingle.TabIndex = 28;
            this.rbsingle.TabStop = true;
            this.rbsingle.Text = "Single";
            this.rbsingle.UseVisualStyleBackColor = true;
            // 
            // rbdouble
            // 
            this.rbdouble.AutoSize = true;
            this.rbdouble.Location = new System.Drawing.Point(177, 144);
            this.rbdouble.Name = "rbdouble";
            this.rbdouble.Size = new System.Drawing.Size(59, 17);
            this.rbdouble.TabIndex = 29;
            this.rbdouble.TabStop = true;
            this.rbdouble.Text = "Double";
            this.rbdouble.UseVisualStyleBackColor = true;
            // 
            // rbsuite
            // 
            this.rbsuite.AutoSize = true;
            this.rbsuite.Location = new System.Drawing.Point(242, 144);
            this.rbsuite.Name = "rbsuite";
            this.rbsuite.Size = new System.Drawing.Size(49, 17);
            this.rbsuite.TabIndex = 30;
            this.rbsuite.TabStop = true;
            this.rbsuite.Text = "Suite";
            this.rbsuite.UseVisualStyleBackColor = true;
            // 
            // cbcleaning
            // 
            this.cbcleaning.AutoSize = true;
            this.cbcleaning.Location = new System.Drawing.Point(0, 15);
            this.cbcleaning.Name = "cbcleaning";
            this.cbcleaning.Size = new System.Drawing.Size(98, 17);
            this.cbcleaning.TabIndex = 31;
            this.cbcleaning.Text = "Room Cleaning";
            this.cbcleaning.UseVisualStyleBackColor = true;
            // 
            // cbLaundry
            // 
            this.cbLaundry.AutoSize = true;
            this.cbLaundry.Location = new System.Drawing.Point(0, 38);
            this.cbLaundry.Name = "cbLaundry";
            this.cbLaundry.Size = new System.Drawing.Size(64, 17);
            this.cbLaundry.TabIndex = 32;
            this.cbLaundry.Text = "Laundry";
            this.cbLaundry.UseVisualStyleBackColor = true;
            // 
            // cbFood
            // 
            this.cbFood.AutoSize = true;
            this.cbFood.Location = new System.Drawing.Point(70, 38);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(89, 17);
            this.cbFood.TabIndex = 33;
            this.cbFood.Text = "Food Service";
            this.cbFood.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbcleaning);
            this.groupBox1.Controls.Add(this.cbFood);
            this.groupBox1.Controls.Add(this.cbLaundry);
            this.groupBox1.Location = new System.Drawing.Point(102, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 65);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbyes);
            this.groupBox2.Controls.Add(this.rbno);
            this.groupBox2.Location = new System.Drawing.Point(102, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 41);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(686, 397);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(102, 41);
            this.btnlogout.TabIndex = 36;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbsuite);
            this.Controls.Add(this.rbdouble);
            this.Controls.Add(this.rbsingle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnbook);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.name);
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking | Customer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnbook;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbyes;
        private System.Windows.Forms.RadioButton rbno;
        private System.Windows.Forms.RadioButton rbsingle;
        private System.Windows.Forms.RadioButton rbdouble;
        private System.Windows.Forms.RadioButton rbsuite;
        private System.Windows.Forms.CheckBox cbcleaning;
        private System.Windows.Forms.CheckBox cbLaundry;
        private System.Windows.Forms.CheckBox cbFood;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnlogout;
    }
}