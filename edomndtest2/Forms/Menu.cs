using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using edomndtest2.APIs;
using System.Diagnostics;

namespace edomndtest2
{
    public partial class Menu : Form
    {
        private readonly HttpClient _httpClient;
        private readonly ApiItems _apiItems;

        private int tableId;

        public Menu(int tableId)
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _apiItems = new ApiItems(_httpClient);
            this.tableId = tableId;
        }

        private async void HotBtn_Click(object sender, EventArgs e)
        {
            await FilterItemsByCategory(4);
        }

        private async void ColdBtn_Click(object sender, EventArgs e)
        {
            await FilterItemsByCategory(1);
        }

        private async Task FilterItemsByCategory(int categoryId)
        {
            var url = "https://localhost:7101/api/Item/GetAllItems";

            try
            {
                var allItems = await _apiItems.FetchAllItems(url);

                var filteredItems = allItems.Where(item => item.CategoryId == categoryId).ToList();

                itemPanel.Controls.Clear();

                foreach (var item in filteredItems)
                {
                    Button itemButton = new Button
                    {
                        Text = item.Name,
                        Tag = item.Id,
                        Width = 300,
                        Height = 200,
                        TextAlign = ContentAlignment.BottomCenter,
                        TextImageRelation = TextImageRelation.ImageAboveText,
                        ImageAlign = ContentAlignment.MiddleCenter,
                    };

                    try
                    {
                        var imagePath = $"Images/{item.Image}";
                        Image originalImage = Image.FromFile(imagePath);

                        Image resizedImage = ResizeImage(originalImage, itemButton.Width, itemButton.Height);
                        itemButton.Image = resizedImage;
                    }
                    catch (Exception)
                    {
                        Image defaultImage = Image.FromFile("Images/default.jpg");
                        Image resizedImage = ResizeImage(defaultImage, itemButton.Width, itemButton.Height);
                        itemButton.Image = resizedImage;
                    }

                    itemButton.Click += (s, args) =>
                    {
                        bool itemExists = false;

                        for (int i = 0; i < OrderList.Items.Count; i++)
                        {
                            var currentItem = (ListBoxItem)OrderList.Items[i];
                            if (currentItem.Name == item.Name)
                            {
                                currentItem.Quantity++;
                                OrderList.Items[i] = currentItem;
                                itemExists = true;
                                break;
                            }
                        }

                        if (!itemExists)
                        {
                            var listBoxItem = new ListBoxItem
                            {
                                Name = item.Name,
                                Price = item.Price,
                                Quantity = 1,
                                Id = item.Id // Store the itemId here
                            };

                            OrderList.Items.Add(listBoxItem);
                        }
                    };

                    itemPanel.Controls.Add(itemButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
            }
        }

        //To resize the image of the items to fit the button
        private Image ResizeImage(Image originalImage, int width, int height)
        {
            Bitmap resizedBitmap = new Bitmap(originalImage, new Size(width, height));
            return resizedBitmap;
        }

        private void Menu_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private async void DoneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch the orderId for the tableId with status "Open"
                int orderId = await ApiOrder.GetOpenOrderId(tableId);

                if (orderId == 0)
                {
                    MessageBox.Show("No open order found for this table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Iterate through the items in the OrderList and send them to the API
                foreach (var item in OrderList.Items)
                {
                    var orderItem = (ListBoxItem)item;

                    // Add the item to the order using the API
                    string response = await ApiOrderItem.AddItemsAsync(orderId, orderItem.Id, orderItem.Quantity);

                    if (response != "Order placed successfully!")
                    {
                        MessageBox.Show($"Failed to add item: {orderItem.Name}. {response}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                MessageBox.Show("All items added to the order successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(ex.Message);
            }
        }


        //Displaying the items at the list box without the id
        public class ListBoxItem
        {
            public string Name { get; set; } = string.Empty;
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public int Id { get; set; }

            public override string ToString()
            {
                return $"{Name} - ${Price:F2} x {Quantity}";
            }
        }
    }
}
