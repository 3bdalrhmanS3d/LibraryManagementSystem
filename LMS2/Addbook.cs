using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace LMS2
{
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // خلصان بالكامل الاتشيك ع الاقسام ف المكتبة
        private void Check_Subject_btn_Click(object sender, EventArgs e)
        {

            Entities1 DB = new Entities1();
            if (!string.IsNullOrWhiteSpace(Subject_ID_txt.Text))
            {
                var ch = DB.Subject_table.Where(b => b.SUB_id == Subject_ID_txt.Text).FirstOrDefault();
                if (ch == null)
                {
                    string title = "The Subject is not exist";
                    string message = " Add Subject ";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        Subject_ID_txt.Clear();
                        Add_Subject_frm add_Subject_Frm = new Add_Subject_frm();
                        add_Subject_Frm.Show();

                    }
                    else
                    {
                        // Do something
                        Subject_ID_txt.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("The Subject is exist  ", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show(" Fill this field ", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        // خلصان بالكامل الاتشيك ع الالكاتب 
        //private void Check_Auther_btn_Click(object sender, EventArgs e)
        //{
        //    LMSEntities6 DB = new LMSEntities6();
        //    if (!string.IsNullOrWhiteSpace(Auther_name_txt.Text))
        //    {
        //        var x = (Auther_name_txt.Text);
        //        var ch = DB.auther_tables.Where(b => b.name == x).FirstOrDefault();

        //        if (ch == null)
        //        {
        //            string title = "The Auther is not exist";
        //            string message = "Add Auther";
        //            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
        //            DialogResult result = MessageBox.Show(message, title, buttons);
        //            if (result == DialogResult.OK)
        //            {
        //                Auther_name_txt.Clear();
        //                AddAutherfrm addAutherfrm = new AddAutherfrm();
        //                addAutherfrm.Show();

        //            }
        //            else
        //            {
        //                // Do something
        //                Auther_name_txt.Clear();
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("The Auther is exist  ", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        }

        //    }
        //    else
        //    {
        //        MessageBox.Show(" Fill this field ", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void Check_Pub_btn_Click(object sender, EventArgs e)
        {
            Entities1 DB = new Entities1();
            if (!string.IsNullOrWhiteSpace(Publicsher_ID_txt.Text))
            {
                int x = int.Parse(Publicsher_ID_txt.Text);
                var ch = DB.Publishers.Where(b => b.Publisher_ID == x).FirstOrDefault();

                if (ch == null)
                {
                    string title = "The Publisher is not exist";
                    string message = "Add Publisher";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        Publicsher_ID_txt.Clear();
                        AddPublisher_frm addPublisher_Frm = new AddPublisher_frm();
                        addPublisher_Frm.Show();

                    }
                    else
                    {
                        // Do something
                        Publicsher_ID_txt.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("The Publisher is exist  ", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show(" Fill this field ", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Book_ID_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Data_btn_Click(object sender, EventArgs e)
        {
            Entities1 DB = new Entities1();


            if( !string.IsNullOrEmpty(Book_ID_txt.Text) ) /// مش فارغ 
            {
                string test_book_id = Book_ID_txt.Text;
                bool check_test_book_id = false;
                for (int i = 0; i < test_book_id.Length; i++)
                {
                    if (test_book_id[i] >= 'A' && test_book_id[i] <= 'z')
                    {
                        check_test_book_id = true;
                        break;
                    }
                }

                if ( check_test_book_id == false ) // data type coreect 
                {
                    /// 
                    int bookId_Int = int.Parse(Book_ID_txt.Text);
                    var test_book_id_is_found = DB.Book_table.Where(x=>x.Book_id.Equals(bookId_Int)).FirstOrDefault();

                    if(test_book_id_is_found == null )//found
                    {
                        if(!string.IsNullOrEmpty(Book_Title_txt.Text))
                        {
                            ///////////////////////////////////////////////////////////////////////////////
                            if (!string.IsNullOrEmpty(Subject_ID_txt.Text)) /// مش فارغ 
                            {

                                var test_sub_ID_test = DB.Subject_table.Where(b => b.SUB_id.Equals(Subject_ID_txt.Text)).FirstOrDefault();
                                if (test_sub_ID_test == null)
                                {
                                    string title = "Information Message";
                                    string message = "The Subject is not exist, Add Subject ?";
                                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                                    if (result == DialogResult.OK)
                                    {
                                        Subject_ID_txt.Clear();
                                        Add_Subject_frm add_Subject_Frm = new Add_Subject_frm();
                                        add_Subject_Frm.Show();
                                    }
                                    else
                                    {
                                        Subject_ID_txt.Clear();
                                    }
                                }
                                else
                                {
                                    ////////////////////////////////////////////////////////////
                                    if(!string.IsNullOrEmpty(Edition_txt.Text)) /// مش فارغ 
                                    {
                                        string edition_test = Edition_txt.Text;
                                        bool check_edition_test = false;
                                        for(int i =0; i<Edition_txt.Text.Length; i++)
                                        {
                                            if (edition_test[i] >= 'A' && edition_test[i] <= 'z')
                                            {
                                                check_edition_test = true;
                                                break;
                                            }

                                        }

                                        if( check_edition_test == false) // data type coreect 
                                        {
                                            /// 
                                            /////////////////
                                            if(!string.IsNullOrEmpty(Publication_date_book_txt.Text))
                                            {
                                                var d1 = DateTime.Parse(Publication_date_book_txt.Value.ToString());
                                                if(d1 < DateTime.Now)
                                                {
                                                    ///////////
                                                    ///
                                                    if(!string.IsNullOrEmpty(Auther_name_txt.Text))
                                                    {
                                                        if(!string.IsNullOrEmpty(Publicsher_ID_txt.Text))
                                                        {
                                                            string Publicsher_ID_txt_test = Publicsher_ID_txt.Text;
                                                            bool int_Publicsher_ID_txt_test = false;

                                                            for(int i =0; i < Publicsher_ID_txt_test.Length; i++)
                                                            {
                                                                if(Publicsher_ID_txt_test[i] >= 'A' && Publicsher_ID_txt_test[i] <= 'z')
                                                                {
                                                                    int_Publicsher_ID_txt_test = true; break;
                                                                }                                                          
                                                            }

                                                            if (int_Publicsher_ID_txt_test == false)
                                                            {
                                                                int int_Publicsher_ID = Convert.ToInt32(Publicsher_ID_txt.Text);
                                                                var Publicsher_ID_test_is_found = DB.Publishers.Where(b => b.Publisher_ID.Equals(int_Publicsher_ID)).FirstOrDefault();
                                                                if (Publicsher_ID_test_is_found == null)
                                                                {
                                                                    string title = "Information Message";
                                                                    string message = "The Publisher is not exist, Add Subject ?";
                                                                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                                                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                                                                    if (result == DialogResult.OK)
                                                                    {
                                                                        Publicsher_ID_txt.Clear();
                                                                        AddPublisher_frm new_publisher = new AddPublisher_frm();
                                                                        new_publisher.Show();
                                                                    }
                                                                    else
                                                                    {
                                                                        Publicsher_ID_txt.Clear();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if(!string.IsNullOrEmpty(Descrption_txt.Text))
                                                                    {
                                                                    
                                                                        try
                                                                        {
                                                                            Book_table new_book = new Book_table()
                                                                            {
                                                                                Book_id = Convert.ToInt32(Book_ID_txt.Text),
                                                                                Title = Book_Title_txt.Text,
                                                                                Edition = Convert.ToInt32(Edition_txt.Text),
                                                                                Subject = Subject_ID_txt.Text,
                                                                                publisher_ID = Convert.ToInt32(Publicsher_ID_txt_test),
                                                                                Publication_date = DateTime.Parse(Publication_date_book_txt.Value.ToString()),
                                                                                Descrption = Descrption_txt.Text,
                                                                                Auther_name = Auther_name_txt.Text,

                                                                            };
                                                                            DB.Book_table.Add(new_book);
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
                                                                        string message = "The Descraption field is empty";
                                                                        string title = "Error";
                                                                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                                                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);

                                                                    }
                                                                }

                                                            }
                                                            else
                                                            {
                                                                string message = "The Publisher ID can not be text ";
                                                                string title = "Error";
                                                                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                                                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                                                if (result == DialogResult.OK)
                                                                {
                                                                    Publicsher_ID_txt.Clear();
                                                                }
                                                                else
                                                                {
                                                                    Publicsher_ID_txt.Clear();
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            string message = "The Publisher ID field is empty ";
                                                            string title = "Error";
                                                            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                                            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        string message = "The Auther name field Empty ";
                                                        string title = "Error Message";
                                                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                                    }
                                                }
                                                else
                                                {
                                                    string message = "The Publication date cannot be less than the today date ";
                                                    string title = "Error Message";
                                                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                                    
                                                }

                                            }
                                            

                                        }
                                        else // 
                                        {
                                            string message = "The Edition can not be text ";
                                            string title = "Error Message";
                                            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                        }
                                    }
                                    else // فارغ 
                                    {
                                        string message = "The Edition field is empty ";
                                        string title = "Error Message";
                                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else // فارغ 
                            {
                                string message = "The Subject ID is empty field";
                                string title = "Error Message";
                                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                            }


                        }
                        else
                        {
                            string message = "The Title can not be empty field";
                            string title = "Error Message";
                            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                            if(result == DialogResult.OK)
                            {

                            }
                            else
                            {

                            }
                        }
                    }
                    else // not found
                    {
                        string message = "Not found, Add Book? ";
                        string title = "Error Message";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            Book_ID_txt.Clear();
                            Addbook new_addbook = new Addbook();
                            new_addbook.Show();
                        }
                        else
                        {
                            Book_ID_txt.Clear();
                        }
                    }


                }
                else // 
                {
                    string message = "Book ID must be numbers only";
                    string title = "Error Message";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if(result == DialogResult.OK )
                    {
                        Book_ID_txt.Clear();
                    }
                    else
                    {
                        Book_ID_txt.Clear();
                    }
                }
            }
            else // فارغ 
            {
                string message = "The Book ID is empty field";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                if( result == DialogResult.OK )
                {

                }
                else
                {

                }
                
            }


        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Auther_name_txt.Clear();
            Book_ID_txt.Clear();
            Book_Title_txt.Clear();
            Descrption_txt.Clear();
            Edition_txt.Clear();
            Publication_date_book_txt.Text = null;
            Publicsher_ID_txt.Clear();
            Subject_ID_txt.Clear();
            
        }
        private void Clear()
        {

            Auther_name_txt.Clear();
            Book_ID_txt.Clear();
            Book_Title_txt.Clear();
            Descrption_txt.Clear();
            Edition_txt.Clear();
            Publication_date_book_txt.Text = null;
            Publicsher_ID_txt.Clear();
            Subject_ID_txt.Clear();

        }
        private void Previous_Page_btn_Click(object sender, EventArgs e)
        {
            main newmain = new main();
            newmain.Show();
            this.Hide();
        }
        private void Addbook_Load(object sender, EventArgs e)
        {
            Entities1 DB = new Entities1();

            var book = DB.Book_table.ToList();
            dataGridView1.DataSource = book.ToList();


        }

        private void button2_Click(object sender, EventArgs e)


        {

            try
            {
                Entities1 DB = new Entities1();
                Book_table debook = DB.Book_table.Where(b => b.Book_id == c_id).FirstOrDefault();
                if (debook != null)
                {
                    debook.Book_id= int.Parse( Book_ID_txt.Text);
                    debook.Title = Book_Title_txt.Text;
                    debook.Subject = (Subject_ID_txt.Text);
                    debook.Photo = Book_pictureBox1.ImageLocation;
                    debook.Publication_date = Publication_date_book_txt.Value;
                    debook.Auther_name = Auther_name_txt.Text;
                    debook.publisher_ID =int.Parse( Publicsher_ID_txt.Text);
                    debook.Descrption =Descrption_txt.Text;
                    debook.Edition = int.Parse( Edition_txt.Text);
                    DB.Book_table.Remove(debook);
                    DB.SaveChanges();

                }
                var all_books = DB.Book_table.ToList();
                dataGridView1.DataSource = all_books.ToList();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EX:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Auther_name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int c_id;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Book_ID_txt.Text = dataGridView1.CurrentRow.Cells["Book_id"].Value.ToString();
                Book_Title_txt.Text = dataGridView1.CurrentRow.Cells["Title"].Value.ToString();
                Subject_ID_txt.Text = dataGridView1.CurrentRow.Cells["Subject"].Value.ToString();
                Edition_txt.Text = dataGridView1.CurrentRow.Cells["Edition"].Value.ToString();
                Auther_name_txt.Text = dataGridView1.CurrentRow.Cells["Auther_name"].Value.ToString();
                Descrption_txt.Text = dataGridView1.CurrentRow.Cells["Descrption"].Value.ToString();
                Publication_date_book_txt.Text = dataGridView1.CurrentRow.Cells["Publication_date"].Value.ToString();
                Publicsher_ID_txt.Text = dataGridView1.CurrentRow.Cells["Publisher_ID"].Value.ToString();
                Book_pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells["photo"].Value.ToString();
            }
            else
            {

            }

            c_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Book_id"].Value);

        }

        private void Edit_book_btn_Click(object sender, EventArgs e)
        {

            try
            {
                Entities1 DB = new Entities1();
                Book_table debook = DB.Book_table.Where(b => b.Book_id == c_id).FirstOrDefault();
                if (debook != null)
                {
                    debook.Book_id = int.Parse(Book_ID_txt.Text);
                    debook.Title = Book_Title_txt.Text;
                    debook.Subject = (Subject_ID_txt.Text);
                    debook.Photo = Book_pictureBox1.ImageLocation;
                    debook.Publication_date = Publication_date_book_txt.Value;
                    debook.Auther_name = Auther_name_txt.Text;
                    debook.publisher_ID = int.Parse(Publicsher_ID_txt.Text);
                    debook.Descrption = Descrption_txt.Text;
                    debook.Edition = int.Parse(Edition_txt.Text);

                    ///DB.Book_table.(debook);
                    DB.SaveChanges();

                }
                var all_books = DB.Book_table.ToList();
                dataGridView1.DataSource = all_books.ToList();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EX:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
      
}
