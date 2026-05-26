namespace UI
{
    partial class OrderPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ReadBT = new Button();
            ReadAllBT = new Button();
            OrderList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)OrderList).BeginInit();
            SuspendLayout();
            // 
            // ReadBT
            // 
            ReadBT.Location = new Point(637, 66);
            ReadBT.Name = "ReadBT";
            ReadBT.Size = new Size(94, 29);
            ReadBT.TabIndex = 0;
            ReadBT.Text = "הצג הזמנה";
            ReadBT.UseVisualStyleBackColor = true;
            ReadBT.Click += ReadBT_Click;
            // 
            // ReadAllBT
            // 
            ReadAllBT.Location = new Point(561, 115);
            ReadAllBT.Name = "ReadAllBT";
            ReadAllBT.Size = new Size(170, 29);
            ReadAllBT.TabIndex = 1;
            ReadAllBT.Text = "הצג את כל ההזמנות";
            ReadAllBT.UseVisualStyleBackColor = true;
            ReadAllBT.Click += ReadAllBT_Click;
            // 
            // OrderList
            // 
            OrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderList.Location = new Point(85, 102);
            OrderList.Name = "OrderList";
            OrderList.RowHeadersWidth = 51;
            OrderList.Size = new Size(300, 188);
            OrderList.TabIndex = 7;
            // 
            // OrderPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OrderList);
            Controls.Add(ReadAllBT);
            Controls.Add(ReadBT);
            Name = "OrderPage";
            Text = "Order Page";
            ((System.ComponentModel.ISupportInitialize)OrderList).EndInit();
            ResumeLayout(false);
        }

        //#endregion

        private Button ReadBT;
        private Button ReadAllBT;
        private DataGridView OrderList;
    }
}