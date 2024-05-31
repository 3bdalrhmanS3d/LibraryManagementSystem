namespace LMS2
{
    partial class Add_Employee_frmcs
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
            this.Go_back_to_Main_btn = new System.Windows.Forms.Button();
            this.Save_Emp_btn = new System.Windows.Forms.Button();
            this.Employee_ID = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Go_back_to_Main_btn
            // 
            this.Go_back_to_Main_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Go_back_to_Main_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go_back_to_Main_btn.Location = new System.Drawing.Point(28, 632);
            this.Go_back_to_Main_btn.Name = "Go_back_to_Main_btn";
            this.Go_back_to_Main_btn.Size = new System.Drawing.Size(169, 37);
            this.Go_back_to_Main_btn.TabIndex = 0;
            this.Go_back_to_Main_btn.Text = "Previous_Page";
            this.Go_back_to_Main_btn.UseVisualStyleBackColor = false;
            // 
            // Save_Emp_btn
            // 
            this.Save_Emp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Save_Emp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Emp_btn.Location = new System.Drawing.Point(285, 423);
            this.Save_Emp_btn.Name = "Save_Emp_btn";
            this.Save_Emp_btn.Size = new System.Drawing.Size(103, 65);
            this.Save_Emp_btn.TabIndex = 1;
            this.Save_Emp_btn.Text = "Save";
            this.Save_Emp_btn.UseVisualStyleBackColor = false;
            // 
            // Employee_ID
            // 
            this.Employee_ID.AutoSize = true;
            this.Employee_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee_ID.Location = new System.Drawing.Point(57, 39);
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.Size = new System.Drawing.Size(158, 29);
            this.Employee_ID.TabIndex = 2;
            this.Employee_ID.Text = "Employee_ID";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(72, 98);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(74, 29);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(57, 167);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(120, 29);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(234, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 20);
            this.textBox3.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Employee_ID);
            this.panel1.Location = new System.Drawing.Point(86, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 263);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add a new Employee";
            // 
            // Add_Employee_frmcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Save_Emp_btn);
            this.Controls.Add(this.Go_back_to_Main_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Employee_frmcs";
            this.Text = "a";
            this.Load += new System.EventHandler(this.Add_Employee_frmcs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go_back_to_Main_btn;
        private System.Windows.Forms.Button Save_Emp_btn;
        private System.Windows.Forms.Label Employee_ID;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}