using BlApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CustomerPage : Form
    {
        private readonly IBl bl=Factory.Get();
        public CustomerPage()
        {
            InitializeComponent();
            try
            {
                CustomerList.DataSource = bl.Customer.ReadAll();
            }
            catch { MessageBox.Show("Error loading customers"); }
        }

        private void ReadBT_Click(object sender, EventArgs e)
        {


        }
    }
}
