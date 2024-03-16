namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxModel = new TextBox();
            textBoxFrequency = new TextBox();
            textBoxOperativeMemory = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            bindingSource1 = new BindingSource(components);
            button1 = new Button();
            listBox1 = new ListBox();
            label7 = new Label();
            textBoxPiecesAmount = new TextBox();
            textBoxResultModel = new TextBox();
            textBoxResultPrice = new TextBox();
            textBoxSearchPrice = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBoxSearchModel = new TextBox();
            label16 = new Label();
            dataGridView1 = new DataGridView();
            textBoxPrice = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1009, 114);
            label1.Name = "label1";
            label1.Size = new Size(91, 18);
            label1.TabIndex = 1;
            label1.Text = "По модели";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.ButtonHighlight;
            textBoxName.Location = new Point(40, 63);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(140, 27);
            textBoxName.TabIndex = 2;
            // 
            // textBoxModel
            // 
            textBoxModel.BackColor = SystemColors.ButtonHighlight;
            textBoxModel.Location = new Point(40, 136);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.ReadOnly = true;
            textBoxModel.Size = new Size(140, 27);
            textBoxModel.TabIndex = 3;
            textBoxModel.TextChanged += textBox2_TextChanged;
            // 
            // textBoxFrequency
            // 
            textBoxFrequency.BackColor = SystemColors.ButtonHighlight;
            textBoxFrequency.Location = new Point(252, 136);
            textBoxFrequency.Name = "textBoxFrequency";
            textBoxFrequency.ReadOnly = true;
            textBoxFrequency.Size = new Size(140, 27);
            textBoxFrequency.TabIndex = 4;
            // 
            // textBoxOperativeMemory
            // 
            textBoxOperativeMemory.BackColor = SystemColors.ButtonHighlight;
            textBoxOperativeMemory.Location = new Point(40, 196);
            textBoxOperativeMemory.Name = "textBoxOperativeMemory";
            textBoxOperativeMemory.ReadOnly = true;
            textBoxOperativeMemory.Size = new Size(140, 27);
            textBoxOperativeMemory.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 42);
            label2.Name = "label2";
            label2.Size = new Size(120, 18);
            label2.TabIndex = 6;
            label2.Text = "Наименование";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 114);
            label3.Name = "label3";
            label3.Size = new Size(69, 18);
            label3.TabIndex = 7;
            label3.Text = "Модель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(252, 114);
            label4.Name = "label4";
            label4.Size = new Size(72, 18);
            label4.TabIndex = 8;
            label4.Text = "Частота";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(41, 175);
            label5.Name = "label5";
            label5.Size = new Size(119, 18);
            label5.TabIndex = 9;
            label5.Text = "Объем памяти";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1009, 250);
            button1.Name = "button1";
            button1.Size = new Size(94, 27);
            button1.TabIndex = 12;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(40, 337);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1119, 204);
            listBox1.TabIndex = 15;
            // 
            // label7
            // 
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(252, 19);
            label7.Name = "label7";
            label7.Size = new Size(150, 41);
            label7.TabIndex = 16;
            label7.Text = "Количество комплектующих";
            // 
            // textBoxPiecesAmount
            // 
            textBoxPiecesAmount.BackColor = SystemColors.ButtonHighlight;
            textBoxPiecesAmount.Location = new Point(252, 63);
            textBoxPiecesAmount.Name = "textBoxPiecesAmount";
            textBoxPiecesAmount.ReadOnly = true;
            textBoxPiecesAmount.Size = new Size(140, 27);
            textBoxPiecesAmount.TabIndex = 18;
            // 
            // textBoxResultModel
            // 
            textBoxResultModel.BackColor = SystemColors.ButtonHighlight;
            textBoxResultModel.Location = new Point(761, 307);
            textBoxResultModel.Name = "textBoxResultModel";
            textBoxResultModel.ReadOnly = true;
            textBoxResultModel.Size = new Size(163, 27);
            textBoxResultModel.TabIndex = 24;
            textBoxResultModel.TextChanged += textBox11_TextChanged;
            // 
            // textBoxResultPrice
            // 
            textBoxResultPrice.BackColor = SystemColors.ButtonHighlight;
            textBoxResultPrice.Location = new Point(956, 307);
            textBoxResultPrice.Name = "textBoxResultPrice";
            textBoxResultPrice.ReadOnly = true;
            textBoxResultPrice.Size = new Size(122, 27);
            textBoxResultPrice.TabIndex = 25;
            // 
            // textBoxSearchPrice
            // 
            textBoxSearchPrice.Location = new Point(1009, 217);
            textBoxSearchPrice.Name = "textBoxSearchPrice";
            textBoxSearchPrice.Size = new Size(144, 27);
            textBoxSearchPrice.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(1009, 196);
            label11.Name = "label11";
            label11.Size = new Size(69, 18);
            label11.TabIndex = 27;
            label11.Text = "По цене";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(761, 286);
            label12.Name = "label12";
            label12.Size = new Size(69, 18);
            label12.TabIndex = 28;
            label12.Text = "Модель";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(956, 286);
            label13.Name = "label13";
            label13.Size = new Size(47, 18);
            label13.TabIndex = 29;
            label13.Text = "Цена";
            // 
            // textBoxSearchModel
            // 
            textBoxSearchModel.Location = new Point(1009, 136);
            textBoxSearchModel.Name = "textBoxSearchModel";
            textBoxSearchModel.Size = new Size(161, 27);
            textBoxSearchModel.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(477, 17);
            label16.Name = "label16";
            label16.Size = new Size(203, 21);
            label16.TabIndex = 35;
            label16.Text = "Комплектующие ЭВМ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(461, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(489, 227);
            dataGridView1.TabIndex = 36;
            dataGridView1.CellClick += dataGridView1_CellContentClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = SystemColors.ButtonHighlight;
            textBoxPrice.Location = new Point(252, 196);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(140, 27);
            textBoxPrice.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(252, 175);
            label6.Name = "label6";
            label6.Size = new Size(47, 18);
            label6.TabIndex = 38;
            label6.Text = "Цена";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1182, 553);
            Controls.Add(label6);
            Controls.Add(textBoxPrice);
            Controls.Add(dataGridView1);
            Controls.Add(label16);
            Controls.Add(textBoxSearchModel);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(textBoxSearchPrice);
            Controls.Add(textBoxResultPrice);
            Controls.Add(textBoxResultModel);
            Controls.Add(textBoxPiecesAmount);
            Controls.Add(label7);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxOperativeMemory);
            Controls.Add(textBoxFrequency);
            Controls.Add(textBoxModel);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "14 Вар. БПИ22-02 Петров А.С.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxModel;
        private TextBox textBoxFrequency;
        private TextBox textBoxOperativeMemory;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private BindingSource bindingSource1;
        private Button button1;
        private ListBox listBox1;
        private Label label7;
        private TextBox textBoxPiecesAmount;
        private TextBox textBoxResultModel;
        private TextBox textBoxResultPrice;
        private TextBox textBoxSearchPrice;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBoxSearchModel;
        private Label label16;
        private DataGridView dataGridView1;
        private TextBox textBoxPrice;
        private Label label6;
    }
}