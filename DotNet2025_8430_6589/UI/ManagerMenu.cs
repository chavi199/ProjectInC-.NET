using System;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void CustomersBT_Click(object sender, EventArgs e)
        {
            try
            {
                using var page = new CustomerPage();
                page.ShowDialog();
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show($"Error opening customers: {ex.Message}");
            }
        }

        private void ProductsBT_Click(object sender, EventArgs e)
        {
            try
            {
                using var page = new ProductPage();
                page.ShowDialog();
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show($"Error opening products: {ex.Message}");
            }
        }

        private void SalesBT_Click(object sender, EventArgs e)
        {
            try
            {
                using var page = new SalePage();
                page.ShowDialog();
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show($"Error opening sales: {ex.Message}");
            }
        }

        private void OrdersBT_Click(object sender, EventArgs e)
        {
            try
            {
                using var page = new OrderPage();
                page.ShowDialog();
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show($"Error opening orders: {ex.Message}");
            }
        }
    }
}
