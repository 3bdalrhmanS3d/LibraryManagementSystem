namespace LMS2
{
    partial class AddAutherfrm
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
            this.Groub_Auther_data_panel = new System.Windows.Forms.Panel();
            this.Bio_Auther_txt = new System.Windows.Forms.TextBox();
            this.Email_Auther_txt = new System.Windows.Forms.TextBox();
            this.Auther_name_txt = new System.Windows.Forms.TextBox();
            this.Auther_ID_txt = new System.Windows.Forms.TextBox();
            this.Save_data_Auther_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.biography_lab = new System.Windows.Forms.Label();
            this.Email_lab = new System.Windows.Forms.Label();
            this.Auther_Name_lab = new System.Windows.Forms.Label();
            this.AutherID_lab = new System.Windows.Forms.Label();
            this.Previous_Page_btn = new System.Windows.Forms.Button();
            this.Edit_Auther_data_btn = new System.Windows.Forms.Button();
            this.Delete_Ather_data = new System.Windows.Forms.Button();
            this.Groub_Auther_data_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Groub_Auther_data_panel
            // 
            this.Groub_Auther_data_panel.Controls.Add(this.Delete_Ather_data);
            this.Groub_Auther_data_panel.Controls.Add(this.Edit_Auther_data_btn);
            this.Groub_Auther_data_panel.Controls.Add(this.Bio_Auther_txt);
            this.Groub_Auther_data_panel.Controls.Add(this.Email_Auther_txt);
            this.Groub_Auther_data_panel.Controls.Add(this.Auther_name_txt);
            this.Groub_Auther_data_panel.Controls.Add(this.Auther_ID_txt);
            this.Groub_Auther_data_panel.Controls.Add(this.Save_data_Auther_btn);
            this.Groub_Auther_data_panel.Controls.Add(this.Clear_btn);
            this.Groub_Auther_data_panel.Controls.Add(this.biography_lab);
            this.Groub_Auther_data_panel.Controls.Add(this.Email_lab);
            this.Groub_Auther_data_panel.Controls.Add(this.Auther_Name_lab);
            this.Groub_Auther_data_panel.Controls.Add(this.AutherID_lab);
            this.Groub_Auther_data_panel.Location = new System.Drawing.Point(43, 89);
            this.Groub_Auther_data_panel.Name = "Groub_Auther_data_panel";
            this.Groub_Auther_data_panel.Size = new System.Drawing.Size(541, 387);
            this.Groub_Auther_data_panel.TabIndex = 0;
            this.Groub_Auther_data_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Groub_Auther_data_panel_Paint);
            // 
            // Bio_Auther_txt
            // 
            this.Bio_Auther_txt.Location = new System.Drawing.Point(204, 224);
            this.Bio_Auther_txt.Name = "Bio_Auther_txt";
            this.Bio_Auther_txt.Size = new System.Drawing.Size(310, 20);
            this.Bio_Auther_txt.TabIndex = 9;
            // 
            // Email_Auther_txt
            // 
            this.Email_Auther_txt.Location = new System.Drawing.Point(204, 179);
            this.Email_Auther_txt.Name = "Email_Auther_txt";
            this.Email_Auther_txt.Size = new System.Drawing.Size(310, 20);
            this.Email_Auther_txt.TabIndex = 8;
            // 
            // Auther_name_txt
            // 
            this.Auther_name_txt.Location = new System.Drawing.Point(204, 134);
            this.Auther_name_txt.Name = "Auther_name_txt";
            this.Auther_name_txt.Size = new System.Drawing.Size(310, 20);
            this.Auther_name_txt.TabIndex = 7;
            // 
            // Auther_ID_txt
            // 
            this.Auther_ID_txt.Location = new System.Drawing.Point(204, 89);
            this.Auther_ID_txt.Name = "Auther_ID_txt";
            this.Auther_ID_txt.Size = new System.Drawing.Size(310, 20);
            this.Auther_ID_txt.TabIndex = 6;
            // 
            // Save_data_Auther_btn
            // 
            this.Save_data_Auther_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_data_Auther_btn.Location = new System.Drawing.Point(413, 314);
            this.Save_data_Auther_btn.Name = "Save_data_Auther_btn";
            this.Save_data_Auther_btn.Size = new System.Drawing.Size(88, 38);
            this.Save_data_Auther_btn.TabIndex = 5;
            this.Save_data_Auther_btn.Text = "Save";
            this.Save_data_Auther_btn.UseVisualStyleBackColor = true;
            this.Save_data_Auther_btn.Click += new System.EventHandler(this.Save_data_Auther_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.Location = new System.Drawing.Point(291, 314);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(94, 38);
            this.Clear_btn.TabIndex = 4;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // biography_lab
            // 
            this.biography_lab.AutoSize = true;
            this.biography_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biography_lab.Location = new System.Drawing.Point(40, 220);
            this.biography_lab.Name = "biography_lab";
            this.biography_lab.Size = new System.Drawing.Size(122, 29);
            this.biography_lab.TabIndex = 3;
            this.biography_lab.Text = "Biography";
            // 
            // Email_lab
            // 
            this.Email_lab.AutoSize = true;
            this.Email_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lab.Location = new System.Drawing.Point(64, 175);
            this.Email_lab.Name = "Email_lab";
            this.Email_lab.Size = new System.Drawing.Size(74, 29);
            this.Email_lab.TabIndex = 2;
            this.Email_lab.Text = "Email";
            // 
            // Auther_Name_lab
            // 
            this.Auther_Name_lab.AutoSize = true;
            this.Auther_Name_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auther_Name_lab.Location = new System.Drawing.Point(25, 130);
            this.Auther_Name_lab.Name = "Auther_Name_lab";
            this.Auther_Name_lab.Size = new System.Drawing.Size(153, 29);
            this.Auther_Name_lab.TabIndex = 1;
            this.Auther_Name_lab.Text = "Auther Name";
            // 
            // AutherID_lab
            // 
            this.AutherID_lab.AutoSize = true;
            this.AutherID_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutherID_lab.Location = new System.Drawing.Point(46, 85);
            this.AutherID_lab.Name = "AutherID_lab";
            this.AutherID_lab.Size = new System.Drawing.Size(111, 29);
            this.AutherID_lab.TabIndex = 0;
            this.AutherID_lab.Text = "Auther ID";
            // 
            // Previous_Page_btn
            // 
            this.Previous_Page_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_Page_btn.Location = new System.Drawing.Point(12, 702);
            this.Previous_Page_btn.Name = "Previous_Page_btn";
            this.Previous_Page_btn.Size = new System.Drawing.Size(149, 38);
            this.Previous_Page_btn.TabIndex = 6;
            this.Previous_Page_btn.Text = "Previous Page";
            this.Previous_Page_btn.UseVisualStyleBackColor = true;
            this.Previous_Page_btn.Click += new System.EventHandler(this.Previous_Page_btn_Click);
            // 
            // Edit_Auther_data_btn
            // 
            this.Edit_Auther_data_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Auther_data_btn.Location = new System.Drawing.Point(32, 314);
            this.Edit_Auther_data_btn.Name = "Edit_Auther_data_btn";
            this.Edit_Auther_data_btn.Size = new System.Drawing.Size(98, 38);
            this.Edit_Auther_data_btn.TabIndex = 10;
            this.Edit_Auther_data_btn.Text = "Edit";
            this.Edit_Auther_data_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_Ather_data
            // 
            this.Delete_Ather_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Ather_data.Location = new System.Drawing.Point(158, 314);
            this.Delete_Ather_data.Name = "Delete_Ather_data";
            this.Delete_Ather_data.Size = new System.Drawing.Size(105, 38);
            this.Delete_Ather_data.TabIndex = 11;
            this.Delete_Ather_data.Text = "Delete";
            this.Delete_Ather_data.UseVisualStyleBackColor = true;
            // 
            // AddAutherfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 757);
            this.Controls.Add(this.Previous_Page_btn);
            this.Controls.Add(this.Groub_Auther_data_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAutherfrm";
            this.Text = "Auther";
            this.Groub_Auther_data_panel.ResumeLayout(false);
            this.Groub_Auther_data_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Groub_Auther_data_panel;
        private System.Windows.Forms.Label biography_lab;
        private System.Windows.Forms.Label Email_lab;
        private System.Windows.Forms.Label Auther_Name_lab;
        private System.Windows.Forms.Label AutherID_lab;
        private System.Windows.Forms.Button Save_data_Auther_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Previous_Page_btn;
        private System.Windows.Forms.TextBox Bio_Auther_txt;
        private System.Windows.Forms.TextBox Email_Auther_txt;
        private System.Windows.Forms.TextBox Auther_name_txt;
        private System.Windows.Forms.TextBox Auther_ID_txt;
        private System.Windows.Forms.Button Delete_Ather_data;
        private System.Windows.Forms.Button Edit_Auther_data_btn;
    }
}