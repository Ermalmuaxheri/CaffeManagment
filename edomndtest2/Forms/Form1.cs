using edomndtest2.APIs;
using edomndtest2.Forms;

namespace edomndtest2
{
    public partial class Form1 : Form
    {
        private int userId;
        private string userName;
        private string userSurname;

        public Form1(int userId, string userName, string userSurname)
        {
            InitializeComponent();

            this.userId = userId;
            this.userName = userName;
            this.userSurname = userSurname;

            UserLabel.Text = $"{userName}";

            UpdateTableStatus();

        }

        private async void UpdateTableStatus()
        {
            for (int tableId = 1; tableId <= 6; tableId++)
            {
                var openOrders = await ApiOrder.GetOpenOrdersByTableId(tableId);

                var openOrder = openOrders.FirstOrDefault(o => o.TableId == tableId && o.Status == "Open");

                if (openOrder != null)
                {
                    if (openOrder.UserId != this.userId)
                    {
                        DisableTable(tableId);
                    }
                    else
                    {
                        EnableTable(tableId);
                    }
                }
                else
                {
                    EnableTable(tableId);
                }
            }
        }

        private void DisableTable(int tableId)
        {
            Button tableButton = GetTableButton(tableId);
            if (tableButton != null)
            {
                tableButton.BackColor = Color.Red;
                tableButton.Enabled = false;
            }
        }

        private void EnableTable(int tableId)
        {
            Button tableButton = GetTableButton(tableId);
            if (tableButton != null)
            {
                tableButton.BackColor = Color.White;
                tableButton.Enabled = true;
            }
        }

        private Button GetTableButton(int tableId)
        {
            switch (tableId)
            {
                case 1: return Table1;
                case 2: return Table2;
                case 3: return Table3;
                case 4: return Table4;
                case 5: return Table5;
                case 6: return Table6;
                default: return null;
            }
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
            TableForm tableForm = new TableForm(tableId, this.userId);

            tableForm.Show();
        }

        private void switchUserBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            using (PinForm pinForm = new PinForm())
            {
                if (pinForm.ShowDialog() == DialogResult.OK)
                {
                    this.userId = pinForm.UserId;
                    this.userName = pinForm.UserName;
                    this.userSurname = pinForm.UserSurname;

                    UserLabel.Text = $"{this.userName}";

                    UpdateTableStatus();
                }
                else
                {
                    Application.Exit();
                }
            }

            this.Show();
        }
    }
}
