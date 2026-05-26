namespace UI
{
    partial class ProductEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.TextBox CategoryTB;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.Button CancelBT;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            IdTB = new System.Windows.Forms.TextBox();
            NameTB = new System.Windows.Forms.TextBox();
            PriceTB = new System.Windows.Forms.TextBox();
            AmountTB = new System.Windows.Forms.TextBox();
            CategoryTB = new System.Windows.Forms.TextBox();
            SaveBT = new System.Windows.Forms.Button();
            CancelBT = new System.Windows.Forms.Button();
            SuspendLayout();
            // IdTB
            IdTB.Location = new System.Drawing.Point(20, 10);
            IdTB.Size = new System.Drawing.Size(220, 27);
            IdTB.PlaceholderText = "Id (0 to auto)";
            // NameTB
            NameTB.Location = new System.Drawing.Point(20, 45);
            NameTB.Size = new System.Drawing.Size(220, 27);
            NameTB.PlaceholderText = "Name";
            // PriceTB
            PriceTB.Location = new System.Drawing.Point(20, 80);
            PriceTB.Size = new System.Drawing.Size(220, 27);
            PriceTB.PlaceholderText = "Price";
            // AmountTB
            AmountTB.Location = new System.Drawing.Point(20, 115);
            AmountTB.Size = new System.Drawing.Size(220, 27);
            AmountTB.PlaceholderText = "Amount";
            // CategoryTB
            CategoryTB.Location = new System.Drawing.Point(20, 150);
            CategoryTB.Size = new System.Drawing.Size(220, 27);
            CategoryTB.PlaceholderText = "Category (enum)";
            // SaveBT
            SaveBT.Location = new System.Drawing.Point(20, 190);
            SaveBT.Size = new System.Drawing.Size(100, 30);
            SaveBT.Text = "Save";
            SaveBT.Click += SaveBT_Click;
            // CancelBT
            CancelBT.Location = new System.Drawing.Point(140, 190);
            CancelBT.Size = new System.Drawing.Size(100, 30);
            CancelBT.Text = "Cancel";
            CancelBT.Click += CancelBT_Click;
            // Form
            ClientSize = new System.Drawing.Size(260, 240);
            Controls.Add(CancelBT);
            Controls.Add(SaveBT);
            Controls.Add(CategoryTB);
            Controls.Add(AmountTB);
            Controls.Add(PriceTB);
            Controls.Add(NameTB);
            Controls.Add(IdTB);
            Name = "ProductEditForm";
            Text = "Product";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}