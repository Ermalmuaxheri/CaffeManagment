using edomndtest2.APIs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edomndtest2
{
    public partial class TableForm : Form
    {
        private int tableId;

        public TableForm(int tableId)
        {
            InitializeComponent();
            this.tableId = tableId;
        }

        private async void AddCoffeBtn_Click(object sender, EventArgs e)
        {
            await OpenMenuForm();
        }

        private async Task OpenMenuForm()
        {
            // Make the asynchronous API call
            string result = await ApiOrder.PlaceOrderAsync(tableId, 1);
            Debug.WriteLine(result);


            // Show the Menu form
            Menu menuForm = new Menu(tableId);
            menuForm.Show();
        }

        private async void DoneBtn_Click(object sender, EventArgs e)
        {
            await TryOrder();
            await TryTable();
            //this.Close();
        }
        private async Task TryTable()
        {
            string result = await ApiTable.GetTableInfoAsync(tableId);
            MessageBox.Show(result);
        }
        private async Task TryOrder()
        {
            string result = await ApiOrder.GetLastOpenOrderAsync(tableId);
            MessageBox.Show(result);
        }
        private async Task CompleteOrder()
        {
            string result = await ApiTable.GetTableInfoAsync(tableId);
            MessageBox.Show(result);

            if (result.Contains("Status: Occupied"))
            {
                // Table is occupied, take some action
                MessageBox.Show("The table is currently occupied, should be deleted now ishalla");


            }
            //else if (result.Contains("Status: Available"))
            //{
            //    // Table is available, take some other action
            //    MessageBox.Show("The table is available.");
            //}
            else
            {
                // Handle unknown or unrecognized status
                MessageBox.Show("Could not determine the table status.");
            }
        }

        private async void checkoutBtn_Click(object sender, EventArgs e)
        {
            await CompleteOrder();
        }
    }
}
