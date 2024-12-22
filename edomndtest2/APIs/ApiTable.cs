using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json; // Added for JSON parsing

namespace edomndtest2.APIs
{
    public static class ApiTable
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

        // Get all tables (assuming this is your endpoint)
        public static async Task<string> GetAllAsync()
        {
            try
            {
                string url = "https://localhost:7101/api/tables";  // Replace with your actual API URL

                HttpResponseMessage response = await client.GetAsync(url);

                // Ensure the response is successful
                response.EnsureSuccessStatusCode();

                // Read the response content
                string responseData = await response.Content.ReadAsStringAsync();

                // Parse JSON and extract relevant data
                var jsonDocument = JsonDocument.Parse(responseData);
                var tables = jsonDocument.RootElement.GetProperty("data");  // Adjust this depending on the actual JSON structure

                string tableInfo = string.Empty;
                foreach (var table in tables.EnumerateArray())
                {
                    int tableId = table.GetProperty("tableId").GetInt32();
                    string status = table.GetProperty("status").GetString();
                    tableInfo += $"Table ID: {tableId}, Status: {status}\n";
                }

                // Return the extracted table information
                return tableInfo;
            }
            catch (Exception ex)
            {
                // Handle errors
                return $"Error: {ex.Message}";
            }
        }
        public static async Task<string> GetTableInfoAsync(int tableId)
        {
            try
            {
                // Use the provided tableId in the API URL
                string url = $"https://localhost:7101/api/Tables/{tableId}";

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
                int tableNumber = data.TryGetProperty("tableNumber", out var tableNumberProp) ? tableNumberProp.GetInt32() : -1;

                // Return the extracted table information
                return $"Table ID: {tableNumber}, Status: {status}";
            }
            catch (Exception ex)
            {
                // Handle errors
                return $"Error: {ex.Message}";
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
