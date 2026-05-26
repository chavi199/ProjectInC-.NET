namespace UI
{
    partial class ProductPage
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
            ProductFilterBT = new Button();
            ProductList = new DataGridView();
            FilterTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ProductList).BeginInit();
            SuspendLayout();
            // 
            // ReadBT
            // 
            ReadBT.Location = new Point(637, 66);
            ReadBT.Name = "ReadBT";
            ReadBT.Size = new Size(94, 29);
            ReadBT.TabIndex = 0;
            ReadBT.Text = "הצג מוצר";
            ReadBT.UseVisualStyleBackColor = true;
            ReadBT.Click += ReadBT_Click;
            // 
            // ReadAllBT
            // 
            ReadAllBT.Location = new Point(561, 111);
            ReadAllBT.Name = "ReadAllBT";
            ReadAllBT.Size = new Size(170, 29);
            ReadAllBT.TabIndex = 1;
            ReadAllBT.Text = "הצג את כל המוצרים";
            ReadAllBT.UseVisualStyleBackColor = true;
            ReadAllBT.Click += ReadAllBT_Click;
            // 
            // DeleteBT
            // 
            DeleteBT.Location = new Point(637, 156);
            DeleteBT.Name = "DeleteBT";
            DeleteBT.Size = new Size(94, 29);
            DeleteBT.TabIndex = 2;
            DeleteBT.Text = "מחק מוצר";
            DeleteBT.UseVisualStyleBackColor = true;
            DeleteBT.Click += DeleteBT_Click;
            // 
            // UpdateBT
            // 
            UpdateBT.Location = new Point(637, 201);
            UpdateBT.Name = "UpdateBT";
            UpdateBT.Size = new Size(94, 29);
            UpdateBT.TabIndex = 3;
            UpdateBT.Text = "עדכן מוצר";
            UpdateBT.UseVisualStyleBackColor = true;
            UpdateBT.Click += UpdateBT_Click;
            // 
            // CreateBT
            // 
            CreateBT.Location = new Point(637, 251);
            CreateBT.Name = "CreateBT";
            CreateBT.Size = new Size(94, 29);
            CreateBT.TabIndex = 4;
            CreateBT.Text = "הוסף מוצר";
            CreateBT.UseVisualStyleBackColor = true;
            CreateBT.Click += CreateBT_Click;
            // 
            // ProductFilterBT
            // 
            ProductFilterBT.Location = new Point(637, 296);
            ProductFilterBT.Name = "ProductFilterBT";
            ProductFilterBT.Size = new Size(94, 29);
            ProductFilterBT.TabIndex = 5;
            ProductFilterBT.Text = "סנן לפי שם";
            ProductFilterBT.UseVisualStyleBackColor = true;
            ProductFilterBT.Click += ProductFilterBT_Click;
            // 
            // ProductList
            // 
            ProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductList.Location = new Point(85, 102);
            ProductList.Name = "ProductList";
            ProductList.RowHeadersWidth = 51;
            ProductList.Size = new Size(300, 188);
            ProductList.TabIndex = 7;
            // 
            // FilterTB
            // 
            FilterTB.Location = new Point(85, 296);
            FilterTB.Name = "FilterTB";
            FilterTB.Size = new Size(300, 27);
            FilterTB.TabIndex = 8;
            FilterTB.TextChanged += FilterTB_TextChanged;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FilterTB);
            Controls.Add(ProductList);
            Controls.Add(ProductFilterBT);
            Controls.Add(CreateBT);
            Controls.Add(UpdateBT);
            Controls.Add(DeleteBT);
            Controls.Add(ReadAllBT);
            Controls.Add(ReadBT);
            Name = "ProductPage";
            Text = "Product Page";
            ((System.ComponentModel.ISupportInitialize)ProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        //#endregion

        private Button ReadBT;
        private Button ReadAllBT;
        private Button DeleteBT;
        private Button UpdateBT;
        private Button CreateBT;
        private Button ProductFilterBT;
        private DataGridView ProductList;
        private TextBox FilterTB;
    }
}