using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edomndtest2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            HotMenuPanel.Visible = false;
            ColdMenuPanel.Visible = false;

        }
        private void CustomizeButton()
        {
            // Load an image into the button

            esspressoBtn.BackgroundImage = Image.FromFile("Photos/Esspresso.jpg");
            esspressoBtn.BackgroundImageLayout = ImageLayout.Zoom; // Or Stretch, Center, etc.


            // Adjust image layout
            esspressoBtn.BackgroundImageLayout = ImageLayout.Zoom;

            // Remove text and border
            esspressoBtn.Text = ""; // No text
            esspressoBtn.FlatStyle = FlatStyle.Flat;
            esspressoBtn.FlatAppearance.BorderSize = 0;
        }


        private void HotBtn_Click(object sender, EventArgs e)
        {
            //HotOrCold.Visible = false;
            //HotBtn.Visible = false;
            //ColdBtn.Visible = false;
            HotMenuPanel.Visible = true;
            ColdMenuPanel.Visible = false;
        }

        private void ColdBtn_Click(object sender, EventArgs e)
        {
            //HotBtn.Visible = false;
            //ColdBtn.Visible = false;
            ColdMenuPanel.Visible = true;
            HotMenuPanel.Visible = false;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {


        }

        private void ColdMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        int count = 0;
        int Esspresso = 0;
        int Latte = 0;
        int Machiato = 0;

        private void esspressoBtn_Click(object sender, EventArgs e)
        {
            {
                Esspresso++;

                // Check if "Espresso" is already in the OrderList
                for (int i = 0; i < OrderList.Items.Count; i++)
                {
                    string item = OrderList.Items[i].ToString();
                    if (item.StartsWith("espresso")) // Check if the item starts with "espresso"
                    {
                        // Update the existing item with the new count
                        OrderList.Items[i] = $"espresso {Esspresso}";
                        return; // Exit after updating
                    }
                }

                // If not found, add it as a new item
                OrderList.Items.Add($"espresso {Esspresso}");
            }
        }
    }
}
