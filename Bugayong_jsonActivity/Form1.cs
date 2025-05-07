// Form1.cs
namespace Bugayong_jsonActivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewShoppingList_Click(object sender, EventArgs e)
        {
            ViewShoppingListForm viewForm = new ViewShoppingListForm();
            viewForm.ShowDialog();
        }

        private void btnAddGroceries_Click(object sender, EventArgs e)
        {
            AddGroceriesForm addForm = new AddGroceriesForm();
            addForm.ShowDialog();
        }
    }
}