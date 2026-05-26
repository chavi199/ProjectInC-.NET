namespace UI
{
    partial class CustomerEditForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button SaveBT;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox PhoneTB;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            IdTB = new TextBox();
            NameTB = new TextBox();
            SaveBT = new Button();
            CancelBT = new Button();
            AddressTB = new TextBox();
            PhoneTB = new TextBox();
            SuspendLayout();
            // 
            // IdTB
            // 
            IdTB.Location = new Point(20, 20);
            IdTB.Name = "IdTB";
            IdTB.PlaceholderText = "Id (leave 0 to auto)";
            IdTB.Size = new Size(200, 27);
            IdTB.TabIndex = 5;
            IdTB.TextChanged += IdTB_TextChanged;
            // 
            // NameTB
            // 
            NameTB.Location = new Point(20, 60);
            NameTB.Name = "NameTB";
            NameTB.PlaceholderText = "Name";
            NameTB.Size = new Size(200, 27);
            NameTB.TabIndex = 4;
            NameTB.TextChanged += NameTB_TextChanged;
            // 
            // SaveBT
            // 
            SaveBT.Location = new Point(20, 180);
            SaveBT.Name = "SaveBT";
            SaveBT.Size = new Size(90, 30);
            SaveBT.TabIndex = 1;
            SaveBT.Text = "Save";
            SaveBT.UseVisualStyleBackColor = true;
            SaveBT.Click += SaveBT_Click;
            // 
            // CancelBT
            // 
            CancelBT.Location = new Point(130, 180);
            CancelBT.Name = "CancelBT";
            CancelBT.Size = new Size(90, 30);
            CancelBT.TabIndex = 0;
            CancelBT.Text = "Cancel";
            CancelBT.UseVisualStyleBackColor = true;
            CancelBT.Click += CancelBT_Click;
            // 
            // AddressTB
            // 
            AddressTB.Location = new Point(20, 100);
            AddressTB.Name = "AddressTB";
            AddressTB.PlaceholderText = "Address";
            AddressTB.Size = new Size(200, 27);
            AddressTB.TabIndex = 3;
            // 
            // PhoneTB
            // 
            PhoneTB.Location = new Point(20, 140);
            PhoneTB.Name = "PhoneTB";
            PhoneTB.PlaceholderText = "Phone";
            PhoneTB.Size = new Size(200, 27);
            PhoneTB.TabIndex = 2;
            // 
            // CustomerEditForm
            // 
            ClientSize = new Size(250, 220);
            Controls.Add(CancelBT);
            Controls.Add(SaveBT);
            Controls.Add(PhoneTB);
            Controls.Add(AddressTB);
            Controls.Add(NameTB);
            Controls.Add(IdTB);
            Name = "CustomerEditForm";
            Text = "Customer";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}