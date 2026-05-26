using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ManagerBT_Click(object sender, EventArgs e)
        {
            try
            {
                using var menu = new ManagerMenu();
                menu.ShowDialog();
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show($"Error opening manager menu: {ex.Message}");
            }
        }

        private void EmployeeBT_Click(object sender, EventArgs e)
        {
            try
            {
                using var form = new CashierOrderForm();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                Utils.Log(ex);
                MessageBox.Show($"Error opening cashier form: {ex.Message}");
            }
        }
    }
}
