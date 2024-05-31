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
    public partial class Record_History_frm : Form
    {
        public Record_History_frm()
        {
            InitializeComponent();
            
        }
        
        private void Return_main_btn_Click(object sender, EventArgs e)
        {
            main new_main = new main();
            new_main.Show();
            this.Hide();
        }

        private void Save_date_Rh_btn_Click(object sender, EventArgs e)
        {

            Entities1 DB = new Entities1();

            if(!string.IsNullOrEmpty(Member_ID_RH_txt.Text))
            {
                string Member_ID_RH_txt_test = Member_ID_RH_txt.Text;
                bool check_Member_ID_RH_txt = false;
                for(int i = 0; i < Member_ID_RH_txt_test.Length; i++)
                {
                    if(Member_ID_RH_txt_test[i]>='A' && Member_ID_RH_txt_test[i]<='z')
                    {
                        check_Member_ID_RH_txt=true;
                        break;
                    }
                }

                if(check_Member_ID_RH_txt == false)
                {
                    //////////////////////////////////////////
                    ///
                    if(!string.IsNullOrEmpty(name_RH_txt.Text))
                    {
                        
                        bool check_nameIS_valid = false;
                        ////////////////////////////////////////////
                        ///كود  الاتشيك ع الاسم منطقي ولا لا 
                        ////////////////////////////////////////////
                        ///

                        if (check_nameIS_valid == false)
                        {
                            var d1 = DateTime.Parse(dateTimePicker1.Value.ToString());
                            var d2 = DateTime.Parse(Out_dateTimePicker2.Value.ToString());

                            if(d2 >= d1)
                            {
                                try
                                {
                                    record_history new_record_history = new record_history()
                                    {
                                        Member_ID = Convert.ToInt32(Member_ID_RH_txt.Text),
                                        name = name_RH_txt.Text,
                                        Enter_date = DateTime.Parse(dateTimePicker1.Value.ToString()),
                                        Out_date = DateTime.Parse(Out_dateTimePicker2.Value.ToString()),
                                        State = statue_RH_txt.Text,
                                    };
                                    DB.record_histories.Add(new_record_history);
                                    DB.SaveChanges();

                                    Member_ID_RH_txt.Clear(); name_RH_txt.Clear(); statue_RH_txt.Clear();
                                    MessageBox.Show($"Add successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                            }
                            else
                            {
                                string message = "The exit time cannot be less than the entry time";
                                string title = "Error Message";
                                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                                
                            }
                        }
                        else
                        {
                            string message = "Enter a valid name";
                            string title = "Error Message";
                            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                            name_RH_txt.Clear();
                        }
                    }
                    else
                    {
                        string message = "The name field is empty ";
                        string title = "Error Message";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string message = "The Member ID must not contain any letters";
                    string title = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        Member_ID_RH_txt.Clear();
                    }
                    else
                    {
                        Member_ID_RH_txt.Clear();
                    }
                }
            }
            else
            {
                string message = "The Member ID is empty field";
                string title = "Error Message";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                
            }
        }

        private void clear_data_RH_btn_Click(object sender, EventArgs e)
        {
            Member_ID_RH_txt.Clear(); name_RH_txt.Clear(); statue_RH_txt.Clear();
        }
    }
}
