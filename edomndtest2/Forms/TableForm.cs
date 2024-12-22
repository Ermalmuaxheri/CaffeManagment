using edomndtest2.APIs;
using Newtonsoft.Json;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            //listView1.View = View.Details;
            //listView1.Columns.Add("Name", 150, HorizontalAlignment.Left);
            //listView1.Columns.Add("Quantity", 100, HorizontalAlignment.Center);
            //listView1.Columns.Add("Subtotal", 100, HorizontalAlignment.Right);

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
                    FetchAndDisplayOrderItem();
                    //QETU NESE KA ORDER KY TABLE ATHER I KTHEN AMA SI JSON,,,,,,, EDHE PAK EDHE PAK.....:((((
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
        private async void FetchAndDisplayOrderItem()
        {
            try
            {
                int orderId = await ApiOrder.GetOpenOrderId(tableId);

                if (orderId > 0)
                {
                    string orderItemDetails = await ApiOrderItem.GetOrderItemByOrderIdAsync(orderId);
                    var orderItems = ParseOrderItems(orderItemDetails);

                    if (orderItems.Count > 0)
                    {
                        // Populate the ListView
                        MenuList.Items.Clear();

                        foreach (var item in orderItems)
                        {
                            // Add item to the ListView without images
                            var listViewItem = new ListViewItem(item.Name);
                            listViewItem.SubItems.Add(item.Quantity.ToString());
                            listViewItem.SubItems.Add($"${item.SubTotal:F2}");

                            MenuList.Items.Add(listViewItem);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No items found for Order {orderId}.", "No Items Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"No open order found for Table {tableId}.", "No Open Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching order item details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public class DrinkOrder
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal SubTotal { get; set; }
            public string ImageUrl { get; set; }
        }


        private List<DrinkOrder> ParseOrderItems(string jsonResponse)
        {
            var orderItems = new List<DrinkOrder>();

            try
            {
                var data = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
                foreach (var item in data["data"])
                {
                    var drink = new DrinkOrder
                    {
                        Name = (string)item["item"]["name"],
                        Quantity = (int)item["quantity"],
                        SubTotal = (decimal)item["subTotal"],
                        ImageUrl = (string)item["item"]["imageUrl"] // Assuming this is the path in the API response
                    };

                    orderItems.Add(drink);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error parsing order items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return orderItems;
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

        private void DiscountBtn_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Add Button Click Event
        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Get the selected item from the ListView
            if (MenuList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = MenuList.SelectedItems[0];
                // Get the current quantity (in the second column)
                int currentQuantity = int.Parse(selectedItem.SubItems[1].Text);

                // Increase the quantity
                currentQuantity++;

                // Update the quantity column
                selectedItem.SubItems[1].Text = currentQuantity.ToString();

                // Update the subtotal column (assuming subtotal is in the third column)
                decimal price = decimal.Parse(selectedItem.SubItems[2].Text.Replace("$", "")); // Get the price
                selectedItem.SubItems[2].Text = $"${(price * currentQuantity):F2}"; // Update the subtotal
            }
            else
            {
                MessageBox.Show("Please select an item to add quantity.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Remove Button Click Event
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            // Get the selected item from the ListView
            if (MenuList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = MenuList.SelectedItems[0];
                // Get the current quantity (in the second column)
                int currentQuantity = int.Parse(selectedItem.SubItems[1].Text);

                // If the quantity is greater than 1, decrease the quantity
                if (currentQuantity > 1)
                {
                    currentQuantity--;
                    selectedItem.SubItems[1].Text = currentQuantity.ToString();

                    // Update the subtotal column
                    decimal price = decimal.Parse(selectedItem.SubItems[2].Text.Replace("$", "")); // Get the price
                    selectedItem.SubItems[2].Text = $"${(price * currentQuantity):F2}"; // Update the subtotal
                }
                else
                {
                    // If quantity is 1, remove the item from the ListView
                    MenuList.Items.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove quantity.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}