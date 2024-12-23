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
            this.userId = userId;
            CheckOpenOrder();
        }

        private async void CheckOpenOrder()
        {
            try
            {
                int orderId = await ApiOrder.GetOpenOrderId(tableId);

                if (orderId > 0)
                {
                    FetchAndDisplayOrderItem();
                }
                else
                {
                    //MessageBox.Show($"Table {tableId} does not have any open orders.", "No Open Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking open orders for Table {tableId}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void AddCoffeBtn_Click(object sender, EventArgs e)
        {
            await OpenMenuForm();
        }

        private async Task OpenMenuForm()
        {
            string result = await ApiOrder.PlaceOrderAsync(tableId, userId);
            Debug.WriteLine(result);

            Menu menuForm = new Menu(tableId);
            menuForm.OrderCompleted += RefreshTable;
            menuForm.Show();
        }

        private void RefreshTable()
        {
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
                        MenuList.Items.Clear();
                        decimal totalAmount = 0;

                        foreach (var item in orderItems)
                        {
                            var listViewItem = new ListViewItem(item.Name);
                            listViewItem.SubItems.Add(item.Quantity.ToString());
                            listViewItem.SubItems.Add($"${item.SubTotal:F2}");

                            MenuList.Items.Add(listViewItem);
                            totalAmount += item.SubTotal; // Accumulate the subtotal
                        }

                        // Display the total amount below the ListView
                        Totali.Text = $"${totalAmount:F2}";  // Make sure lblTotalAmount is defined in the Form
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
                        ImageUrl = (string)item["item"]["imageUrl"]
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

        private async void DoneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void checkoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = await ApiOrder.GetOpenOrderId(tableId);

                if (orderId > 0)
                {
                    var confirmResult = MessageBox.Show($"Are you sure you want to close the order with ID {orderId}?",
                                                        "Confirm Close Order",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {
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
            // Discount button logic
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Logic for ListView item selection change
        }

        private async void VoidBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show(
                    "Are you sure you want to void this order?",
                    "Confirm Void",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result != DialogResult.Yes)
                {
                    return;
                }

                int orderId = await ApiOrder.GetOpenOrderId(tableId);

                if (orderId > 0)
                {
                    bool isClosed = await ApiOrder.UpdateOrderStatusAsync(orderId, tableId, "Closed");

                    if (isClosed)
                    {
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
