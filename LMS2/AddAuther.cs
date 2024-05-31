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
    public partial class AddAutherfrm : Form
    {
        public AddAutherfrm()
        {
            InitializeComponent();
        }


        private void Save_data_Auther_btn_Click(object sender, EventArgs e)
        {
            Entities1 DB = new Entities1();
                if(!string.IsNullOrEmpty(Auther_ID_txt.Text) )
                {
                    //int test_Auther_ID_txt = int.Parse(Auther_ID_txt.Text);
                    string test_Auther_ID_txt = Auther_ID_txt.Text;
                    bool ch = false;
                    for(int i =0; i < test_Auther_ID_txt.Length; i++)
                    {
                        if( test_Auther_ID_txt[i] >= 'A' && test_Auther_ID_txt[i] <= 'z' )
                        {
                            ch = true;
                            break;
                        }
                    }
                    if(ch == false)
                    {
                        if( !string.IsNullOrEmpty(Auther_name_txt.Text) )
                        {
                            

                                if( Email_Auther_txt.Text != "" )
                                {
                                    if(Bio_Auther_txt.Text !="")
                                    {
                                        Auther_table Auth = new Auther_table()
                                        {
                                            aut_id = int.Parse(Auther_ID_txt.Text),
                                            email = Auther_name_txt.Text,
                                            name = Auther_name_txt.Text,
                                            biography = Bio_Auther_txt.Text,

                                        };

                                        DB.Auther_tables.Add(Auth);
                                        DB.SaveChanges();

                                        MessageBox.Show($"Add successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("please fill the blank fields in Auther Biography", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }

                                }
                                else
                                {
                                    MessageBox.Show("please fill the blank fields in Email", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                       
                        }
                        else
                        {
                            MessageBox.Show("please fill the blank fields in Auther Name", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("pleas check the Auther ID is number", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Auther_ID_txt.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("please fill the blanks fields in Auther ID", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            /*
             * auther_table Auth = new auther_table()
                {
                    aut_id = int.Parse(Auther_ID_txt.Text),
                    email = Auther_name_txt.Text,
                    name = Auther_name_txt.Text,
                    biography = Bio_Auther_txt.Text ,

                };

                DB.auther_tables.Add(Auth);
                DB.SaveChanges();
                MessageBox.Show($"Add successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
             */



        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Auther_ID_txt.Clear();
            Auther_name_txt.Clear();
            Bio_Auther_txt.Clear();
            Email_Auther_txt.Clear();
        }

        private void Groub_Auther_data_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Previous_Page_btn_Click(object sender, EventArgs e)
        {
            main new_Main = new main();
            new_Main.Show();
            this.Hide();
        }
    }
}
