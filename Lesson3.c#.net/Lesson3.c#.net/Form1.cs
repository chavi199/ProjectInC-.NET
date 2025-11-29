namespace Lesson3.c_.net
{
    public partial class Form1 : Form
    {
        public static Student[] arr_student = new Student[5];
        public static int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentAdd student = new StudentAdd();
            student.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Screen s=new Screen();
            s.Show();
        }
    }
}
