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
    public partial class Datagridviewofstaticborrow : Form
    {
        public Datagridviewofstaticborrow()
        {
            InitializeComponent();
            Entities1 DB = new Entities1();

            var borrow = DB.Borrows.ToList();
            dataGridView1.DataSource = borrow.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
