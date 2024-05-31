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
    public partial class regist_Member : Form
    {
        public regist_Member()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Entities1 DB = new Entities1();
            ///MemoryStream ma = new MemoryStream();
            if ( string.IsNullOrEmpty(ID_Member_txt.Text)  || string.IsNullOrEmpty(name_mem_txt.Text) || string.IsNullOrEmpty(email_mem_txt.Text ) )
            {
                string message = "Please fill the blank fields";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    
                }
                else
                {
                   
                }
            }
            else
            {
                string testMemberID = ID_Member_txt.Text;
                bool check_testMemberID = false; 
                for(var i =0; i < testMemberID.Length; i++)
                {
                    if (testMemberID[i] == 'A' && testMemberID[i] == 'z')
                    {
                        check_testMemberID = true;
                        break;
                    }
                }

                if (check_testMemberID)
                {
                    MessageBox.Show("This ID must not contain any letters", "erroe message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int int_testMemberID = int.Parse(ID_Member_txt.Text);
                    var int_testMemberID_ISFound = DB.Members.Where(x =>x.Member_ID == int_testMemberID ).FirstOrDefault();

                    if(int_testMemberID_ISFound != null)
                    {
                        MessageBox.Show("This ID exists", "Erroe message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ID_Member_txt.Clear();
                    }
                    else
                    {
                        Member new_member = new Member()
                        {
                            Member_ID = int.Parse(ID_Member_txt.Text),
                            Name = (name_mem_txt.Text),
                            Email = email_mem_txt.Text,
                        };

                        DB.Members.Add(new_member);
                        DB.SaveChanges();
                        MessageBox.Show($"Add successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                
            }

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _return_Main_btn_Click(object sender, EventArgs e)
        {
            main new_main = new main();
            new_main.ShowDialog();
            this.Close();

        }

        private void clear_data_member_btm_Click(object sender, EventArgs e)
        {
            email_mem_txt.Clear();
            ID_Member_txt.Clear();
            name_mem_txt.Clear();
            
        }  
    }
}
