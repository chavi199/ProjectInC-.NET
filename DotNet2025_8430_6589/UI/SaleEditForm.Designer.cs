namespace UI
{
    partial class SaleEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox ProductIdTB;
        private System.Windows.Forms.TextBox RequiredQuantityTB;
        private System.Windows.Forms.TextBox PriceAfterDiscountTB;
        private System.Windows.Forms.CheckBox IsClubCB;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
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
            ProductIdTB = new System.Windows.Forms.TextBox();
            RequiredQuantityTB = new System.Windows.Forms.TextBox();
            PriceAfterDiscountTB = new System.Windows.Forms.TextBox();
            IsClubCB = new System.Windows.Forms.CheckBox();
            StartDatePicker = new System.Windows.Forms.DateTimePicker();
            EndDatePicker = new System.Windows.Forms.DateTimePicker();
            SaveBT = new System.Windows.Forms.Button();
            CancelBT = new System.Windows.Forms.Button();
            SuspendLayout();
            // IdTB
            IdTB.Location = new System.Drawing.Point(20, 10);
            IdTB.Size = new System.Drawing.Size(220, 27);
            IdTB.PlaceholderText = "Id (0 to auto)";
            // ProductIdTB
            ProductIdTB.Location = new System.Drawing.Point(20, 45);
            ProductIdTB.Size = new System.Drawing.Size(220, 27);
            ProductIdTB.PlaceholderText = "ProductId";
            // RequiredQuantityTB
            RequiredQuantityTB.Location = new System.Drawing.Point(20, 80);
            RequiredQuantityTB.Size = new System.Drawing.Size(220, 27);
            RequiredQuantityTB.PlaceholderText = "RequiredQuantity";
            // PriceAfterDiscountTB
            PriceAfterDiscountTB.Location = new System.Drawing.Point(20, 115);
            PriceAfterDiscountTB.Size = new System.Drawing.Size(220, 27);
            PriceAfterDiscountTB.PlaceholderText = "PriceAfterDiscount";
            // IsClubCB
            IsClubCB.Location = new System.Drawing.Point(20, 150);
            IsClubCB.Text = "For club members only";
            // StartDatePicker
            StartDatePicker.Location = new System.Drawing.Point(20, 180);
            // EndDatePicker
            EndDatePicker.Location = new System.Drawing.Point(20, 210);
            // SaveBT
            SaveBT.Location = new System.Drawing.Point(20, 245);
            SaveBT.Size = new System.Drawing.Size(100, 30);
            SaveBT.Text = "Save";
            SaveBT.Click += SaveBT_Click;
            // CancelBT
            CancelBT.Location = new System.Drawing.Point(140, 245);
            CancelBT.Size = new System.Drawing.Size(100, 30);
            CancelBT.Text = "Cancel";
            CancelBT.Click += CancelBT_Click;
            // Form
            ClientSize = new System.Drawing.Size(260, 290);
            Controls.Add(CancelBT);
            Controls.Add(SaveBT);
            Controls.Add(EndDatePicker);
            Controls.Add(StartDatePicker);
            Controls.Add(IsClubCB);
            Controls.Add(PriceAfterDiscountTB);
            Controls.Add(RequiredQuantityTB);
            Controls.Add(ProductIdTB);
            Controls.Add(IdTB);
            Name = "SaleEditForm";
            Text = "Sale";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}