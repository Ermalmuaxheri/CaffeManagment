using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using edomndtest2.APIs;

namespace edomndtest2
{
    public partial class Menu : Form
    {
        // Counters for each drink
        int Esspresso = 0;
        int Latte = 0;
        int Macchiato = 0;
        int Cappuccino = 0;
        int Americano = 0;
        int Mocha = 0;
        int WhiteMocha = 0;
        int Brewed = 0;
        int FlatWhite = 0;

        public Menu()
        {
            InitializeComponent();

            // Initialize visibility for panels
            HotMenuPanel.Visible = false;
            ColdMenuPanel.Visible = false;

            // Add "Fetch Data" button programmatically
            Button fetchDataBtn = new Button
            {
                Name = "fetchDataBtn",
                Text = "Fetch Data",
                Location = new System.Drawing.Point(10, 10), // Adjust position as needed
                Size = new System.Drawing.Size(100, 30)     // Adjust size as needed
            };

            //fetchDataBtn.Click += fetchDataBtn_Click; // Attach event handler
            //this.Controls.Add(fetchDataBtn);         // Add button to the form
        }




        private async void fetchDataBtn_Click(object sender, EventArgs e)
        {
            // Map drink names to their IDs
            var drinkIdMap = new Dictionary<string, int>
    {
        { "Espresso", 1 },
        { "Latte", 2 },
        { "Macchiato", 3 },
        { "Cappuccino", 4 },
        { "Americano", 5 },
        { "Mocha", 6 },
        { "White Mocha", 7 },
        { "Brewed", 8 },
        { "Flat White", 9 }
    };

            // Iterate through the OrderList to get the drinks and quantities
            foreach (var item in OrderList.Items)
            {
                // Split the string to extract the drink name and quantity
                var parts = item.ToString().Split(' ');
                if (parts.Length < 2) continue;

                string drinkName = parts[0];
                if (int.TryParse(parts[1], out int quantity) && quantity > 0)
                {
                    if (drinkIdMap.TryGetValue(drinkName, out int drinkId))
                    {
                        // Make the API call for each drink
                        string result = await ApiOrderItem.AddItemsAsync(9, drinkId, quantity); // Replace '1' with the actual OrderId
                        MessageBox.Show($"Order for {drinkName} ({quantity}) was processed: {result}");
                    }
                    else
                    {
                        MessageBox.Show($"Unknown drink: {drinkName}");
                    }
                }
                else
                {
                    MessageBox.Show($"Invalid quantity for item: {item}");
                }
            }
        }


        private void UpdateOrderList(string drinkName, ref int drinkCount)
        {
            drinkCount++;

            // Check if the drink is already in the OrderList
            for (int i = 0; i < OrderList.Items.Count; i++)
            {
                string item = OrderList.Items[i].ToString();
                if (item.StartsWith(drinkName, StringComparison.OrdinalIgnoreCase))
                {
                    // Update the existing item with the new count
                    OrderList.Items[i] = $"{drinkName} {drinkCount}";
                    return; // Exit after updating
                }
            }

            // If not found, add it as a new item
            OrderList.Items.Add($"{drinkName} {drinkCount}");
        }

        // Button click events
        private void esspressoBtn_Click(object sender, EventArgs e)
        {
            UpdateOrderList("Espresso", ref Esspresso);
        }

        private void latteBtn_Click(object sender, EventArgs e)
        {
            UpdateOrderList("Latte", ref Latte);
        }

        private void macchiatoBtn_Click(object sender, EventArgs e)
        {
            UpdateOrderList("Macchiato", ref Macchiato);
        }

        private void capuchinoBtn_Click(object sender, EventArgs e)
        {
            UpdateOrderList("Cappuccino", ref Cappuccino);
        }

        private void americanoBtn_Click(object sender, EventArgs e)
        {
            UpdateOrderList("Americano", ref Americano);
        }

        private void mochaBtn_Click(object sender, EventArgs e)
        {
            UpdateOrderList("Mocha", ref Mocha);
        }

        private void whiteMochaBtn_Click(object sender, EventArgs e)
        {
            UpdateOrderList("White Mocha", ref WhiteMocha);
        }

        private void brewedBtn_Click(object sender, EventArgs e)
        {
            UpdateOrderList("Brewed", ref Brewed);
        }

        private void flatwhiteBtn_Click(object sender, EventArgs e)
        {
            UpdateOrderList("Flat White", ref FlatWhite);
        }

        private void HotBtn_Click(object sender, EventArgs e)
        {
            HotMenuPanel.Visible = true;
            ColdMenuPanel.Visible = false;
        }

        private void ColdBtn_Click(object sender, EventArgs e)
        {
            ColdMenuPanel.Visible = true;
            HotMenuPanel.Visible = false;
        }

        private void Menu_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iceLatteBtn_Click(object sender, EventArgs e) { }
    }
}
