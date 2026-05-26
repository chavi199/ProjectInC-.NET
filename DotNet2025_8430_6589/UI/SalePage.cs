using BlApi;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class SalePage : Form
    {
        private readonly IBl bl = Factory.Get();

        public SalePage()
        {
            InitializeComponent();
            LoadSales();
        }

        private void LoadSales()
        {
            try
            {
                SaleList.DataSource = bl.Sale.ReadAll();
            }
            catch (Exception ex) { Utils.Log(ex); MessageBox.Show("Error loading sales: " + ex.Message); }
        }

        private void ReadBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaleList.SelectedRows.Count > 0)
                {
                    var sale = SaleList.SelectedRows[0].DataBoundItem as BO.Sale;
                    MessageBox.Show(sale?.ToString() ?? "Selected sale is null");
                }
            }
            catch (Exception ex) { Utils.Log(ex); MessageBox.Show("Error reading sale: " + ex.Message); }
        }

        private void ReadAllBT_Click(object sender, EventArgs e) { try { LoadSales(); } catch (Exception ex) { Utils.Log(ex); MessageBox.Show(ex.Message); } }

        private void CreateBT_Click(object sender, EventArgs e)
        {
            try
            {
                using var form = new SaleEditForm();
                if (form.ShowDialog() == DialogResult.OK) LoadSales();
            }
            catch (Exception ex) { Utils.Log(ex); MessageBox.Show("Error opening add-sale: " + ex.Message); }
        }

        private void UpdateBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaleList.SelectedRows.Count > 0)
                {
                    var sale = SaleList.SelectedRows[0].DataBoundItem as BO.Sale;
                    if (sale != null)
                    {
                        using var form = new SaleEditForm(sale);
                        if (form.ShowDialog() == DialogResult.OK) LoadSales();
                    }
                }
            }
            catch (Exception ex) { Utils.Log(ex); MessageBox.Show("Error opening update-sale: " + ex.Message); }
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaleList.SelectedRows.Count > 0)
                {
                    var sale = SaleList.SelectedRows[0].DataBoundItem as BO.Sale;
                    if (sale != null)
                    {
                        bl.Sale.Delete(sale.Id);
                        LoadSales();
                    }
                }
            }
            catch (Exception ex) { Utils.Log(ex); MessageBox.Show("Error deleting sale: " + ex.Message); }
        }

        private void SaleFilterBT_Click(object sender, EventArgs e) { try { FilterTB.Focus(); } catch (Exception ex) { Utils.Log(ex); MessageBox.Show(ex.Message); } }

        private void FilterTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(FilterTB.Text, out int productId))
                {
                    var all = bl.Sale.ReadAll();
                    SaleList.DataSource = all.Where(s => s.ProductId == productId).ToList();
                }
                else if (string.IsNullOrWhiteSpace(FilterTB.Text))
                {
                    LoadSales();
                }
            }
            catch (Exception ex) { Utils.Log(ex); MessageBox.Show("Filter error: " + ex.Message); }
        }
    }
}