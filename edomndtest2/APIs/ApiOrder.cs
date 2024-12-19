using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace edomndtest2.APIs
{
    public static class ApiOrder
    {
        private static readonly HttpClient client = new HttpClient();  // Shared HttpClient instance

        // Place an order (e.g., coffee)
        public static async Task<string> PlaceOrderAsync(int tableId, int userId)
        {
            try
            {
                string url = "https://localhost:7101/api/Order/CreateOrder";
                var orderData = new
                {
                    tableId = tableId,
                    userId = userId
                    // status, time, createdAt, and updatedAt will be handled by the backend
                };

                // Serialize the object to JSON
                string jsonContent = JsonConvert.SerializeObject(orderData);

                // Create the HTTP content with the JSON string
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Send the POST request with JSON content
                HttpResponseMessage response = await client.PostAsync(url, content);

                // Handle success or failure
                if (response.IsSuccessStatusCode)
                {
                    return "Order placed successfully!";
                }
                else
                {
                    return "Error placing the order.";
                }
            }
            catch (Exception ex)
            {
                // Handle any errors (e.g., network issues)
                return $"An error occurred: {ex.Message}";
            }
        }


        // Get a list of available menu items
        public static async Task<string> GetAllAsync()
        {
            try
            {
                string url = "https://localhost:7101/api/Order/GetAllOrders";
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string menuItems = await response.Content.ReadAsStringAsync();
                    return menuItems;  // Return the list of menu items as a string
                }
                else
                {
                    return "Error fetching the menu.";
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }

        // Update an order's status (e.g., to "Completed")
        public static async Task<string> UpdateOrderStatusAsync(int orderId, string status)
        {
            try
            {
                string url = $"https://your-api-endpoint.com/api/orders/{orderId}/status";
                var content = new StringContent($"{{\"status\":\"{status}\"}}", System.Text.Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    return "Order status updated successfully!";
                }
                else
                {
                    return "Error updating the order status.";
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }
    }
}
