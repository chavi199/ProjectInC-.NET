using BlApi;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class ProductEditForm : Form
    {
        private readonly IBl _bl = Factory.Get();
        private BO.Product? _product;
        private bool _isEdit;

        public ProductEditForm(BO.Product? product = null)
        {
            InitializeComponent();
            _product = product;
            _isEdit = _product != null;
            if (_isEdit)
            {
                IdTB.Text = _product!.Id.ToString();
                IdTB.ReadOnly = true;
                NameTB.Text = _product.Name;
                PriceTB.Text = _product.Price.ToString();
                AmountTB.Text = _product.Amount.ToString();
                CategoryTB.Text = _product.Category.ToString();
            }
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(NameTB.Text))
                {
                    MessageBox.Show("Name required");
                    return;
                }

                if (!double.TryParse(PriceTB.Text, out double price)) price = 0;
                if (!int.TryParse(AmountTB.Text, out int amount)) amount = 0;

                if (_isEdit)
                {
                    _product!.Name = NameTB.Text;
                    _product.Price = price;
                    _product.Amount = amount;
                    // Category parsing best-effort
                    if (Enum.TryParse<BO.Category>(CategoryTB.Text, out var cat)) _product.Category = cat;
                    _bl.Product.Update(_product);
                }
                else
                {
                    var newP = new BO.Product
                    {
                        Id = int.TryParse(IdTB.Text, out int id) ? id : 0,
                        Name = NameTB.Text,
                        Price = price,
                        Amount = amount
                    };
                    if (Enum.TryParse<BO.Category>(CategoryTB.Text, out var cat2)) newP.Category = cat2;
                    _bl.Product.Create(newP);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show("Error saving product: " + ex.Message);
            }
        }

        private void CancelBT_Click(object sender, EventArgs e) => Close();
    }
}