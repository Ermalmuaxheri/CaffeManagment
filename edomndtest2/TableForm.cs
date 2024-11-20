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
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        private void AddCoffeBtn_Click(object sender, EventArgs e)
        {
            OpenTableForm();
        }
        private void OpenTableForm()
        {
            // Create an instance of the TableForm
            Menu MenuForm = new Menu();

            // Show the form
            MenuForm.Show();
        }
    }
}
