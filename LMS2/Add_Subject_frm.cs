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
    public partial class Add_Subject_frm : Form
    {
        public Add_Subject_frm()
        {
            InitializeComponent();
        }

        private void Previous_Page_btn_Click(object sender, EventArgs e)
        {
            main new_Main = new main();
            new_Main.Show();
            this.Hide();
        }

        private void Save_data_btn_Click(object sender, EventArgs e)
        {
            Entities1 DB = new Entities1();
            if ( Subj_ID_txt.Text == "" || Subj_Name_txt.Text == "" || Desc_Sub_txt.Text == "")
            {
                MessageBox.Show("please fill all the blanks fields", "error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Subject_table sub = new Subject_table()
                {
                    SUB_id = (Subj_ID_txt.Text),
                    NAME = (Subj_Name_txt.Text),
                    DESC = Desc_Sub_txt.Text,
                    
                };

                DB.Subject_table.Add(sub);
                DB.SaveChanges();
                MessageBox.Show($"Add successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // this.Hide();
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Subj_ID_txt.Clear();
            Subj_Name_txt.Clear();
            Desc_Sub_txt.Clear();

        }

        private void Add_Subject_frm_Load(object sender, EventArgs e)
        {

        }
    }
}
