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
    public partial class Gridviewofstaticbook : Form
    {
        public Gridviewofstaticbook()
        {
            InitializeComponent();
            Entities1 DB = new Entities1();

            var book = DB.Book_table.ToList();
            dataGridView1.DataSource = book.ToList();
        }

        private void Gridviewofstaticbook_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
