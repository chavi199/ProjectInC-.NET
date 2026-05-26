using BlApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class SaleEditForm : Form
    {
        private readonly IBl _bl = Factory.Get();
        private BO.Sale? _sale;
        private bool _isEdit;

        public SaleEditForm(BO.Sale? sale = null)
        {
            InitializeComponent();
            _sale = sale;
            _isEdit = _sale != null;
            if (_isEdit)
            {
                IdTB.Text = _sale!.Id.ToString();
                IdTB.ReadOnly = true;
                ProductIdTB.Text = _sale.ProductId.ToString();
                RequiredQuantityTB.Text = _sale.RequiredQuantity.ToString();
                PriceAfterDiscountTB.Text = _sale.PriceAfterDiscount.ToString();
                IsClubCB.Checked = _sale.IsForClubMemberOnly;
                StartDatePicker.Value = _sale.StartDate;
                EndDatePicker.Value = _sale.EndDate;
            }
            else
            {
                // hide Id in add mode to avoid asking user for auto id
                IdTB.Visible = false;
            }
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(ProductIdTB.Text, out int prodId)) { MessageBox.Show("ProductId required"); return; }
                if (!int.TryParse(RequiredQuantityTB.Text, out int req)) req = 1;
                if (!double.TryParse(PriceAfterDiscountTB.Text, out double price)) price = 0;

                // Validate if Product ID exists in the system
                try
                {
                    var product = _bl.Product.Read(prodId);
                    if (product == null)
                    {
                        ShowAvailableProductsError(prodId);
                        return;
                    }
                }
                catch (Exception)
                {
                    // If BL throws an exception (e.g., product not found), show existing items
                    ShowAvailableProductsError(prodId);
                    return;
                }

                if (_isEdit)
                {
                    _sale!.ProductId = prodId;
                    _sale.RequiredQuantity = req;
                    _sale.PriceAfterDiscount = price;
                    _sale.IsForClubMemberOnly = IsClubCB.Checked;
                    _sale.StartDate = StartDatePicker.Value;
                    _sale.EndDate = EndDatePicker.Value;
                    _bl.Sale.Update(_sale);
                }
                else
                {
                    var s = new BO.Sale
                    {
                        Id = int.TryParse(IdTB.Text, out int id) ? id : 0,
                        ProductId = prodId,
                        RequiredQuantity = req,
                        PriceAfterDiscount = price,
                        IsForClubMemberOnly = IsClubCB.Checked,
                        StartDate = StartDatePicker.Value,
                        EndDate = EndDatePicker.Value
                    };
                    _bl.Sale.Create(s);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show("Error saving sale: " + ex.Message);
            }
        }

        // Helper method to fetch and display valid Product IDs to the user
        // Helper method to fetch and display valid Product IDs and Names to the user
        private void ShowAvailableProductsError(int wrongId)
        {
            // 1. Fetch all existing products from Business Logic layer
            var allProducts = _bl.Product.ReadAll();

            // 2. Format each product as "ID - Name" and put each on a new line
            // Example: "104 - Pearl necklace"
            string productLines = string.Join("\n", allProducts.Select(p => $"{p.Id} - {p.Name}"));

            // 3. Display the detailed warning message box
            MessageBox.Show(
                $"Product with ID {wrongId} does not exist!\n\n" +
                $"Please choose from the existing products:\n" +
                $"-------------------------------------------\n" +
                $"{productLines}",
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        private void CancelBT_Click(object sender, EventArgs e) => Close();
    }
}
//using BlApi;
//using System;
//using System.Windows.Forms;

//namespace UI
//{
//    public partial class SaleEditForm : Form
//    {
//        private readonly IBl _bl = Factory.Get();
//        private BO.Sale? _sale;
//        private bool _isEdit;

//        public SaleEditForm(BO.Sale? sale = null)
//        {
//            InitializeComponent();
//            _sale = sale;
//            _isEdit = _sale != null;
//            if (_isEdit)
//            {
//                IdTB.Text = _sale!.Id.ToString();
//                IdTB.ReadOnly = true;
//                ProductIdTB.Text = _sale.ProductId.ToString();
//                RequiredQuantityTB.Text = _sale.RequiredQuantity.ToString();
//                PriceAfterDiscountTB.Text = _sale.PriceAfterDiscount.ToString();
//                IsClubCB.Checked = _sale.IsForClubMemberOnly;
//                StartDatePicker.Value = _sale.StartDate;
//                EndDatePicker.Value = _sale.EndDate;
//            }
//            else
//            {
//                // hide Id in add mode to avoid asking user for auto id
//                IdTB.Visible = false;
//            }
//        }

//        private void SaveBT_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (!int.TryParse(ProductIdTB.Text, out int prodId)) { MessageBox.Show("ProductId required"); return; }
//                if (!int.TryParse(RequiredQuantityTB.Text, out int req)) req = 1;
//                if (!double.TryParse(PriceAfterDiscountTB.Text, out double price)) price = 0;

//                if (_isEdit)
//                {
//                    _sale!.ProductId = prodId;
//                    _sale.RequiredQuantity = req;
//                    _sale.PriceAfterDiscount = price;
//                    _sale.IsForClubMemberOnly = IsClubCB.Checked;
//                    _sale.StartDate = StartDatePicker.Value;
//                    _sale.EndDate = EndDatePicker.Value;
//                    _bl.Sale.Update(_sale);
//                }
//                else
//                {
//                    var s = new BO.Sale
//                    {
//                        Id = int.TryParse(IdTB.Text, out int id) ? id : 0,
//                        ProductId = prodId,
//                        RequiredQuantity = req,
//                        PriceAfterDiscount = price,
//                        IsForClubMemberOnly = IsClubCB.Checked,
//                        StartDate = StartDatePicker.Value,
//                        EndDate = EndDatePicker.Value
//                    };
//                    _bl.Sale.Create(s);
//                }

//                DialogResult = DialogResult.OK;
//                Close();
//            }
//            catch (Exception ex)
//            {
//                Utils.Log(ex);
//                MessageBox.Show("Error saving sale: " + ex.Message);
//            }
//        }

//        private void CancelBT_Click(object sender, EventArgs e) => Close();
//    }
//}