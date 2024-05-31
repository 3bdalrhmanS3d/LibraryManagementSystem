using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    regist r=new regist();
        //    r.Show();
        //    this.Hide();

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Entities1 DB = new Entities1();
            
            if(!string.IsNullOrEmpty(Email_txt.Text))// not
            {
                if(!string.IsNullOrEmpty(Pass_txt.Text))
                {
                    var test_user = DB.Employees.Where(x=>x.Email.Equals(Email_txt.Text) && x.password.Equals(Pass_txt.Text) ).FirstOrDefault();

                    if(test_user != null)
                    {
                        main new_main = new main();
                        new_main.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        string message = "A user with this data does not exist";
                        string title = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error );
                        if (result == DialogResult.OK)
                        {
                            Email_txt.Clear();
                            Pass_txt.Clear();
                        }
                        else
                        {
                            Email_txt.Clear();
                            Pass_txt.Clear();
                        }
                    }
                }
                else
                {
                    string message = "The Password is empty field";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        Email_txt.Clear();
                        Pass_txt.Clear();
                    }
                    else
                    {
                        Email_txt.Clear();
                        Pass_txt.Clear();
                    }
                }
            }
            else
            {
                // empty
                string message = "The ID is empty field";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    Email_txt.Clear();
                }
                else
                {
                    Email_txt.Clear();
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Pass_txt.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Pass_txt.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
