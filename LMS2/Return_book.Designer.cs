namespace LMS2
{
    partial class Return_book
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
            this.Clear_return_book_btn = new System.Windows.Forms.Button();
            this.Save_return_book_btn = new System.Windows.Forms.Button();
            this.Previous_page = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Statues_txt = new System.Windows.Forms.TextBox();
            this.Borrow_ID_txt = new System.Windows.Forms.TextBox();
            this.Return_ID_txt = new System.Windows.Forms.TextBox();
            this.Borrow_ID_label = new System.Windows.Forms.Label();
            this.Statues_label = new System.Windows.Forms.Label();
            this.Return_id_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clear_return_book_btn
            // 
            this.Clear_return_book_btn.BackColor = System.Drawing.Color.Red;
            this.Clear_return_book_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_return_book_btn.Location = new System.Drawing.Point(173, 339);
            this.Clear_return_book_btn.Name = "Clear_return_book_btn";
            this.Clear_return_book_btn.Size = new System.Drawing.Size(93, 54);
            this.Clear_return_book_btn.TabIndex = 0;
            this.Clear_return_book_btn.Text = "Clear";
            this.Clear_return_book_btn.UseVisualStyleBackColor = false;
            // 
            // Save_return_book_btn
            // 
            this.Save_return_book_btn.BackColor = System.Drawing.Color.Lime;
            this.Save_return_book_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_return_book_btn.Location = new System.Drawing.Point(276, 339);
            this.Save_return_book_btn.Name = "Save_return_book_btn";
            this.Save_return_book_btn.Size = new System.Drawing.Size(93, 54);
            this.Save_return_book_btn.TabIndex = 1;
            this.Save_return_book_btn.Text = "Save";
            this.Save_return_book_btn.UseVisualStyleBackColor = false;
            this.Save_return_book_btn.Click += new System.EventHandler(this.Save_return_book_btn_Click);
            // 
            // Previous_page
            // 
            this.Previous_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_page.Location = new System.Drawing.Point(12, 645);
            this.Previous_page.Name = "Previous_page";
            this.Previous_page.Size = new System.Drawing.Size(148, 54);
            this.Previous_page.TabIndex = 2;
            this.Previous_page.Text = "Main Page";
            this.Previous_page.UseVisualStyleBackColor = true;
            this.Previous_page.Click += new System.EventHandler(this.Previous_page_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Statues_txt);
            this.panel1.Controls.Add(this.Borrow_ID_txt);
            this.panel1.Controls.Add(this.Save_return_book_btn);
            this.panel1.Controls.Add(this.Return_ID_txt);
            this.panel1.Controls.Add(this.Clear_return_book_btn);
            this.panel1.Controls.Add(this.Borrow_ID_label);
            this.panel1.Controls.Add(this.Statues_label);
            this.panel1.Controls.Add(this.Return_id_label);
            this.panel1.Location = new System.Drawing.Point(43, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 411);
            this.panel1.TabIndex = 3;
            // 
            // Statues_txt
            // 
            this.Statues_txt.Location = new System.Drawing.Point(236, 236);
            this.Statues_txt.Name = "Statues_txt";
            this.Statues_txt.Size = new System.Drawing.Size(132, 20);
            this.Statues_txt.TabIndex = 6;
            // 
            // Borrow_ID_txt
            // 
            this.Borrow_ID_txt.Location = new System.Drawing.Point(236, 152);
            this.Borrow_ID_txt.Name = "Borrow_ID_txt";
            this.Borrow_ID_txt.Size = new System.Drawing.Size(132, 20);
            this.Borrow_ID_txt.TabIndex = 5;
            // 
            // Return_ID_txt
            // 
            this.Return_ID_txt.Location = new System.Drawing.Point(236, 68);
            this.Return_ID_txt.Name = "Return_ID_txt";
            this.Return_ID_txt.Size = new System.Drawing.Size(132, 20);
            this.Return_ID_txt.TabIndex = 4;
            // 
            // Borrow_ID_label
            // 
            this.Borrow_ID_label.AutoSize = true;
            this.Borrow_ID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrow_ID_label.Location = new System.Drawing.Point(63, 143);
            this.Borrow_ID_label.Name = "Borrow_ID_label";
            this.Borrow_ID_label.Size = new System.Drawing.Size(120, 29);
            this.Borrow_ID_label.TabIndex = 3;
            this.Borrow_ID_label.Text = "Borrow ID";
            // 
            // Statues_label
            // 
            this.Statues_label.AutoSize = true;
            this.Statues_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statues_label.Location = new System.Drawing.Point(80, 227);
            this.Statues_label.Name = "Statues_label";
            this.Statues_label.Size = new System.Drawing.Size(93, 29);
            this.Statues_label.TabIndex = 1;
            this.Statues_label.Text = "Statues";
            this.Statues_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // Return_id_label
            // 
            this.Return_id_label.AutoSize = true;
            this.Return_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_id_label.Location = new System.Drawing.Point(66, 68);
            this.Return_id_label.Name = "Return_id_label";
            this.Return_id_label.Size = new System.Drawing.Size(113, 29);
            this.Return_id_label.TabIndex = 0;
            this.Return_id_label.Text = "Return ID";
            // 
            // Return_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Previous_page);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return_book";
            this.Text = "Return_book";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clear_return_book_btn;
        private System.Windows.Forms.Button Save_return_book_btn;
        private System.Windows.Forms.Button Previous_page;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Statues_txt;
        private System.Windows.Forms.TextBox Borrow_ID_txt;
        private System.Windows.Forms.TextBox Return_ID_txt;
        private System.Windows.Forms.Label Borrow_ID_label;
        private System.Windows.Forms.Label Statues_label;
        private System.Windows.Forms.Label Return_id_label;
    }
}