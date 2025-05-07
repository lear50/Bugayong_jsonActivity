using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Bugayong_jsonActivity
{
    public partial class AddGroceriesForm : Form
    {
        private const int MAX_ITEMS = 5;
        private List<GroceryItem> groceryItems;

        public AddGroceriesForm()
        {
            InitializeComponent();
            groceryItems = new List<GroceryItem>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Please enter an item name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtPrice.Text, out double price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int quantity = (int)numQuantity.Value;

            if (groceryItems.Count >= MAX_ITEMS)
            {
                MessageBox.Show($"Maximum {MAX_ITEMS} items allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new item
            GroceryItem item = new GroceryItem
            {
                Id = groceryItems.Count + 1,
                Name = txtItemName.Text.Trim(),
                Price = price,
                Quantity = quantity
            };

            // Add to list
            groceryItems.Add(item);

            // Display in ListBox
            listBoxItems.Items.Add($"{item.Name} - ₱{item.Price:F2} (Quantity: {item.Quantity})");

            // Update counter
            lblItemCount.Text = $"Items: {groceryItems.Count}/{MAX_ITEMS}";

            // Clear input fields
            txtItemName.Clear();
            txtPrice.Clear();
            numQuantity.Value = 1;
            txtItemName.Focus();

            // Enable or disable buttons based on item count
            btnAdd.Enabled = groceryItems.Count < MAX_ITEMS;
            btnSave.Enabled = groceryItems.Count > 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (groceryItems.Count == 0)
            {
                MessageBox.Show("Please add at least one item before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string filePath = Path.Combine(Application.StartupPath, "C:\\IPT\\BugayongXyrex_json_activity\\Bugayong_jsonActivity\\Bugayong_jsonActivity\\jsonfile\\shoppinglist.json");
                string json = JsonConvert.SerializeObject(groceryItems, Formatting.Indented);
                File.WriteAllText(filePath, json);

                MessageBox.Show($"Grocery list saved successfully to {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving grocery list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddGroceriesForm_Load(object sender, EventArgs e)
        {
            // Initialize the form
            lblItemCount.Text = $"Items: 0/{MAX_ITEMS}";
            btnSave.Enabled = false;
        }
    }
}