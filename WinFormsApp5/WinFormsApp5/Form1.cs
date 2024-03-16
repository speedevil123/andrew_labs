using System.Numerics;
using System.Threading;
namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private double eps = 1e-6;
        Thread myThread;
        public Form1()
        {
            InitializeComponent();
            textBox3.Text = eps.ToString();
        }

        private BigInteger factorial(int x)
        {
            var fact = new BigInteger(1);
            for (int i = 1; i <= x; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public void rootik()
        {
            string input = textBox2.Text;
            double x;
            double root;
            if (double.TryParse(input, out x))
            {
                int n = 0;
                double sum = 0;
                root = Math.Sqrt(1 + x);
                do
                {
                    sum += (Math.Pow(-1, n) * (double)factorial(2 * n) / ((1 - 2 * n) * Math.Pow((double)factorial(n), 2) * Math.Pow(4, n))) * Math.Pow(x, n); n++;
                } while (Math.Abs(root - sum) > eps);
                UpdateTextBox1(sum.ToString());
                UpdateTextBox2(n.ToString());
                MessageBox.Show("Фоновый поток закончил работу!");
            }
            else
                MessageBox.Show("Данные введены неверно!");
        }

        private void UpdateTextBox1(string text)
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new Action<string>(UpdateTextBox1), text);
            }
            else
            {
                textBox1.Clear();
                textBox1.Text = text;
            }
        }

        private void UpdateTextBox2(string text)
        {
            if (textBox4.InvokeRequired)
            {
                textBox4.Invoke(new Action<string>(UpdateTextBox2), text);
            }
            else
            {
                textBox4.Clear();
                textBox4.Text = text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox4.Clear();
            if (textBox2.Text != null)
            {
                myThread = new Thread(rootik);
                myThread.Start();
            }
            else
                MessageBox.Show("Поле не может быть пустым!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}