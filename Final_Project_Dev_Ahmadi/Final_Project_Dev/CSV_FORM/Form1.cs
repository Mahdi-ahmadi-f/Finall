using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace CSV_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show($"Hello {textBox1.Text}{textBox2.Text} , your email is: {textBox3.Text}, your phone is {textBox4.Text}");
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            var first_name = textBox1.Text;
            //var last_name = textBox2.Text;
            //var email = textBox3.Text;
            //var phone = textBox4.Text;
            string file = @".\test.csv";


            //string file = @".\test_file.csv";

            string sep = ",";
            //string[] header = { "Input Value:" };
            string[] data = { first_name };
            StringBuilder s1 = new StringBuilder();

            //s1.AppendLine(string.Join(sep, header));
            s1.AppendLine(string.Join(sep, data));
            try
            {



                File.AppendAllTextAsync(file, s1.ToString());
                MessageBox.Show("Data Saved To CSV");
                textBox1.Clear();






            }
            catch (Exception ex)
            {
                MessageBox.Show("Data couldn't be saved" + ex);

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}