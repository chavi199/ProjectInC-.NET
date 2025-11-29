namespace Lesson3.c_.net
{
    partial class Screen
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
            data = new DataGridView();
            שם = new DataGridViewTextBoxColumn();
            משפחה = new DataGridViewTextBoxColumn();
            תאריך_לידה = new DataGridViewTextBoxColumn();
            טלפון = new DataGridViewTextBoxColumn();
            מומוצע = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            SuspendLayout();
            // 
            // data
            // 
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Columns.AddRange(new DataGridViewColumn[] { שם, משפחה, תאריך_לידה, טלפון, מומוצע });
            data.Location = new Point(98, 98);
            data.Name = "data";
            data.RowHeadersWidth = 51;
            data.Size = new Size(655, 188);
            data.TabIndex = 0;
            data.CellContentClick += dataGridView1_CellContentClick;
            // 
            // שם
            // 
            שם.DataPropertyName = "firstName";
            שם.HeaderText = "שם";
            שם.MinimumWidth = 6;
            שם.Name = "שם";
            שם.Width = 125;
            // 
            // משפחה
            // 
            משפחה.DataPropertyName = "LestName";
            משפחה.HeaderText = "משפחה";
            משפחה.MinimumWidth = 6;
            משפחה.Name = "משפחה";
            משפחה.Width = 125;
            // 
            // תאריך_לידה
            // 
            תאריך_לידה.DataPropertyName = "BirthDate";
            תאריך_לידה.HeaderText = "תאריך לידה";
            תאריך_לידה.MinimumWidth = 6;
            תאריך_לידה.Name = "תאריך_לידה";
            תאריך_לידה.Width = 125;
            // 
            // טלפון
            // 
            טלפון.DataPropertyName = "PhoneNumber";
            טלפון.HeaderText = "טלפון";
            טלפון.MinimumWidth = 6;
            טלפון.Name = "טלפון";
            טלפון.Width = 125;
            // 
            // מומוצע
            // 
            מומוצע.DataPropertyName = "Avg";
            מומוצע.HeaderText = "ממוצע";
            מומוצע.MinimumWidth = 6;
            מומוצע.Name = "מומוצע";
            מומוצע.Width = 125;
            // 
            // Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(data);
            Name = "Screen";
            Text = "Screen";
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data;
        private DataGridViewTextBoxColumn שם;
        private DataGridViewTextBoxColumn משפחה;
        private DataGridViewTextBoxColumn תאריך_לידה;
        private DataGridViewTextBoxColumn טלפון;
        private DataGridViewTextBoxColumn מומוצע;
    }
}