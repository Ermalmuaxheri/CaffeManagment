using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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

        public static async Task<int> GetOpenOrderId(int tableId)
        {
            string url = $"https://localhost:7101/api/Order/GetOrderByTableId?tableId={tableId}";
            HttpResponseMessage response = await new HttpClient().GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();

                var jsonResponse = JsonConvert.DeserializeObject<ResponseWrapper>(result);

                if (jsonResponse != null && jsonResponse.Data != null && jsonResponse.Data.Count > 0)
                {
                    return jsonResponse.Data[0].Id;
                }
            }

            return 0;
        }

        public static async Task<string> UpdateOrderStatusAsync(int orderId, string status)
        {
            try
            {
                string url = $"https://localhost:7101/api/Order/UpdateOrderStatus?orderId={orderId}&status={status}";
                var content = new StringContent("", Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);

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

        public class ResponseWrapper
        {
            [JsonProperty("data")]
            public List<Order> Data { get; set; } = new List<Order>();
        }

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
