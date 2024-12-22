using Newtonsoft.Json;

namespace edomndtest2.APIs
{
    public class ApiItems
    {
        private readonly HttpClient _httpClient;

        public ApiItems(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //Response structure
        public class ApiResponse<T>
        {
            public List<T> Data { get; set; } = new List<T>();
        }

        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public decimal Price { get; set; }
            public string Image { get; set; } = string.Empty;
            public int CategoryId { get; set; }
        }


        public async Task<List<Item>> FetchAllItems(string url)
        {
            try
            {
                var response = await _httpClient.GetStringAsync(url);
                var jsonResponse = JsonConvert.DeserializeObject<ApiResponse<Item>>(response);
                return jsonResponse?.Data ?? new List<Item>();
            }
            catch (Exception ex) 
            {
                throw new Exception($"Error fetching items: {ex.Message}");
            }
         }
    }
}
