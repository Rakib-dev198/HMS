namespace HMS
{
    partial class complain
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnsolved = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(439, 33);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(149, 34);
            this.btnshow.TabIndex = 1;
            this.btnshow.Text = "Show Complain";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnsolved
            // 
            this.btnsolved.Location = new System.Drawing.Point(439, 200);
            this.btnsolved.Name = "btnsolved";
            this.btnsolved.Size = new System.Drawing.Size(136, 34);
            this.btnsolved.TabIndex = 2;
            this.btnsolved.Text = "Solved";
            this.btnsolved.UseVisualStyleBackColor = true;
            this.btnsolved.Click += new System.EventHandler(this.btnsolved_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(30, 401);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(90, 34);
            this.btnback.TabIndex = 3;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // complain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsolved);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.dataGridView1);
            this.Name = "complain";
            this.Text = "Complain Box | Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnsolved;
        private System.Windows.Forms.Button btnback;
    }
}