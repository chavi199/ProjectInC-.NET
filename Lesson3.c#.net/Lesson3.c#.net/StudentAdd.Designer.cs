namespace Lesson3.c_.net
{
    partial class StudentAdd
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1id = new TextBox();
            textBox2fn = new TextBox();
            textBox3ln = new TextBox();
            textBox5tl = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(594, 107);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "תז";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(579, 152);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "שם פרטי";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 195);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "שם משפחה";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(582, 232);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "תאריך לידה";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(582, 271);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 4;
            label5.Text = "מספר טלפון";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(594, 321);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 5;
            label6.Text = "ממוצע";
            // 
            // textBox1id
            // 
            textBox1id.Location = new Point(422, 107);
            textBox1id.Name = "textBox1id";
            textBox1id.Size = new Size(125, 27);
            textBox1id.TabIndex = 6;
            // 
            // textBox2fn
            // 
            textBox2fn.Location = new Point(422, 149);
            textBox2fn.Name = "textBox2fn";
            textBox2fn.Size = new Size(125, 27);
            textBox2fn.TabIndex = 7;
            // 
            // textBox3ln
            // 
            textBox3ln.Location = new Point(422, 195);
            textBox3ln.Name = "textBox3ln";
            textBox3ln.Size = new Size(125, 27);
            textBox3ln.TabIndex = 8;
            // 
            // textBox5tl
            // 
            textBox5tl.Location = new Point(422, 271);
            textBox5tl.Name = "textBox5tl";
            textBox5tl.Size = new Size(125, 27);
            textBox5tl.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(297, 232);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(265, 346);
            button1.Name = "button1";
            button1.Size = new Size(260, 79);
            button1.TabIndex = 12;
            button1.Text = "שמור";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(422, 314);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.Value = new decimal(new int[] { 90, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(372, 42);
            label7.Name = "label7";
            label7.Size = new Size(175, 20);
            label7.TabIndex = 14;
            label7.Text = "תרגיל סוגי שדות במחלקה";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(411, 62);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 15;
            label8.Text = "הוספת תלמיד";
            label8.Click += label8_Click;
            // 
            // StudentAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5tl);
            Controls.Add(textBox3ln);
            Controls.Add(textBox2fn);
            Controls.Add(textBox1id);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentAdd";
            Text = "StudentAdd";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1id;
        private TextBox textBox2fn;
        private TextBox textBox3ln;
        private TextBox textBox5tl;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Label label8;
    }
}