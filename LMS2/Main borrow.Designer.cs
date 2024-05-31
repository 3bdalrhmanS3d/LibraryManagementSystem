namespace LMS2
{
    partial class Main_borrow
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.book_id_txt = new System.Windows.Forms.TextBox();
            this.mem_id_txt = new System.Windows.Forms.TextBox();
            this.state_note_txt = new System.Windows.Forms.TextBox();
            this.borrow_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ret_dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.clear_btn = new System.Windows.Forms.Button();
            this.Previous_page = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 353);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Borrow date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 450);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Return date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 544);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Note";
            // 
            // book_id_txt
            // 
            this.book_id_txt.Location = new System.Drawing.Point(473, 166);
            this.book_id_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.book_id_txt.Name = "book_id_txt";
            this.book_id_txt.Size = new System.Drawing.Size(548, 22);
            this.book_id_txt.TabIndex = 5;
            // 
            // mem_id_txt
            // 
            this.mem_id_txt.Location = new System.Drawing.Point(473, 263);
            this.mem_id_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mem_id_txt.Name = "mem_id_txt";
            this.mem_id_txt.Size = new System.Drawing.Size(548, 22);
            this.mem_id_txt.TabIndex = 6;
            this.mem_id_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // state_note_txt
            // 
            this.state_note_txt.Location = new System.Drawing.Point(473, 555);
            this.state_note_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.state_note_txt.Name = "state_note_txt";
            this.state_note_txt.Size = new System.Drawing.Size(548, 22);
            this.state_note_txt.TabIndex = 9;
            // 
            // borrow_dateTimePicker1
            // 
            this.borrow_dateTimePicker1.Location = new System.Drawing.Point(532, 364);
            this.borrow_dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.borrow_dateTimePicker1.Name = "borrow_dateTimePicker1";
            this.borrow_dateTimePicker1.Size = new System.Drawing.Size(409, 22);
            this.borrow_dateTimePicker1.TabIndex = 10;
            // 
            // ret_dateTimePicker2
            // 
            this.ret_dateTimePicker2.Location = new System.Drawing.Point(532, 462);
            this.ret_dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ret_dateTimePicker2.Name = "ret_dateTimePicker2";
            this.ret_dateTimePicker2.Size = new System.Drawing.Size(409, 22);
            this.ret_dateTimePicker2.TabIndex = 11;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.Red;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(572, 654);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(153, 58);
            this.clear_btn.TabIndex = 12;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Previous_page
            // 
            this.Previous_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_page.Location = new System.Drawing.Point(16, 843);
            this.Previous_page.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Previous_page.Name = "Previous_page";
            this.Previous_page.Size = new System.Drawing.Size(241, 58);
            this.Previous_page.TabIndex = 13;
            this.Previous_page.Text = "Main";
            this.Previous_page.UseVisualStyleBackColor = true;
            this.Previous_page.Click += new System.EventHandler(this.button2_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Green;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(767, 654);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(120, 50);
            this.save_btn.TabIndex = 14;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Main_borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 916);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.Previous_page);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.ret_dateTimePicker2);
            this.Controls.Add(this.borrow_dateTimePicker1);
            this.Controls.Add(this.state_note_txt);
            this.Controls.Add(this.mem_id_txt);
            this.Controls.Add(this.book_id_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main_borrow";
            this.Text = "Main_borrow";
            this.Load += new System.EventHandler(this.Main_borrow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox book_id_txt;
        private System.Windows.Forms.TextBox mem_id_txt;
        private System.Windows.Forms.TextBox state_note_txt;
        private System.Windows.Forms.DateTimePicker borrow_dateTimePicker1;
        private System.Windows.Forms.DateTimePicker ret_dateTimePicker2;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button Previous_page;
        private System.Windows.Forms.Button save_btn;
    }
}