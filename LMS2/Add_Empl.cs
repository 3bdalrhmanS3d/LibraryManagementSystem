using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity.Migrations;

namespace LMS2
{
    public partial class Add_Empl : Form
    {
        public Add_Empl()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registeraationcs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var img = new OpenFileDialog();
            //img.Filter = "png| *.png";
            var result = img.ShowDialog();
            if(result == DialogResult.OK)
            {
                Emp_pictureBox1.ImageLocation = img.FileName;
            }



        }

        private void save_empl_data_btn_Click(object sender, EventArgs e)
        {
            Entities1 DB = new Entities1();
            var hashpassword = BCrypt.Net.BCrypt.HashPassword(Emp_pass_txt.Text);
            // MemoryStream ma = new MemoryStream();
            
            
            if (!string.IsNullOrEmpty(Emp_ID_txt.Text)) // حقل ال ID  غير فارغ
            {
                //التاكد من ان الداتا اللي داخلة كلها ارقام 
                string test_EmpID = Emp_ID_txt.Text;
                bool check_Emp_ID = false;/* هنا بتاكد لو بيحتوى على اي حرف */
                for(var i=0;i<test_EmpID.Length;i++)
                {
                    if (test_EmpID[i]>='A'&& test_EmpID[i]<='z')
                    {
                        check_Emp_ID = true;
                        break;
                    }
                }

                if(check_Emp_ID==false) // الداتا صح وكلها حروف
                {

                    //هل الداتا دي موجودة قبل كدا ولا لا 

                    int Emp_ID_int = Convert.ToInt32(Emp_ID_txt.Text);
                    var is_found = DB.Employees.Where(x=>x.Emp_ID.Equals(Emp_ID_int)).FirstOrDefault();
                    if(is_found!=null)
                    {
                        ///////////////////////////////////////////////////////////////////////
                        /// هنتاكد من الاسم 
                        /// 
                        if(!string.IsNullOrEmpty(Empl_name_txt.Text))
                        {
                            string test_EmpNsme = Empl_name_txt.Text;
                            int wordCount = 0;
                            for (int i = 0; i < test_EmpNsme.Length; i++)
                            {
                                if (test_EmpNsme[i] == ' ')
                                {
                                    wordCount++;
                                }
                            }
                            bool check_EmpName = (wordCount == 3);
                            if (check_EmpName ) /// يختوى على 4 كلمات 
                            {

                                /////////////////////////////////////////////////////////
                                /// Email check :`(
                                if(!string.IsNullOrEmpty(Emp_Email_txt.Text)) ///////////
                                {
                                    string con_a = "@gmail.com";
                                    string Test_Emp_Email = Emp_Email_txt.Text;
                                    bool check_Emp_Email = Test_Emp_Email.Contains(con_a);
                                    if(check_Emp_Email)
                                    {
                                        ////////////////////////password check ;;;;
                                        ///
                                        if(!string.IsNullOrEmpty(Emp_pass_txt.Text))
                                        {
                                            string pass_valied = Emp_pass_txt.Text;
                                            bool check_pass_valied = pass_valied.Length >= 8;
                                            if(check_pass_valied)
                                            {
                                                //var df = Encrypt(Emp_pass_txt.Text);
                                                try
                                                {
                                                    Employee em = new Employee()
                                                    {
                                                        Emp_ID = int.Parse(Emp_ID_txt.Text),
                                                        username = Empl_name_txt.Text,
                                                        password = df,
                                                        Email = Emp_Email_txt.Text,
                                                        //picture = Emp ;
                                                    };
                                                    DB.Employees.AddOrUpdate(em);
                                                    DB.SaveChanges();
                                                    MessageBox.Show($"Add successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show(ex.Message);
                                                }

                                            }
                                            else
                                            {
                                                //
                                                string message = "A weak password must be longer than 7 characters";
                                                string title = "Error";
                                                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                            }

                                        }
                                        else
                                        {
                                            string message = "Password field  is empty";
                                            string title = "Error";
                                            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        string message = "Email is invalid\r\nPlease make sure it finishes @gmail.com ";
                                        string title = "Error";
                                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                        Emp_Email_txt.Clear();
                                    }
                                }
                                else
                                {
                                    string message = "The Employee Email field is empty";
                                    string title = "Error";
                                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                string message = "You must enter the employee's full name";
                                string title = "Error";
                                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                Empl_name_txt.Clear();
                            }
                        }
                        else
                        {
                            string message = "The Employee name field  is empty";
                            string title = "Error";
                            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                        }
                        ///////////////////////////////////////////////////////////////
                    }
                    else
                    {
                        string message = "The employee ID exists";  
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show(message, "Information message", buttons, MessageBoxIcon.Information);
                        Emp_ID_txt.Clear();
                    }

                }
                else
                {
                    string message = "The employee ID number must not contain letters";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }
            else
            {
                string message = "The Employee ID field is empty";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void return_main_btn_Click(object sender, EventArgs e)
        {
            main new_main = new main(); 
            new_main.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
