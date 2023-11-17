namespace _1._2
{
    partial class Form3
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
            button1 = new Button();
            button2 = new Button();
            searchTextBox = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            exhibitionHallsListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(834, 670);
            button1.Name = "button1";
            button1.Size = new Size(108, 47);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1431, 103);
            button2.Name = "button2";
            button2.Size = new Size(123, 55);
            button2.TabIndex = 2;
            button2.Text = "Пошук";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(584, 120);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(229, 23);
            searchTextBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(1433, 226);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(834, 366);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(720, 259);
            dataGridView1.TabIndex = 5;
            // 
            // exhibitionHallsListBox
            // 
            exhibitionHallsListBox.FormattingEnabled = true;
            exhibitionHallsListBox.ItemHeight = 15;
            exhibitionHallsListBox.Location = new Point(834, 103);
            exhibitionHallsListBox.Name = "exhibitionHallsListBox";
            exhibitionHallsListBox.Size = new Size(535, 184);
            exhibitionHallsListBox.TabIndex = 1;
            exhibitionHallsListBox.SelectedIndexChanged += exhibitionHallsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1446, 208);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 6;
            label1.Text = "Фільтрування за";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(643, 102);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 7;
            label2.Text = "Введіть для пошуку";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(33, 165);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(780, 552);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(1294, 664);
            button3.Name = "button3";
            button3.Size = new Size(119, 53);
            button3.TabIndex = 9;
            button3.Text = "Вхід адмінів";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(1430, 664);
            button4.Name = "button4";
            button4.Size = new Size(119, 53);
            button4.TabIndex = 10;
            button4.Text = "Змінити дані";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(1271, 737);
            button5.Name = "button5";
            button5.Size = new Size(119, 53);
            button5.TabIndex = 11;
            button5.Text = "Видалити послугу";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1090, 737);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 12;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1591, 968);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(searchTextBox);
            Controls.Add(button2);
            Controls.Add(exhibitionHallsListBox);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox searchTextBox;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ListBox exhibitionHallsListBox;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
    }
}