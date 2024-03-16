namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }

        private void beginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void workToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = form2.GetText();
            if (text == string.Empty)
            {
                MessageBox.Show("����������, ������� � �������� << Begin >>");
            }
            else
            {
                MessageBox.Show("�������� ���������: \n" + text);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���������, ������������� �����.\n" +
                "������� ������� << Begin >>, ������� ����� � �������� ��� ��� ��������������.\n" +
                "������� << Work >> ��� ������ ����������");
        }
    }
}