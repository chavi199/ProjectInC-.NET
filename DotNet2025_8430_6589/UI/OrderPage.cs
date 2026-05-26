using BlApi;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class OrderPage : Form
    {
        private readonly IBl bl = Factory.Get();

        public OrderPage()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                var orders = OrdersStore.ReadAll();
                if (orders == null || orders.Count == 0)
                {
                    OrderList.DataSource = null;
                    MessageBox.Show("No orders yet. Create orders in the Cashier form.");
                    return;
                }

                OrderList.DataSource = orders;
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }

        private void ReadBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderList.SelectedRows.Count > 0)
                {
                    var order = OrderList.SelectedRows[0].DataBoundItem as BO.Order;
                    if (order == null)
                    {
                        MessageBox.Show("Selected order is null");
                        return;
                    }

                    var sb = new System.Text.StringBuilder();
                    sb.AppendLine($"Preferred customer: {order.IsPreferredCustomer}");
                    sb.AppendLine($"Final price: {order.FinalPrice}");
                    sb.AppendLine("Products:");
                    if (order.Products != null && order.Products.Count > 0)
                    {
                        foreach (var p in order.Products)
                        {
                            sb.AppendLine($" - Id:{p.ProductId} Name:{p.ProductName} Qty:{p.Quantity} Base:{p.BasePrice} Final:{p.FinalPrice}");
                        }
                    }
                    else
                        sb.AppendLine(" (no products)");

                    MessageBox.Show(sb.ToString(), "Order Details");
                }
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show("Error reading order: " + ex.Message);
            }
        }

        private void ReadAllBT_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}