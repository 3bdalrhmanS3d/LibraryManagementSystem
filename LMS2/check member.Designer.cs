namespace LMS2
{
    partial class Check_mem
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
            this.ID_member = new System.Windows.Forms.Label();
            this.Chk_mem_txt = new System.Windows.Forms.TextBox();
            this.Chk_mem_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_member
            // 
            this.ID_member.AutoSize = true;
            this.ID_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_member.Location = new System.Drawing.Point(58, 152);
            this.ID_member.Name = "ID_member";
            this.ID_member.Size = new System.Drawing.Size(139, 29);
            this.ID_member.TabIndex = 0;
            this.ID_member.Text = "ID_member";
            // 
            // Chk_mem_txt
            // 
            this.Chk_mem_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_mem_txt.Location = new System.Drawing.Point(243, 152);
            this.Chk_mem_txt.Name = "Chk_mem_txt";
            this.Chk_mem_txt.Size = new System.Drawing.Size(300, 35);
            this.Chk_mem_txt.TabIndex = 1;
            this.Chk_mem_txt.TextChanged += new System.EventHandler(this.Chk_mem_txt_TextChanged);
            // 
            // Chk_mem_btn
            // 
            this.Chk_mem_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_mem_btn.Location = new System.Drawing.Point(312, 218);
            this.Chk_mem_btn.Name = "Chk_mem_btn";
            this.Chk_mem_btn.Size = new System.Drawing.Size(112, 42);
            this.Chk_mem_btn.TabIndex = 2;
            this.Chk_mem_btn.Text = "Check";
            this.Chk_mem_btn.UseVisualStyleBackColor = true;
            this.Chk_mem_btn.Click += new System.EventHandler(this.Chk_mem_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(487, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Regist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Privais";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Check_mem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 455);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Chk_mem_btn);
            this.Controls.Add(this.Chk_mem_txt);
            this.Controls.Add(this.ID_member);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Check_mem";
            this.Load += new System.EventHandler(this.Check_mem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_member;
        private System.Windows.Forms.TextBox Chk_mem_txt;
        private System.Windows.Forms.Button Chk_mem_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}