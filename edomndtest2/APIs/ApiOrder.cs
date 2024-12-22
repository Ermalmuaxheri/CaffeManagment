using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static edomndtest2.Menu;

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

                string jsonContent = JsonConvert.SerializeObject(orderData);

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);

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
                return $"An error occurred: {ex.Message}";
            }
        }

        public static async Task<string> GetAllAsync()
        {
            try
            {
                string url = "https://localhost:7101/api/Order/GetAllOrders";
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string menuItems = await response.Content.ReadAsStringAsync();
                    return menuItems;
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

        // Get the open order ID for a given table
        public static async Task<int> GetOpenOrderId(int tableId)
        {
            try
            {
                string url = $"https://localhost:7101/api/Order/GetOrderByTableId?tableId={tableId}";
                Debug.WriteLine(url);
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    // Deserialize the JSON response
                    var jsonResponse = JsonConvert.DeserializeObject<ResponseWrapper>(result);

                    // Check if any orders are returned for the table
                    if (jsonResponse != null && jsonResponse.Data != null)
                    {
                        // Find the first order with matching tableId and status "Open"
                        var order = jsonResponse.Data.FirstOrDefault(o => o.TableId == tableId && o.Status == "Open");
                        return order != null ? order.Id : 0;  // Return order ID if found, otherwise 0
                    }
                }

                // Return 0 if no matching open orders are found
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0; // Indicate failure
            }
        }

        // A helper method for fetching orders by table ID
        public static async Task<List<ListBoxItem>> GetOrdersForTableAsync(int tableId)
        {
            try
            {
                string url = $"https://localhost:7101/api/orders/{tableId}";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();

                    // Deserialize the orders into ListBoxItem objects
                    var orders = JsonConvert.DeserializeObject<List<ListBoxItem>>(responseData);
                    return orders;
                }
                else
                {
                    return new List<ListBoxItem>(); // Return an empty list if there's an error
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching orders: {ex.Message}");
                return new List<ListBoxItem>();
            }
        }

        // Response wrapper for order data
        public class ResponseWrapper
        {
            [JsonProperty("data")]
            public List<Order> Data { get; set; } = new List<Order>();
        }

        // Order model
        public class Order
        {
            public int Id { get; set; }
            public int TableId { get; set; }
            public int UserId { get; set; }
            public string Status { get; set; } = string.Empty;
            public string Time { get; set; } = string.Empty;
        }
    }

}
