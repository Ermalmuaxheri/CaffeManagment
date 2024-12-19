using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace edomndtest2.APIs
{
    public static class ApiOrderItem
    {
        private static readonly HttpClient client = new HttpClient();  // Shared HttpClient instance

        // Place an order (e.g., coffee)
        public static async Task<string> AddItemsAsync(int OrderId, int itemId, int quantity)
        {
            try
            {
                string url = "https://localhost:7101/api/OI/CreateOI";
                var orderData = new
                {
                    OrderId = OrderId,
                    itemId = itemId,
                    quantity = quantity
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

    }
}
