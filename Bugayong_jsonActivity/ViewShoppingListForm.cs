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
    public partial class ViewShoppingListForm : Form
    {
        public ViewShoppingListForm()
        {
            InitializeComponent();
        }

        private void ViewShoppingListForm_Load(object sender, EventArgs e)
        {
            LoadShoppingList();
        }

        private void LoadShoppingList()
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "C:\\IPT\\BugayongXyrex_json_activity\\Bugayong_jsonActivity\\Bugayong_jsonActivity\\jsonfile\\shoppinglist.json");

                if (File.Exists(filePath))
                {
                    string jsonContent = File.ReadAllText(filePath);
                    List<GroceryItem> items = JsonConvert.DeserializeObject<List<GroceryItem>>(jsonContent);

                    if (items != null && items.Count > 0)
                    {
                        // Clear existing items
                        listBoxItems.Items.Clear();

                        // Add items to the ListBox
                        foreach (var item in items)
                        {
                            listBoxItems.Items.Add($"{item.Name} - ₱{item.Price:F2} (Quantity: {item.Quantity})");
                        }

                        lblItemCount.Text = $"Total Items: {items.Count}";
                    }
                    else
                    {
                        MessageBox.Show("No items found in the shopping list.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Shopping list file not found at: " + filePath, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading shopping list: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Define the model class for grocery items
    public class GroceryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}