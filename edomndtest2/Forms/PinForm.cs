using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace edomndtest2.Forms
{
    public partial class PinForm : Form
    {
        public int UserId { get; private set; }
        public string UserName { get; private set; }
        public string UserSurname { get; private set; }


        public PinForm()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppendToPin("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendToPin("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendToPin("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendToPin("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendToPin("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendToPin("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendToPin("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendToPin("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendToPin("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AppendToPin("0");
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            // Remove the last character
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private async void submitBTN_Click(object sender, EventArgs e)
        {
            string enteredPin = textBox1.Text;
            if (string.IsNullOrEmpty(enteredPin))
            {
                MessageBox.Show("Please enter a PIN.");
                return;
            }

            var users = await GetUsersAsync();
            if (users == null)
            {
                MessageBox.Show("Unable to fetch users. Please try again later.");
                return;
            }

            var user = users.Find(u => u.Password == enteredPin);
            if (user != null)
            {
                UserId = user.Id;
                UserName = user.Name;
                UserSurname = user.Surname;

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid PIN. Please try again.");
            }
        }

        private void AppendToPin(string digit)
        {
            if (textBox1.Text.Length < 6)
            {
                textBox1.Text += digit;
            }
            else
            {
                MessageBox.Show("PIN cannot exceed 6 digits.");
            }
        }

        private async Task<List<User>> GetUsersAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7101");
                    var response = await client.GetAsync("/api/User/GetUsers");
                    response.EnsureSuccessStatusCode();

                    var responseContent = await response.Content.ReadAsStringAsync();
                    var users = JsonSerializer.Deserialize<ApiResponse>(responseContent, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                    return users?.Data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching users: {ex.Message}");
                return null;
            }
        }
    }

    // Classes to map the API response
    public class ApiResponse
    {
        public List<User> Data { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class Role
    {
        public string RoleName { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime Time { get; set; }
    }
}
