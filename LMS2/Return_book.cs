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
    public partial class Return_book : Form
    {
        public Return_book()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Save_return_book_btn_Click(object sender, EventArgs e)
        {
            Entities1 DB = new Entities1();
            return_table new_Return_book = new return_table
            {
                Return_ID =int.Parse(Return_ID_txt.Text),
                Borrow_ID = int.Parse(Borrow_ID_txt.Text),
                Return_date = DateTime.Now,
                Statues =Statues_txt.Text,
            };

            DB.return_tables.Add(new_Return_book);
            DB.SaveChanges();

            MessageBox.Show($"Returned successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Previous_page_Click(object sender, EventArgs e)
        {
            main new_Main = new main();
            new_Main.Show();
            this.Hide();
        }
    }
}
