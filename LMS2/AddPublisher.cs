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
    public partial class AddPublisher_frm : Form
    {
        public AddPublisher_frm()
        {
            InitializeComponent();
        }

        private void Previous_Page_btn_Click(object sender, EventArgs e)
        {
            main main_Menu = new main();
            main_Menu.Show();
            this.Close();
        }

        private void Add_publisher_groub_data_panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Publisher_Adress_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumber_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Publisher_Email_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Publisher_Name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Publisher_ID_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Clear_data_Publisher_btn_Click(object sender, EventArgs e)
        {
            phoneNumber_txt.Clear();
            Publisher_Adress_txt.Clear();
            Publisher_Email_txt.Clear();
            Publisher_ID_txt.Clear();
            Publisher_Name_txt.Clear();
        }

        private void Save_data_Pubisher_btn_Click(object sender, EventArgs e)
        {
            Entities1 DB = new Entities1();
            if ( string.IsNullOrEmpty(Publisher_ID_txt.Text) == false)
            {
                string check_Pub = Publisher_ID_txt.Text;
                bool check = false;
                for (int i = 0; i < check_Pub.Length; i++)
                {
                    if (check_Pub[i] >= 'A' && check_Pub[i] <= 'z')
                    {
                        check = true;
                        break;
                    }
                }

                if(check==false)//كلها ارقام 
                {
                    /// كود الاتشيك على الاسم للمؤسسة الان 
                    if( !string.IsNullOrEmpty(Publisher_Name_txt.Text) )
                    {
                        var pub_name = Publisher_Name_txt.Text;
                        bool check_pub_name = false;
                        for(int i =0; i < pub_name.Length; i++)
                        {
                            if( pub_name[i] >= '0' && pub_name[i] <= '9')
                            {
                                check_pub_name = true;
                                break;
                            }
                        }

                        if(check_pub_name == false) // لو لم يحتوى على الاسم اي ارقام 
                        {
                            // الاتشيك ع  سلامة الايميل 
                            if ( !string.IsNullOrEmpty(Publisher_Email_txt.Text))
                            {
                                var Pub_email_ = Publisher_Email_txt.Text;
                                string a = "@", b = ".com";
                                if(Pub_email_.Contains(a) && Pub_email_.Contains(b) )
                                {
                                    // الاتشيك على رقم المؤسسة 

                                    if( !string.IsNullOrEmpty(phoneNumber_txt.Text))
                                    {
                                        var Pub_phone_num = phoneNumber_txt.Text;
                                        bool check_Pub_phone_num = false;

                                        for(int i=0; i < Pub_phone_num.Length; i++)
                                        {
                                            if(Pub_phone_num[i] >= 'A' && Pub_phone_num[i] <= 'z')
                                            {
                                                check_Pub_phone_num=true;
                                                break;
                                            }
                                        }

                                        if(check_Pub_phone_num == false)
                                        {
                                            /// Address check ;
                                            if( !string.IsNullOrEmpty(Publisher_Adress_txt.Text) )
                                            {
                                                Publisher new_pub = new Publisher()
                                                {
                                                    Publisher_ID = int.Parse(Publisher_ID_txt.Text),
                                                    Email = Publisher_Email_txt.Text,
                                                    PhoneNumber = phoneNumber_txt.Text,
                                                    Publisher_name  = Publisher_Name_txt.Text , 
                                                    Address = Publisher_Adress_txt.Text,

                                                };

                                                DB.Publishers.Add(new_pub);
                                                DB.SaveChanges();
                                                MessageBox.Show($"Add successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Close();




                                            }
                                            else
                                            {
                                                MessageBox.Show("the Publisher Address is Empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Invalid, this number contains letters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            phoneNumber_txt.Clear();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("the Publisher Phobe Number is Empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("It must contain @ and It ends with .com", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Publisher_Email_txt.Clear();
                                }

                            }
                            else
                            {
                                MessageBox.Show("the Publisher Email is Empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("It must contain only letters", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Publisher_Name_txt.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("the Publisher Name is Empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // cont 
                {
                    MessageBox.Show("Publisher ID must be numbers only", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Publisher_ID_txt.Clear();
                }

            }
            else
            {
                MessageBox.Show("the Publisher ID is Empty" , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
