using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edomndtest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void Table1_Click(object sender, EventArgs e)
        {
            OpenTableForm(1003);
        }

        private void Table2_Click(object sender, EventArgs e)
        {
            OpenTableForm(1004);
        }

        private void Table3_Click(object sender, EventArgs e)
        {
            OpenTableForm(1005);
        }

        private void Table4_Click(object sender, EventArgs e)
        {
            OpenTableForm(1006);
        }

        private void Table5_Click(object sender, EventArgs e)
        {
            OpenTableForm(1007);
        }

        private void Table6_Click(object sender, EventArgs e)
        {
            OpenTableForm(1008);
        }

        private void OpenTableForm(int tableId)
        {
            // Pass tableId to TableForm
            TableForm tableForm = new TableForm(tableId);

            // Show the TableForm
            tableForm.Show();
        }
    }
}
