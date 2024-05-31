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
    public partial class Main_borrow : Form
    {
        public Main_borrow()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_borrow_Load(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Entities1 DB = new Entities1();
            if (!string.IsNullOrEmpty(book_id_txt.Text))
            {
                string bookIdTest = book_id_txt.Text.ToString();
                bool check_bookIdTest = false;
                for (int i = 0; i < bookIdTest.Length; i++)
                {
                    if (bookIdTest[i] >= 'A' && bookIdTest[i] <= 'z')
                    {
                        check_bookIdTest = true;
                        break;
                    }
                }

                if (check_bookIdTest)
                {
                    string message = "The book ID must not contain any letters";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        book_id_txt.Clear();

                    }
                    else
                    {
                        book_id_txt.Clear();

                    }
                }
                else
                {
                    int int_bookID = int.Parse(book_id_txt.Text);
                    var int_bookID_test = DB.Book_table.Where(x => x.Book_id.Equals(int_bookID)).FirstOrDefault();

                    if (int_bookID_test == null)
                    {
                        string message = "Not found, Add Book? ";
                        string title = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            book_id_txt.Clear();
                            Addbook new_addbook = new Addbook();
                            new_addbook.Show();
                        }
                        else
                        {
                            book_id_txt.Clear();
                        }
                    }
                    else
                    {
                        // هنا قيمة ال
                        // book id 
                        // صحيحة 
                        //////////////////////////////////////////////////////////////////////////////////////////////////

                        if (!string.IsNullOrEmpty(mem_id_txt.Text))// مش فاضي
                        {
                            string memIdTest = mem_id_txt.Text.ToString();
                            bool check_memIdTest = false;
                            for (int i = 0; i < memIdTest.Length; i++)
                            {
                                if (memIdTest[i] >= 'A' && memIdTest[i] <= 'z')
                                {
                                    check_memIdTest = true;
                                    break;
                                }
                            }

                            if (check_memIdTest)// datatype check
                            {
                                string message = "The Member ID must not contain any letters";
                                string title = "Error";
                                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                if (result == DialogResult.OK)
                                {
                                    mem_id_txt.Clear();
                                }
                                else
                                {
                                    mem_id_txt.Clear();
                                }
                            }
                            else// correct data type
                            {
                                int int_memID = int.Parse(mem_id_txt.Text);
                                var int_memID_test = DB.Members.Where(x => x.Member_ID.Equals(int_memID)).FirstOrDefault();

                                if (int_memID_test == null) //// not fount
                                {
                                    string message = "Not found, Add Member? ";

                                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                    DialogResult result = MessageBox.Show(message, "Information message", buttons, MessageBoxIcon.Information);
                                    if (result == DialogResult.OK)
                                    {
                                        mem_id_txt.Clear();
                                        Check_mem new_check_Mem = new Check_mem();
                                        new_check_Mem.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        mem_id_txt.Clear();

                                    }
                                }
                                else
                                {
                                    //found
                                    /////////////////////////////////////////////////////////////////////////////////////////////////
                                    if (!string.IsNullOrEmpty(borrow_dateTimePicker1.Text) && !string.IsNullOrEmpty(ret_dateTimePicker2.Text))
                                    {
                                        var d1 = DateTime.Parse(borrow_dateTimePicker1.Value.ToString());
                                        var d2 = DateTime.Parse(ret_dateTimePicker2.Value.ToString());

                                        if (d1 >= d2)
                                        {
                                            string message = "The borrowing date cannot be less than the return date";
                                            string title = "Error";
                                            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);

                                        }
                                        else
                                        {

                                            // all the data correct. 
                                            Borrow new_borrow = new Borrow()
                                            {
                                                book_id = Convert.ToInt32(book_id_txt.Text),
                                                mem_id = Convert.ToInt32(mem_id_txt.Text),
                                                issue_date = DateTime.Parse(borrow_dateTimePicker1.Value.ToString()),
                                                return_date = DateTime.Parse(ret_dateTimePicker2.Value.ToString()),
                                                state = state_note_txt.Text,

                                            };

                                            DB.Borrows.Add(new_borrow);
                                            DB.SaveChanges();


                                            string message = "Borrow successfully!";
                                            string title = "Information message";
                                            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                                            if (result == DialogResult.OK)
                                            {
                                                book_id_txt.Clear();
                                                mem_id_txt.Clear();
                                                state_note_txt.Clear();
                                            }
                                            else
                                            {
                                                book_id_txt.Clear();
                                                mem_id_txt.Clear();
                                                state_note_txt.Clear();
                                            }

                                        }
                                    }
                                    else
                                    {
                                        // empty
                                        string message = "The borrowing date or the return date is empty";
                                        string title = "Error";
                                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                    }


                                }
                            }
                        }
                        else
                        {
                            // empty
                            string message = "Error";
                            string title = "The Member ID is empty field";
                            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                            if (result == DialogResult.OK)
                            {
                                mem_id_txt.Clear();

                            }
                            else
                            {
                                mem_id_txt.Clear();

                            }

                        }
                        //
                    }
                }
            }
            else
            {
                string message = "The Book ID is empty field";
                string title = "ُError";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    book_id_txt.Clear();
                    //this.Close();
                }
                else
                {
                    book_id_txt.Clear();
                    //this.Close();
                }
            }



        }
        private void button2_Click(object sender, EventArgs e)
        {
            main new_Main = new main();
            new_Main.Show();
            this.Hide();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            book_id_txt.Clear();
            mem_id_txt.Clear();
            state_note_txt.Clear();
        }
    }
    
}

/*
 * LMSEntities7 DB = new LMSEntities7();
            
            if (book_id_txt.Text =="" || mem_id_txt.Text == "" || borrow_dateTimePicker1.Text == "" || ret_dateTimePicker2.Text == "")
            {
                MessageBox.Show("please fill the blank fields", "erroe message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(book_id_txt.Text) == false)
                {
                    //  int id=int.Parse(book_id_txt.Text);
                    var x = int.Parse(book_id_txt.Text);
                    var user = DB.Book_table.Where(b => b.Book_ID == x ).FirstOrDefault();
                    if (user == null)
                    {
                        MessageBox.Show("please check the ID book", "erroe message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if(DateTime.Parse(borrow_dateTimePicker1.Text) >= DateTime.Parse(ret_dateTimePicker2.Text))
                {
                    MessageBox.Show("please check the Return Date", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                Borrow k = new Borrow()
                    {
                        book_id = Convert.ToInt32(book_id_txt.Text),
                        mem_id = Convert.ToInt32(mem_id_txt.Text),
                        issue_date = DateTime.Parse(borrow_dateTimePicker1.Text),
                        return_date = DateTime.Parse(ret_dateTimePicker2.Text),
                        state = state_note_txt.Text,

                    };

                DB.Borrows.Add(k);
                DB.SaveChanges();
                MessageBox.Show( $"Borrow successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main l = new main();
                l.Show();
                

            }
 */
