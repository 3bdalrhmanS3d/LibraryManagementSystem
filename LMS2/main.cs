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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Addbook addbook = new Addbook();
            addbook.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            delete_book d1 = new delete_book();
            d1.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            regist_Member a = new regist_Member();
            a.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Main_borrow new_mainborroe = new Main_borrow();
            new_mainborroe.Show();
            
            this.Hide();
        }

        private void Add_Auther_Click(object sender, EventArgs e)
        {
            AddAutherfrm new_auther = new AddAutherfrm();
            new_auther.Show();
            this.Hide();

        }

        private void Add_publisher_Click(object sender, EventArgs e)
        {
           AddPublisher_frm new_pub = new AddPublisher_frm();
            new_pub.Show();
            this.Hide();
        }

        private void Add_Subject_Click(object sender, EventArgs e)
        {
            Add_Subject_frm new_sub= new Add_Subject_frm();
            new_sub.Show();
            this.Hide();
        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            Add_Empl add_Empl = new Add_Empl();
            add_Empl.Show();
            this.Hide();
        }

        private void Return_book_btn_Click(object sender, EventArgs e)
        {
            Return_book v = new Return_book();
            
            v.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gridviewofstaticbook t=new Gridviewofstaticbook();
            t.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Datagridviewofstaticborrow t = new Datagridviewofstaticborrow();
            t.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            Entities1 DB = new Entities1();
          //  Datagridviewofstaticsubject ob= new Datagridviewofstaticsubject();
            var count=DB.Subject_table.Count();
            label3.Text=count.ToString();

            var count1 = DB.Book_table.Count();
            label2.Text = count1.ToString();

            var count2 = DB.Borrows.Count();
            label5.Text = count2.ToString();

            var count3 = DB.Members.Count();
            label7.Text = count3.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Datagridviewofstaticmember t = new Datagridviewofstaticmember();
            t.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Datagridviewofstaticsubject t = new Datagridviewofstaticsubject();
            t.Show();
            this.Hide();
        }

        private void Add_Record_History_btn_Click(object sender, EventArgs e)
        {
            Record_History_frm newRecord_History = new Record_History_frm();
            newRecord_History.Show();
            this.Hide();
        }
    }
}