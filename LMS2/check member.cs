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
    public partial class Check_mem : Form
    {
        public Check_mem()
        {
            InitializeComponent();
        }

        //private void Check_Member_Click(object sender, EventArgs e)
        //{

        //}

        private void Chk_mem_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Chk_mem_btn_Click(object sender, EventArgs e)
        {
            Entities1 DB = new Entities1();
            if (Chk_mem_txt.Text == "")
            {
                MessageBox.Show("please fill all the blanks fields", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (!string.IsNullOrWhiteSpace(Chk_mem_txt.Text) )
                {
                    int Chk_mem_int = int.Parse(Chk_mem_txt.Text);
                    var ch = DB.Members.Where(b => b.Member_ID == Chk_mem_int).FirstOrDefault();
                    if (ch != null)
                    {
                        MessageBox.Show("The member is exist","Check Member",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Main_borrow g = new Main_borrow();
                        g.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(" The person who is not present must register ", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }

                }
                else
                {
                    MessageBox.Show("empty field", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }

        private void Check_mem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            regist_Member rgs = new regist_Member();
            rgs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main new_Main = new main();
            new_Main.Show();
            this.Hide();
        }
    }
}
