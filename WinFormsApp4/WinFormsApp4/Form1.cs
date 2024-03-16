using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Xml;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        string file_name = "EVM.xml";
        XmlTextReader xml_read;
        DataSet DataXML;
        DataTable MyDatatable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataXML = new DataSet();
            FileStream fs = new FileStream(file_name, FileMode.Open);
            xml_read = new XmlTextReader(fs);
            DataXML.ReadXml(xml_read, XmlReadMode.Auto);

            MyDatatable.Columns.Add("Name", typeof(string));
            MyDatatable.Columns.Add("Model", typeof(string));
            MyDatatable.Columns.Add("Frequency", typeof(Double));
            MyDatatable.Columns.Add("OperativeMemory", typeof(Int32));
            MyDatatable.Columns.Add("Price", typeof(Double));
            MyDatatable.Columns.Add("PiecesAmount", typeof(Int32));


            for (int i = 0; i < DataXML.Tables[0].Rows.Count; i++)
            {
                MyDatatable.Rows.Add();
                if (MyDatatable.Columns[0].ColumnName == "Name")
                {
                    MyDatatable.Rows[i][0] = DataXML.Tables[0].Rows[i][0];
                }
                if (MyDatatable.Columns[1].ColumnName == "Model")
                {
                    MyDatatable.Rows[i][1] = DataXML.Tables[0].Rows[i][1];
                }
                MyDatatable.Rows[i][2] = Convert.ToDouble(DataXML.Tables[0].Rows[i][2]);
                MyDatatable.Rows[i][3] = Convert.ToInt32(DataXML.Tables[0].Rows[i][3]);
                MyDatatable.Rows[i][4] = Convert.ToDouble(DataXML.Tables[0].Rows[i][4]);
                MyDatatable.Rows[i][5] = Convert.ToInt32(DataXML.Tables[0].Rows[i][5]);
            }

            bindingSource1.DataMember = MyDatatable.TableName;
            bindingSource1.DataSource = MyDatatable;

            dataGridView1.DataSource = bindingSource1;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[0].HeaderText = "Наименование";

            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[1].HeaderText = "Модель";

            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[2].HeaderText = "Частота";

            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[3].HeaderText = "Объем памяти";

            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[4].HeaderText = "Стоимость";

            dataGridView1.Columns[5].Width = 140;
            dataGridView1.Columns[5].HeaderText = "Количество комплектующих";

            fs.Close();
            dataGridView1.ClearSelection();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBoxSearchModel.Text == string.Empty && textBoxSearchPrice.Text == string.Empty && textBoxSearchModel.Text == string.Empty && textBoxSearchPrice.Text == string.Empty)
            {
                MessageBox.Show("Поля для поиска не могут быть пустыми!");
                return;
            }

            if (textBoxSearchModel.Text != string.Empty && textBoxSearchPrice.Text == string.Empty)
            {
                for (int i = 0; i < DataXML.Tables[0].Rows.Count; i++)
                {
                    if (MyDatatable.Rows[i][1].ToString() == textBoxSearchModel.Text)
                    {
                        textBoxResultModel.Text = MyDatatable.Rows[i][1].ToString();
                        string line = "Наименование: " +
                            MyDatatable.Rows[i][0].ToString() + ", Модель: " + " " +
                            MyDatatable.Rows[i][1].ToString() + ", Частота: " + " " +
                            MyDatatable.Rows[i][2].ToString() + " Hz" + ", Объем памяти: " + " " +
                            MyDatatable.Rows[i][3].ToString() + " GB" + ", Стоимость: " + " " +
                            MyDatatable.Rows[i][4].ToString() + " $" + ", Количество комплектующих:" + " " +
                            MyDatatable.Rows[i][5].ToString();
                        listBox1.Items.Add(line);
                    }
                }
                textBoxResultPrice.Clear();
                textBoxSearchModel.Clear();
            }
            else if (textBoxSearchPrice.Text != string.Empty && textBoxSearchModel.Text == string.Empty)
            {
                for (int i = 0; i < DataXML.Tables[0].Rows.Count; i++)
                {
                    if (MyDatatable.Rows[i][4].ToString() == textBoxSearchPrice.Text)
                    {
                        textBoxResultPrice.Text = MyDatatable.Rows[i][4].ToString();
                        string line = "Наименование: " +
                            MyDatatable.Rows[i][0].ToString() + ", Модель: " + " " +
                            MyDatatable.Rows[i][1].ToString() + ", Частота: " + " " +
                            MyDatatable.Rows[i][2].ToString() + " Hz" + ", Объем памяти: " + " " +
                            MyDatatable.Rows[i][3].ToString() + " GB" + ", Стоимость: " + " " +
                            MyDatatable.Rows[i][4].ToString() + " $" + ", Количество комплектующих:" + " " +
                            MyDatatable.Rows[i][5].ToString();
                        listBox1.Items.Add(line);
                    }
                }
                textBoxResultModel.Clear();
                textBoxSearchPrice.Clear();
            }
            else
            {
                MessageBox.Show("Для поиска по адресу:\n" +
                    "- Заполните поля дом, кв., кол-во комнат.\n" +
                    "\n Для поиска по кол-ву комнат:\n" +
                    "- Заполните кол-во комнат.\n" +
                    "После выполнения одного из двух действий нажмите кнопку << Поиск >>");
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBoxModel.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxFrequency.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + " Hz";
                textBoxPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() + " $";
                textBoxOperativeMemory.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + " GB";
                textBoxPiecesAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
            else
                return;
        }

    }
}