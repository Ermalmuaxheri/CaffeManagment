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
        private int userId;

        public TableForm(int tableId, int userId)
        {
            InitializeComponent();
            this.tableId = tableId;
            CheckOpenOrder();
            this.userId = userId;

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
                    //MessageBox.Show($"Table {tableId} has an open order with Order ID: {orderId}", "Open Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FetchAndDisplayOrderItem();
                    //QETU NESE KA ORDER KY TABLE ATHER I KTHEN AMA SI JSON,,,,,,, EDHE PAK EDHE PAK.....:((((
                }
                else
                {
                    // No open order for this table
                    //MessageBox.Show($"Table {tableId} does not have any open orders.", "No Open Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors during the check
                MessageBox.Show($"Error checking open orders for Table {tableId}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private async void AddCoffeBtn_Click(object sender, EventArgs e)
        {
            await OpenMenuForm();
        }

        private async Task OpenMenuForm()
        {
            // Make the asynchronous API call to place an order
            string result = await ApiOrder.PlaceOrderAsync(tableId, userId);
            Debug.WriteLine(result);

            // Show the Menu form
            Menu menuForm = new Menu(tableId);
            menuForm.OrderCompleted += RefreshTable;  // Subscribe to the OrderCompleted event
            menuForm.Show();
        }

        private void RefreshTable()
        {
            // Reload the table data after an order is completed
            CheckOpenOrder();
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
            //MessageBox.Show(result);
        }
        private async Task CompleteOrder()
        {
            string result = await ApiTable.GetTableInfoAsync(tableId);
            //MessageBox.Show(result);

            if (result.Contains("Status: Occupied"))
            {
                // Table is occupied, take some action
                //MessageBox.Show("The table is currently occupied, should be deleted now ishalla");


            }
            //else if (result.Contains("Status: Available"))
            //{
            //    // Table is available, take some other action
            //    MessageBox.Show("The table is available.");
            //}
            else
            {
                // Handle unknown or unrecognized status
                //MessageBox.Show("Could not determine the table status.");
            }
        }

        private async void checkoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the open order ID for the table
                int orderId = await ApiOrder.GetOpenOrderId(tableId);

                if (orderId > 0)
                {
                    // Confirm before marking the order as closed
                    var confirmResult = MessageBox.Show($"Are you sure you want to close the order with ID {orderId}?",
                                                        "Confirm Close Order",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
                        // Close the order
                        bool isUpdated = await ApiOrder.UpdateOrderStatusAsync(orderId, tableId, "Closed");

                        if (isUpdated)
                        {
                            MessageBox.Show("Order has been successfully closed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to close the order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No open order found to close.", "No Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while closing the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DiscountBtn_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void VoidBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: Confirmation dialog
                var result = MessageBox.Show(
                    "Are you sure you want to void this order?",
                    "Confirm Void",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result != DialogResult.Yes)
                {
                    // User chose not to void the order
                    return;
                }

                // Step 2: Get the open order ID for the table
                int orderId = await ApiOrder.GetOpenOrderId(tableId);

                if (orderId > 0)
                {
                    // Step 3: Close the order
                    bool isClosed = await ApiOrder.UpdateOrderStatusAsync(orderId, tableId, "Closed");

                    if (isClosed)
                    {
                        // Step 4: Delete the order
                        bool isDeleted = await ApiOrder.DeleteOrderAsync(orderId);

                        if (isDeleted)
                        {
                            MessageBox.Show("Order successfully closed and deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the order after closing it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to close the order. Unable to proceed with deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No open order found to void.", "No Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while voiding the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}