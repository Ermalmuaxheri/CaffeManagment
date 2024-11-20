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
            OpenTableForm();

        }

        private void Table2_Click(object sender, EventArgs e)
        {

        }

        private void Table3_Click(object sender, EventArgs e)
        {

        }

        private void Table4_Click(object sender, EventArgs e)
        {

        }

        private void Table6_Click(object sender, EventArgs e)
        {

        }

        private void Table5_Click(object sender, EventArgs e)
        {

        }
        private void OpenTableForm()
        {
            // Create an instance of the TableForm
            TableForm tableForm = new TableForm();

            // Show the form
            tableForm.Show();
        }

   
    }
}
