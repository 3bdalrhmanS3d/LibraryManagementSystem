namespace LMS2
{
    partial class Addbook
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.upload_image_btn = new System.Windows.Forms.Button();
            this.Check_Pub_btn = new System.Windows.Forms.Button();
            this.Check_Subject_btn = new System.Windows.Forms.Button();
            this.Book_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Save_Data_btn = new System.Windows.Forms.Button();
            this.Descrption_txt = new System.Windows.Forms.TextBox();
            this.Publicsher_ID_txt = new System.Windows.Forms.TextBox();
            this.Edition_txt = new System.Windows.Forms.TextBox();
            this.Book_Title_txt = new System.Windows.Forms.TextBox();
            this.Book_ID_txt = new System.Windows.Forms.TextBox();
            this.Auther_name_txt = new System.Windows.Forms.TextBox();
            this.Book_Title_lab = new System.Windows.Forms.Label();
            this.ID_Book_lab = new System.Windows.Forms.Label();
            this.Subject_ID_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Publisher_ID_lab = new System.Windows.Forms.Label();
            this.Auther_name_lab = new System.Windows.Forms.Label();
            this.publiction_Date_lab = new System.Windows.Forms.Label();
            this.Subject_lab = new System.Windows.Forms.Label();
            this.Previous_Page_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit_book_btn = new System.Windows.Forms.Button();
            this.Delete_book_btn = new System.Windows.Forms.Button();
            this.Publication_date_book_txt = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edition";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Publication_date_book_txt);
            this.panel1.Controls.Add(this.upload_image_btn);
            this.panel1.Controls.Add(this.Check_Pub_btn);
            this.panel1.Controls.Add(this.Check_Subject_btn);
            this.panel1.Controls.Add(this.Book_pictureBox1);
            this.panel1.Controls.Add(this.Clear_btn);
            this.panel1.Controls.Add(this.Save_Data_btn);
            this.panel1.Controls.Add(this.Descrption_txt);
            this.panel1.Controls.Add(this.Publicsher_ID_txt);
            this.panel1.Controls.Add(this.Edition_txt);
            this.panel1.Controls.Add(this.Book_Title_txt);
            this.panel1.Controls.Add(this.Book_ID_txt);
            this.panel1.Controls.Add(this.Auther_name_txt);
            this.panel1.Controls.Add(this.Book_Title_lab);
            this.panel1.Controls.Add(this.ID_Book_lab);
            this.panel1.Controls.Add(this.Subject_ID_txt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Publisher_ID_lab);
            this.panel1.Controls.Add(this.Auther_name_lab);
            this.panel1.Controls.Add(this.publiction_Date_lab);
            this.panel1.Controls.Add(this.Subject_lab);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(758, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 713);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // upload_image_btn
            // 
            this.upload_image_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_image_btn.Location = new System.Drawing.Point(249, 417);
            this.upload_image_btn.Name = "upload_image_btn";
            this.upload_image_btn.Size = new System.Drawing.Size(140, 32);
            this.upload_image_btn.TabIndex = 24;
            this.upload_image_btn.Text = "upload image";
            this.upload_image_btn.UseVisualStyleBackColor = true;
            // 
            // Check_Pub_btn
            // 
            this.Check_Pub_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_Pub_btn.Location = new System.Drawing.Point(434, 326);
            this.Check_Pub_btn.Name = "Check_Pub_btn";
            this.Check_Pub_btn.Size = new System.Drawing.Size(53, 22);
            this.Check_Pub_btn.TabIndex = 25;
            this.Check_Pub_btn.Text = "Check";
            this.Check_Pub_btn.UseVisualStyleBackColor = true;
            this.Check_Pub_btn.Click += new System.EventHandler(this.Check_Pub_btn_Click);
            // 
            // Check_Subject_btn
            // 
            this.Check_Subject_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_Subject_btn.Location = new System.Drawing.Point(434, 123);
            this.Check_Subject_btn.Name = "Check_Subject_btn";
            this.Check_Subject_btn.Size = new System.Drawing.Size(53, 22);
            this.Check_Subject_btn.TabIndex = 23;
            this.Check_Subject_btn.Text = "Check";
            this.Check_Subject_btn.UseVisualStyleBackColor = true;
            this.Check_Subject_btn.Click += new System.EventHandler(this.Check_Subject_btn_Click);
            // 
            // Book_pictureBox1
            // 
            this.Book_pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Book_pictureBox1.Location = new System.Drawing.Point(9, 417);
            this.Book_pictureBox1.Name = "Book_pictureBox1";
            this.Book_pictureBox1.Size = new System.Drawing.Size(230, 282);
            this.Book_pictureBox1.TabIndex = 23;
            this.Book_pictureBox1.TabStop = false;
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.Red;
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.Location = new System.Drawing.Point(371, 631);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(116, 61);
            this.Clear_btn.TabIndex = 7;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Save_Data_btn
            // 
            this.Save_Data_btn.BackColor = System.Drawing.Color.Green;
            this.Save_Data_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Data_btn.ForeColor = System.Drawing.Color.Black;
            this.Save_Data_btn.Location = new System.Drawing.Point(371, 564);
            this.Save_Data_btn.Name = "Save_Data_btn";
            this.Save_Data_btn.Size = new System.Drawing.Size(116, 61);
            this.Save_Data_btn.TabIndex = 4;
            this.Save_Data_btn.Text = "Save";
            this.Save_Data_btn.UseVisualStyleBackColor = false;
            this.Save_Data_btn.Click += new System.EventHandler(this.Save_Data_btn_Click);
            // 
            // Descrption_txt
            // 
            this.Descrption_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descrption_txt.Location = new System.Drawing.Point(200, 377);
            this.Descrption_txt.Name = "Descrption_txt";
            this.Descrption_txt.Size = new System.Drawing.Size(217, 22);
            this.Descrption_txt.TabIndex = 21;
            // 
            // Publicsher_ID_txt
            // 
            this.Publicsher_ID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicsher_ID_txt.Location = new System.Drawing.Point(200, 326);
            this.Publicsher_ID_txt.Name = "Publicsher_ID_txt";
            this.Publicsher_ID_txt.Size = new System.Drawing.Size(217, 22);
            this.Publicsher_ID_txt.TabIndex = 19;
            // 
            // Edition_txt
            // 
            this.Edition_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edition_txt.Location = new System.Drawing.Point(200, 173);
            this.Edition_txt.Name = "Edition_txt";
            this.Edition_txt.Size = new System.Drawing.Size(217, 22);
            this.Edition_txt.TabIndex = 17;
            // 
            // Book_Title_txt
            // 
            this.Book_Title_txt.Location = new System.Drawing.Point(200, 73);
            this.Book_Title_txt.Name = "Book_Title_txt";
            this.Book_Title_txt.Size = new System.Drawing.Size(217, 20);
            this.Book_Title_txt.TabIndex = 26;
            // 
            // Book_ID_txt
            // 
            this.Book_ID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_ID_txt.Location = new System.Drawing.Point(200, 22);
            this.Book_ID_txt.Name = "Book_ID_txt";
            this.Book_ID_txt.Size = new System.Drawing.Size(217, 22);
            this.Book_ID_txt.TabIndex = 15;
            this.Book_ID_txt.TextChanged += new System.EventHandler(this.Book_ID_txt_TextChanged);
            // 
            // Auther_name_txt
            // 
            this.Auther_name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auther_name_txt.Location = new System.Drawing.Point(200, 275);
            this.Auther_name_txt.Name = "Auther_name_txt";
            this.Auther_name_txt.Size = new System.Drawing.Size(217, 22);
            this.Auther_name_txt.TabIndex = 14;
            this.Auther_name_txt.TextChanged += new System.EventHandler(this.Auther_name_txt_TextChanged);
            // 
            // Book_Title_lab
            // 
            this.Book_Title_lab.AutoSize = true;
            this.Book_Title_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_Title_lab.Location = new System.Drawing.Point(47, 73);
            this.Book_Title_lab.Name = "Book_Title_lab";
            this.Book_Title_lab.Size = new System.Drawing.Size(103, 24);
            this.Book_Title_lab.TabIndex = 12;
            this.Book_Title_lab.Text = "Book Title";
            // 
            // ID_Book_lab
            // 
            this.ID_Book_lab.AutoSize = true;
            this.ID_Book_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Book_lab.Location = new System.Drawing.Point(57, 22);
            this.ID_Book_lab.Name = "ID_Book_lab";
            this.ID_Book_lab.Size = new System.Drawing.Size(82, 24);
            this.ID_Book_lab.TabIndex = 11;
            this.ID_Book_lab.Text = "Book ID";
            // 
            // Subject_ID_txt
            // 
            this.Subject_ID_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_ID_txt.Location = new System.Drawing.Point(200, 122);
            this.Subject_ID_txt.Name = "Subject_ID_txt";
            this.Subject_ID_txt.Size = new System.Drawing.Size(217, 22);
            this.Subject_ID_txt.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Descraption";
            // 
            // Publisher_ID_lab
            // 
            this.Publisher_ID_lab.AutoSize = true;
            this.Publisher_ID_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publisher_ID_lab.Location = new System.Drawing.Point(37, 328);
            this.Publisher_ID_lab.Name = "Publisher_ID_lab";
            this.Publisher_ID_lab.Size = new System.Drawing.Size(123, 24);
            this.Publisher_ID_lab.TabIndex = 5;
            this.Publisher_ID_lab.Text = "Publisher ID";
            // 
            // Auther_name_lab
            // 
            this.Auther_name_lab.AutoSize = true;
            this.Auther_name_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auther_name_lab.Location = new System.Drawing.Point(35, 277);
            this.Auther_name_lab.Name = "Auther_name_lab";
            this.Auther_name_lab.Size = new System.Drawing.Size(133, 24);
            this.Auther_name_lab.TabIndex = 4;
            this.Auther_name_lab.Text = "Auther Name";
            // 
            // publiction_Date_lab
            // 
            this.publiction_Date_lab.AutoSize = true;
            this.publiction_Date_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publiction_Date_lab.Location = new System.Drawing.Point(21, 226);
            this.publiction_Date_lab.Name = "publiction_Date_lab";
            this.publiction_Date_lab.Size = new System.Drawing.Size(149, 24);
            this.publiction_Date_lab.TabIndex = 2;
            this.publiction_Date_lab.Text = "publiction Date";
            // 
            // Subject_lab
            // 
            this.Subject_lab.AutoSize = true;
            this.Subject_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_lab.Location = new System.Drawing.Point(46, 124);
            this.Subject_lab.Name = "Subject_lab";
            this.Subject_lab.Size = new System.Drawing.Size(105, 24);
            this.Subject_lab.TabIndex = 1;
            this.Subject_lab.Text = "Subject ID";
            // 
            // Previous_Page_btn
            // 
            this.Previous_Page_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_Page_btn.Location = new System.Drawing.Point(12, 688);
            this.Previous_Page_btn.Name = "Previous_Page_btn";
            this.Previous_Page_btn.Size = new System.Drawing.Size(157, 46);
            this.Previous_Page_btn.TabIndex = 8;
            this.Previous_Page_btn.Text = "Previous Page";
            this.Previous_Page_btn.UseVisualStyleBackColor = true;
            this.Previous_Page_btn.Click += new System.EventHandler(this.Previous_Page_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 646);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Edit_book_btn
            // 
            this.Edit_book_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Edit_book_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_book_btn.Location = new System.Drawing.Point(539, 669);
            this.Edit_book_btn.Name = "Edit_book_btn";
            this.Edit_book_btn.Size = new System.Drawing.Size(135, 68);
            this.Edit_book_btn.TabIndex = 28;
            this.Edit_book_btn.Text = "Edit";
            this.Edit_book_btn.UseVisualStyleBackColor = false;
            this.Edit_book_btn.Click += new System.EventHandler(this.Edit_book_btn_Click);
            // 
            // Delete_book_btn
            // 
            this.Delete_book_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_book_btn.Location = new System.Drawing.Point(403, 669);
            this.Delete_book_btn.Name = "Delete_book_btn";
            this.Delete_book_btn.Size = new System.Drawing.Size(113, 68);
            this.Delete_book_btn.TabIndex = 29;
            this.Delete_book_btn.Text = "Delete";
            this.Delete_book_btn.UseVisualStyleBackColor = true;
            this.Delete_book_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Publication_date_book_txt
            // 
            this.Publication_date_book_txt.Location = new System.Drawing.Point(202, 229);
            this.Publication_date_book_txt.Name = "Publication_date_book_txt";
            this.Publication_date_book_txt.Size = new System.Drawing.Size(214, 20);
            this.Publication_date_book_txt.TabIndex = 27;
            // 
            // Addbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 742);
            this.Controls.Add(this.Delete_book_btn);
            this.Controls.Add(this.Edit_book_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Previous_Page_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addbook";
            this.Load += new System.EventHandler(this.Addbook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Subject_ID_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Publisher_ID_lab;
        private System.Windows.Forms.Label Auther_name_lab;
        private System.Windows.Forms.Label publiction_Date_lab;
        private System.Windows.Forms.Label Subject_lab;
        private System.Windows.Forms.TextBox Descrption_txt;
        private System.Windows.Forms.TextBox Publicsher_ID_txt;
        private System.Windows.Forms.TextBox Edition_txt;
        private System.Windows.Forms.TextBox Book_Title_txt;
        private System.Windows.Forms.TextBox Book_ID_txt;
        private System.Windows.Forms.TextBox Auther_name_txt;
        private System.Windows.Forms.Label Book_Title_lab;
        private System.Windows.Forms.Label ID_Book_lab;
        private System.Windows.Forms.Button upload_image_btn;
        private System.Windows.Forms.PictureBox Book_pictureBox1;
        private System.Windows.Forms.Button Save_Data_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Previous_Page_btn;
        private System.Windows.Forms.Button Check_Pub_btn;
        private System.Windows.Forms.Button Check_Subject_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Edit_book_btn;
        private System.Windows.Forms.Button Delete_book_btn;
        private System.Windows.Forms.DateTimePicker Publication_date_book_txt;
    }
}