namespace UI
{
    partial class ManagerMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CustomersBT = new Button();
            ProductsBT = new Button();
            SalesBT = new Button();
            SuspendLayout();
            // 
            // CustomersBT
            // 
            CustomersBT.Location = new Point(520, 170);
            CustomersBT.Name = "CustomersBT";
            CustomersBT.Size = new Size(157, 97);
            CustomersBT.TabIndex = 0;
            CustomersBT.Text = "לקוחות";
            CustomersBT.UseVisualStyleBackColor = true;
            // 
            // ProductsBT
            // 
            ProductsBT.Location = new Point(332, 171);
            ProductsBT.Name = "ProductsBT";
            ProductsBT.Size = new Size(162, 94);
            ProductsBT.TabIndex = 1;
            ProductsBT.Text = "מוצרים";
            ProductsBT.UseVisualStyleBackColor = true;
            // 
            // SalesBT
            // 
            SalesBT.Location = new Point(146, 171);
            SalesBT.Name = "SalesBT";
            SalesBT.Size = new Size(165, 94);
            SalesBT.TabIndex = 2;
            SalesBT.Text = "מבצעים";
            SalesBT.UseVisualStyleBackColor = true;
            // 
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SalesBT);
            Controls.Add(ProductsBT);
            Controls.Add(CustomersBT);
            Name = "ManagerMenu";
            Text = "ManagerMenu";
            Load += ManagerMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button CustomersBT;
        private Button ProductsBT;
        private Button SalesBT;
    }
}