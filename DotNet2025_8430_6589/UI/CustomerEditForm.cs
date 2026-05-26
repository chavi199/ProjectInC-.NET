using BlApi;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class CustomerEditForm : Form
    {
        private readonly IBl _bl = Factory.Get();
        private BO.Customer? _customer;
        private bool _isEdit;

        public CustomerEditForm(BO.Customer? customer = null)
        {
            InitializeComponent();
            _customer = customer;
            _isEdit = _customer != null;
            if (_isEdit)
            {
                IdTB.Text = _customer!.Id.ToString();
                IdTB.ReadOnly = true;
                NameTB.Text = _customer.Name;
                AddressTB.Text = _customer.Address;
                PhoneTB.Text = _customer.Phone;
            }
            else
            {
                // default placeholders for add mode
                IdTB.Text = "";
            }
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NameTB.Text))
                {
                    MessageBox.Show("Name is required");
                    return;
                }

                if (_isEdit)
                {
                    _customer!.Name = NameTB.Text;
                    _customer.Address = AddressTB.Text;
                    _customer.Phone = PhoneTB.Text;
                    _bl.Customer.Update(_customer);
                }
                else
                {
                    var newCustomer = new BO.Customer
                    {
                        Id = int.TryParse(IdTB.Text, out int id) ? id : 0,
                        Name = NameTB.Text,
                        Address = AddressTB.Text,
                        Phone = PhoneTB.Text
                    };
                    _bl.Customer.Create(newCustomer);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show("Error saving customer: " + ex.Message);
            }
        }

        private void CancelBT_Click(object sender, EventArgs e) => Close();

        private void IdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}