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
    public partial class Datagridviewofstaticmember : Form
    {
        public Datagridviewofstaticmember()
        {
            InitializeComponent();
            Entities1 DB = new Entities1();

            var member = DB.Members.ToList();
            dataGridView1.DataSource = member.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
