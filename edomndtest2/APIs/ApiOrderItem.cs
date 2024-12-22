using Newtonsoft.Json;
using System.Text;

namespace edomndtest2.APIs
{
    public static class ApiOrderItem
    {
        private static readonly HttpClient client = new HttpClient();  // Shared HttpClient instance

        // Place an order (e.g., coffee)
        public static async Task<string> AddItemsAsync(int OrderId, int ItemId, int Quantity)
        {
            try
            {
                string url = "https://localhost:7101/api/OI/CreateOI";
                var orderData = new
                {
                    orderId = OrderId,
                    itemId = ItemId,
                    quantity = Quantity
                };

                string jsonContent = JsonConvert.SerializeObject(orderData);

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Send the POST request with JSON content
                HttpResponseMessage response = await client.PostAsync(url, content);

                // Handle success or failure
                if (response.IsSuccessStatusCode)
                {
                    // If you don't want to return the response data, you can just return a success message
                    return "Order placed successfully!";
                }
                else
                {
                    // Optionally log the error details if needed for debugging
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    return $"Error placing the order. Response: {errorResponse}";
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
