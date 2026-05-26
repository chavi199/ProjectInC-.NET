using BlApi;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class CustomerPage : Form
    {
        private readonly IBl bl = Factory.Get();

        public CustomerPage()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            try
            {
                CustomerList.DataSource = bl.Customer.ReadAll();
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void ReadBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerList.SelectedRows.Count > 0)
                {
                    var customer = CustomerList.SelectedRows[0].DataBoundItem as BO.Customer;
                    MessageBox.Show(customer?.ToString() ?? "Selected item is null");
                }
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show("Error reading customer: " + ex.Message);
            }
        }

        private void ReadAllBT_Click(object sender, EventArgs e)
        {
            try { LoadCustomers(); }
            catch (Exception ex) { Utils.Log(ex); MessageBox.Show(ex.Message); }
        }

        private void UpdateBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerList.SelectedRows.Count > 0)
                {
                    var customer = CustomerList.SelectedRows[0].DataBoundItem as BO.Customer;
                    if (customer != null)
                    {
                        using var form = new CustomerEditForm(customer);
                        if (form.ShowDialog() == DialogResult.OK) LoadCustomers();
                    }
                }
            }
            catch (Exception ex) { Utils.Log(ex); MessageBox.Show("Error opening update-customer: " + ex.Message); }
        }

        private void CreateBT_Click(object sender, EventArgs e)
        {
            try
            {
                using var form = new CustomerEditForm();
                if (form.ShowDialog() == DialogResult.OK) LoadCustomers();
            }
            catch (Exception ex) { Utils.Log(ex); MessageBox.Show("Error opening add-customer: " + ex.Message); }
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerList.SelectedRows.Count > 0)
                {
                    var customer = CustomerList.SelectedRows[0].DataBoundItem as BO.Customer;
                    if (customer != null)
                    {
                        bl.Customer.Delete(customer.Id);
                        LoadCustomers();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show("Error deleting customer: " + ex.Message);
            }
        }

        private void CustomerFilterBT_Click(object sender, EventArgs e)
        {
            try
            {
                FilterTB.Focus();
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void FilterTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var filter = FilterTB.Text.ToLower();
                var all = bl.Customer.ReadAll();
                CustomerList.DataSource = all.Where(c => c.Name?.ToLower().Contains(filter) == true).ToList();
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show("Filter error: " + ex.Message);
            }
        }
    }
}
