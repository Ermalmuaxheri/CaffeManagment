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
            OpenTableForm(1);
        }

        private void Table2_Click(object sender, EventArgs e)
        {
            OpenTableForm(2);
        }

        private void Table3_Click(object sender, EventArgs e)
        {
            OpenTableForm(3);
        }

        private void Table4_Click(object sender, EventArgs e)
        {
            OpenTableForm(4);
        }

        private void Table5_Click(object sender, EventArgs e)
        {
            OpenTableForm(5);
        }

        private void Table6_Click(object sender, EventArgs e)
        {
            OpenTableForm(6);
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
