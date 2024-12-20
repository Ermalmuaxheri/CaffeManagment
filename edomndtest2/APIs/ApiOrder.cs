using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public static async Task<string> GetLastOpenOrderAsync(int tableId)
        {
            try
            {
                string url = $"https://localhost:7101/api/Order/GetOrderByTableId?tableId={tableId}";
                HttpResponseMessage response = await client.GetAsync(url);

                // Ensure the response is successful
                response.EnsureSuccessStatusCode();

                // Read the response content
                string responseData = await response.Content.ReadAsStringAsync();

                // Parse JSON and extract relevant data
                var jsonDocument = JsonDocument.Parse(responseData);
                var data = jsonDocument.RootElement.GetProperty("data");

                // Assuming the table JSON structure has properties like tableId and status
                string status = data.TryGetProperty("status", out var statusProp) ? statusProp.GetString() : "Unknown";
                int orderId = data.TryGetProperty("id", out var orderIdProp) ? orderIdProp.GetInt32() : -1;

                // Return the extracted table information
                return $"Table ID: {orderId}, Status: {status}";
            }
            catch (Exception ex)
            {
                // Handle errors
                return $"Error: {ex.Message}";
            }
        }

    }
}
