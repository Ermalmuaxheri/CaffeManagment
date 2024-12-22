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
            CheckOpenOrder();
            //LoadExistingOrders();
            //await GetTableStatus();
        }
        private async void CheckOpenOrder()
        {
            try
            {
                // Get the open order ID for the given table
                int orderId = await ApiOrder.GetOpenOrderId(tableId);
                

                if (orderId > 0)
                {
                    // There is an open order for this table
                    MessageBox.Show($"Table {tableId} has an open order with Order ID: {orderId}", "Open Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // No open order for this table
                    MessageBox.Show($"Table {tableId} does not have any open orders.", "No Open Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors during the check
                MessageBox.Show($"Error checking open orders for Table {tableId}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //GET THE TABLE STATUS TO SEE IF ITS OCCUPIED OR NOT
        //private async Task<string> GetTableStatus(int tableId)
        //{
        //    try
        //    {
        //        // Call API to get table info
        //        string tableInfo = await ApiTable.GetTableInfoAsync(tableId);
        //        Debug.WriteLine($"Table Info: {tableInfo}");
        //        return tableInfo; // e.g., "Status: Occupied"
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error fetching table status: {ex.Message}");
        //        return null;
        //    }
        //}

        //private async void LoadExistingOrders()
        //{
        //    try
        //    {
        //        // Step 1: Get table status
        //        string tableStatus = await GetTableStatus(tableId);

        //        if (tableStatus == null || !tableStatus.Contains("Occupied"))
        //        {
        //            MessageBox.Show($"Table {tableId} is not occupied. No orders to display.");
        //            return;
        //        }

        //        // Step 2: Fetch orders if table is occupied
        //        var existingOrders = await ApiOrder.GetOrdersForTableAsync(tableId);

        //        if (existingOrders == null || !existingOrders.Any())
        //        {
        //            MessageBox.Show($"No orders found for Table {tableId}.");
        //        }
        //        else
        //        {
        //            // Step 3: Display orders
        //            StringBuilder ordersList = new StringBuilder("Orders:\n");
        //            foreach (var order in existingOrders)
        //            {
        //                ordersList.AppendLine(order.ToString()); // Customize display format
        //            }
        //            MessageBox.Show(ordersList.ToString());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error loading existing orders: {ex.Message}");
        //    }
        //}



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
        //private async Task OpenMenuForm()
        //{
        //    try
        //    {
        //        // Check if the table already has orders
        //        var existingOrders = await ApiOrder.GetOrdersForTableAsync(tableId);

        //        if (existingOrders != null && existingOrders.Any())
        //        {
        //            // Table already has an order
        //            MessageBox.Show($"Table {tableId} already has an order.", "Order Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            // Table has no orders, proceed to open the menu form
        //            Menu menuForm = new Menu(tableId);
        //            menuForm.Show();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any errors from the API call
        //        MessageBox.Show($"Error checking orders for Table {tableId}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        private async void DoneBtn_Click(object sender, EventArgs e)
        {
            await TryTable();
            this.Close();
        }
        private async Task TryTable()
        {
            string result = await ApiTable.GetTableInfoAsync(tableId);
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