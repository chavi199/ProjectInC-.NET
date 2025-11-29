using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3.c_.net
{
    public partial class StudentAdd : Form
    {
        private object firstNameErrorProvider;

        public StudentAdd()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Student s = new Student(); // יוצרים אובייקט חדש
        //    s.firstName = textBox2.Text;
        //    s.lestName = textBox3.Text;
        //    s.PhoneNumber = textBox5.Text;
        //    s.Avg = (double)numericUpDown1.Value;

        //    // שמירה במערך הסטטי של Form1
        //    if (Form1.index < Form1.arr_student.Length)
        //    {
        //        Form1.arr_student[Form1.index] = s;
        //        Form1.index++;
        //    }
        //    else
        //    {
        //        MessageBox.Show("המערך מלא!");
        //    }
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            // בודקים אם יש מקום במערך
            if (Form1.index >= Form1.arr_student.Length)
            {
                MessageBox.Show("המערך מלא! לא ניתן להוסיף עוד תלמידים.");
                return;
            }
            bool flag = false;
            // יוצרים אובייקט חדש מסוג Student
            Student s = new Student(textBox1id.Text);

            s.firstName = textBox2fn.Text;
            s.lestName = textBox3ln.Text;
            s.PhoneNumber = textBox5tl.Text;
            s.BirthDate = dateTimePicker1.Value;
            s.Avg = (double)numericUpDown1.Value;
            try
            {
                s.firstName = textBox2fn.Text;
            }
            catch (Exception ex)
            {
                flag = true;
                firstNameErrorProvider = ex.Message;


            }

            // שמירה במערך הסטטי של Form1
            Form1.arr_student[Form1.index] = s;
            Form1.index++;

            MessageBox.Show("תלמיד נוסף בהצלחה!");
            this.Close(); // סוגרים את החלון אחרי ההוספה
        }


        private void avgg_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 100;
            numericUpDown1.Minimum = 0;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
