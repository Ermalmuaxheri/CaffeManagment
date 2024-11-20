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
            HotMenu.Visible = false;
            ColdMenu.Visible = false;

        }

        private void HotBtn_Click(object sender, EventArgs e)
        {
            //HotOrCold.Visible = false;
            //HotBtn.Visible = false;
            //ColdBtn.Visible = false;
            HotMenu.Visible = true;
            ColdMenu.Visible = false;
        }

        private void ColdBtn_Click(object sender, EventArgs e)
        {
            //HotBtn.Visible = false;
            //ColdBtn.Visible = false;
            ColdMenu.Visible = true;
            HotMenu.Visible = false;
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
        private void button1_Click(object sender, EventArgs e)
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
