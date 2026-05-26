namespace UI
{
    partial class SalePage
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
            DeleteBT = new Button();
            UpdateBT = new Button();
            CreateBT = new Button();
            SaleFilterBT = new Button();
            SaleList = new DataGridView();
            FilterTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)SaleList).BeginInit();
            SuspendLayout();
            // 
            // ReadBT
            // 
            ReadBT.Location = new Point(637, 66);
            ReadBT.Name = "ReadBT";
            ReadBT.Size = new Size(94, 29);
            ReadBT.TabIndex = 0;
            ReadBT.Text = "הצג מבצע";
            ReadBT.UseVisualStyleBackColor = true;
            ReadBT.Click += ReadBT_Click;
            // 
            // ReadAllBT
            // 
            ReadAllBT.Location = new Point(561, 111);
            ReadAllBT.Name = "ReadAllBT";
            ReadAllBT.Size = new Size(170, 29);
            ReadAllBT.TabIndex = 1;
            ReadAllBT.Text = "הצג את כל המבצעים";
            ReadAllBT.UseVisualStyleBackColor = true;
            ReadAllBT.Click += ReadAllBT_Click;
            // 
            // DeleteBT
            // 
            DeleteBT.Location = new Point(637, 156);
            DeleteBT.Name = "DeleteBT";
            DeleteBT.Size = new Size(94, 29);
            DeleteBT.TabIndex = 2;
            DeleteBT.Text = "מחק מבצע";
            DeleteBT.UseVisualStyleBackColor = true;
            DeleteBT.Click += DeleteBT_Click;
            // 
            // UpdateBT
            // 
            UpdateBT.Location = new Point(637, 201);
            UpdateBT.Name = "UpdateBT";
            UpdateBT.Size = new Size(94, 29);
            UpdateBT.TabIndex = 3;
            UpdateBT.Text = "עדכן מבצע";
            UpdateBT.UseVisualStyleBackColor = true;
            UpdateBT.Click += UpdateBT_Click;
            // 
            // CreateBT
            // 
            CreateBT.Location = new Point(637, 251);
            CreateBT.Name = "CreateBT";
            CreateBT.Size = new Size(94, 29);
            CreateBT.TabIndex = 4;
            CreateBT.Text = "הוסף מבצע";
            CreateBT.UseVisualStyleBackColor = true;
            CreateBT.Click += CreateBT_Click;
            // 
            // SaleFilterBT
            // 
            SaleFilterBT.Location = new Point(637, 296);
            SaleFilterBT.Name = "SaleFilterBT";
            SaleFilterBT.Size = new Size(94, 29);
            SaleFilterBT.TabIndex = 5;
            SaleFilterBT.Text = "סנן לפי ID";
            SaleFilterBT.UseVisualStyleBackColor = true;
            SaleFilterBT.Click += SaleFilterBT_Click;
            // 
            // SaleList
            // 
            SaleList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SaleList.Location = new Point(85, 102);
            SaleList.Name = "SaleList";
            SaleList.RowHeadersWidth = 51;
            SaleList.Size = new Size(300, 188);
            SaleList.TabIndex = 7;
            // 
            // FilterTB
            // 
            FilterTB.Location = new Point(85, 296);
            FilterTB.Name = "FilterTB";
            FilterTB.Size = new Size(300, 27);
            FilterTB.TabIndex = 8;
            FilterTB.TextChanged += FilterTB_TextChanged;
            // 
            // SalePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FilterTB);
            Controls.Add(SaleList);
            Controls.Add(SaleFilterBT);
            Controls.Add(CreateBT);
            Controls.Add(UpdateBT);
            Controls.Add(DeleteBT);
            Controls.Add(ReadAllBT);
            Controls.Add(ReadBT);
            Name = "SalePage";
            Text = "Sale Page";
            ((System.ComponentModel.ISupportInitialize)SaleList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        //#endregion

        private Button ReadBT;
        private Button ReadAllBT;
        private Button DeleteBT;
        private Button UpdateBT;
        private Button CreateBT;
        private Button SaleFilterBT;
        private DataGridView SaleList;
        private TextBox FilterTB;
    }
}