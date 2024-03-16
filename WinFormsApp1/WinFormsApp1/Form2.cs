using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        string text = string.Empty;
        bool AllLetters = false;
        bool FirstLetter = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            FirstLetter = true;
            AllLetters = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            AllLetters = true;
            FirstLetter = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text == string.Empty)
            {
                MessageBox.Show("Введите текст для преобразования");
            }
            else if (AllLetters)
            {
                text = text.ToUpper();
                Close();
            }
            else if (FirstLetter)
            {
                string temp = text;
                text = string.Empty;
                TextInfo myTI = new CultureInfo("ru-RU", false).TextInfo;
                text = myTI.ToTitleCase(temp);
                Close();
            }
            else
            {
                MessageBox.Show("Выберите каким образом преобразовать текст");
            }
        }

        public string GetText() { return text; }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            text = richTextBox1.Text;
        }
    }
}
