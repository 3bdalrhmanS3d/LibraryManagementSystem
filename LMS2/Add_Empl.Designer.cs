namespace LMS2
{
    partial class Add_Empl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Empl));
            this.Emp_ID_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Empl_name_txt = new System.Windows.Forms.TextBox();
            this.Emp_pass_txt = new System.Windows.Forms.TextBox();
            this.Emp_Email_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Emp_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.save_empl_data_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.clear_data_empl_btn = new System.Windows.Forms.Button();
            this.return_main_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Emp_ID_txt
            // 
            this.Emp_ID_txt.Location = new System.Drawing.Point(242, 33);
            this.Emp_ID_txt.Name = "Emp_ID_txt";
            this.Emp_ID_txt.Size = new System.Drawing.Size(234, 20);
            this.Emp_ID_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Empl_name_txt
            // 
            this.Empl_name_txt.Location = new System.Drawing.Point(242, 82);
            this.Empl_name_txt.Name = "Empl_name_txt";
            this.Empl_name_txt.Size = new System.Drawing.Size(234, 20);
            this.Empl_name_txt.TabIndex = 5;
            // 
            // Emp_pass_txt
            // 
            this.Emp_pass_txt.Location = new System.Drawing.Point(242, 180);
            this.Emp_pass_txt.Name = "Emp_pass_txt";
            this.Emp_pass_txt.Size = new System.Drawing.Size(234, 20);
            this.Emp_pass_txt.TabIndex = 6;
            // 
            // Emp_Email_txt
            // 
            this.Emp_Email_txt.Location = new System.Drawing.Point(242, 131);
            this.Emp_Email_txt.Name = "Emp_Email_txt";
            this.Emp_Email_txt.Size = new System.Drawing.Size(234, 20);
            this.Emp_Email_txt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(143, 338);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add photo";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Emp_pictureBox1
            // 
            this.Emp_pictureBox1.Location = new System.Drawing.Point(270, 230);
            this.Emp_pictureBox1.Name = "Emp_pictureBox1";
            this.Emp_pictureBox1.Size = new System.Drawing.Size(174, 166);
            this.Emp_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Emp_pictureBox1.TabIndex = 13;
            this.Emp_pictureBox1.TabStop = false;
            this.Emp_pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // save_empl_data_btn
            // 
            this.save_empl_data_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_empl_data_btn.Location = new System.Drawing.Point(284, 431);
            this.save_empl_data_btn.Name = "save_empl_data_btn";
            this.save_empl_data_btn.Size = new System.Drawing.Size(89, 32);
            this.save_empl_data_btn.TabIndex = 16;
            this.save_empl_data_btn.Text = "Save";
            this.save_empl_data_btn.UseVisualStyleBackColor = true;
            this.save_empl_data_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(589, 505);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // clear_data_empl_btn
            // 
            this.clear_data_empl_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_data_empl_btn.Location = new System.Drawing.Point(189, 431);
            this.clear_data_empl_btn.Name = "clear_data_empl_btn";
            this.clear_data_empl_btn.Size = new System.Drawing.Size(89, 32);
            this.clear_data_empl_btn.TabIndex = 18;
            this.clear_data_empl_btn.Text = "Clear";
            this.clear_data_empl_btn.UseVisualStyleBackColor = true;
            // 
            // return_main_btn
            // 
            this.return_main_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_main_btn.Location = new System.Drawing.Point(15, 689);
            this.return_main_btn.Name = "return_main_btn";
            this.return_main_btn.Size = new System.Drawing.Size(114, 51);
            this.return_main_btn.TabIndex = 19;
            this.return_main_btn.Text = "Main";
            this.return_main_btn.UseVisualStyleBackColor = true;
            this.return_main_btn.Click += new System.EventHandler(this.return_main_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clear_data_empl_btn);
            this.panel1.Controls.Add(this.Emp_ID_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.Emp_pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.save_empl_data_btn);
            this.panel1.Controls.Add(this.Empl_name_txt);
            this.panel1.Controls.Add(this.Emp_pass_txt);
            this.panel1.Controls.Add(this.Emp_Email_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(690, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 494);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Add_Empl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.return_main_btn);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Empl";
            this.Text = "Registeraationcs";
            this.Load += new System.EventHandler(this.Registeraationcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Emp_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Emp_ID_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Empl_name_txt;
        private System.Windows.Forms.TextBox Emp_pass_txt;
        private System.Windows.Forms.TextBox Emp_Email_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox Emp_pictureBox1;
        private System.Windows.Forms.Button save_empl_data_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button clear_data_empl_btn;
        private System.Windows.Forms.Button return_main_btn;
        private System.Windows.Forms.Panel panel1;
    }
}