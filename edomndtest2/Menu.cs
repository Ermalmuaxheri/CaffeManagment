using System;
using System.Windows.Forms;

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
            HotMenuPanel.Visible = false;
            ColdMenuPanel.Visible = false;
        }

        // Helper method to add/update drink in the OrderList
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

        // Other methods remain unchanged
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iceLatteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
