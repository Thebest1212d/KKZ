using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace _1._2
{
    public partial class Form3 : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=test";

        public Form3()
        {
            InitializeComponent();
            // Додати варіанти фільтрування до ComboBox
            comboBox1.Items.Add("service_name");
            comboBox1.Items.Add("description");
            comboBox1.Items.Add("price");
            comboBox1.Items.Add("duration");
            comboBox1.Items.Add("materials");
            comboBox1.Items.Add("required_skills");

            // Встановити значення ComboBox за замовчуванням
            comboBox1.SelectedIndex = 0;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//повернення назад
        {
            this.Hide(); // приховуємо поточну форму
            Form1 form1 = new Form1(); // створюємо новий екземпляр форми 1
            form1.Show(); // показуємо форму 1
        }

        private void button2_Click(object sender, EventArgs e)//пошук у ListBox
        {

            string searchText = searchTextBox.Text;

            // Очищення списку виставкових зали
            exhibitionHallsListBox.Items.Clear();

            // Пошук зали з введеною назвою
            string query = $"SELECT * FROM repair_services WHERE service_name LIKE '%{searchText}%'";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    exhibitionHallsListBox.Items.Add(reader["service_name"].ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//комбо бокс вивід на DataGridView
        {
            // Очистка DataGridView
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Duration", "Duration");
            dataGridView1.Columns.Add("materials", "materials");
            dataGridView1.Columns.Add("required_skills", "required_skills");

            // Підключення до БД
            string connectionString = "server=localhost;user=root;password=;database=test";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Створення команди для вибірки записів з таблиці repair_services, відсортованих за ознакою, вибраною в ComboBox
            string selectedField = comboBox1.SelectedItem.ToString();
            string selectQuery = $"SELECT * FROM repair_services ORDER BY {selectedField}";
            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            // Створення об'єкта для читання даних з БД
            MySqlDataReader reader = command.ExecuteReader();

            // Додавання рядків з таблиці repair_services до DataGridView
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["service_name"].ToString(), reader["description"].ToString(), reader["price"].ToString(), reader["duration"].ToString(), reader["materials"].ToString(), reader["required_skills"].ToString());
            }

            // Закриття з'єднання з БД
            reader.Close();
            connection.Close();
        }

        private void exhibitionHallsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>()
    {
        Image.FromFile("image1.jpg"),
        Image.FromFile("image2.jpg"),
        Image.FromFile("image3.jpg"),
        Image.FromFile("image4.jpg"),
        Image.FromFile("image5.jpg"),
        Image.FromFile("image6.jpg"),
        Image.FromFile("image7.jpg"),
        Image.FromFile("image8.jpg"),
        Image.FromFile("image9.jpg"),
        Image.FromFile("image10.jpg"),
        Image.FromFile("image11.jpg")
    };

            int selectedIndex = exhibitionHallsListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < images.Count)
            {
                pictureBox1.Image = images[selectedIndex];
            }
        }

        private void button3_Click_1(object sender, EventArgs e)//вхід адміна
        {
            string expectedUsername = "a";
            string expectedPassword = "a";

            // Створення елементів для введення логіну та пароля
            Label label1 = new Label();
            label1.Text = "Логін:";
            label1.Location = new Point(10, 740);
            this.Controls.Add(label1);

            TextBox textBox1 = new TextBox();
            textBox1.Location = new Point(120, 740);
            this.Controls.Add(textBox1);

            Label label2 = new Label();
            label2.Text = "Пароль:";
            label2.Location = new Point(10, 780);
            this.Controls.Add(label2);

            TextBox textBox2 = new TextBox();
            textBox2.Location = new Point(120, 780);
            textBox2.PasswordChar = '*';
            this.Controls.Add(textBox2);

            Button button2 = new Button();
            button2.Text = "Увійти";
            button2.Location = new Point(10, 810);
            this.Controls.Add(button2);

            // Обробник події для кнопки "Увійти"
            button2.Click += (sender2, e2) =>
            {
                // Перевірка логіна та пароля
                if (textBox1.Text == expectedUsername && textBox2.Text == expectedPassword)
                {
                    MessageBox.Show("Успішний вхід!");
                    button4.Enabled = true;
                    button5.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Невірний логін або пароль!");
                }
            };
        }

        private void button4_Click(object sender, EventArgs e)//редагування в БД
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string service_name = row.Cells["Name"].Value.ToString();
                            string description = row.Cells["Description"].Value.ToString();
                            decimal price = decimal.Parse(row.Cells["Price"].Value.ToString());
                            int duration = int.Parse(row.Cells["Duration"].Value.ToString());
                            string materials = row.Cells["Materials"].Value.ToString();
                            string required_skills = row.Cells["RequiredSkills"].Value.ToString();

                            string query = "";

                            // Перевіряємо, чи існує послуга з такою назвою
                            string checkQuery = $"SELECT COUNT(*) FROM repair_services WHERE service_name = '{service_name}'";
                            MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                            int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                            if (count > 0) // Якщо послуга з такою назвою існує, оновлюємо її
                            {
                                query = $"UPDATE repair_services SET description = '{description}', price = {price}, duration = {duration}, materials = '{materials}', required_skills = '{required_skills}' WHERE service_name = '{service_name}'";
                            }
                            else // Якщо послуги з такою назвою немає, створюємо нову послугу
                            {
                                query = $"INSERT INTO repair_services (service_name, description, price, duration, materials, required_skills) VALUES ('{service_name}', '{description}', {price}, {duration}, '{materials}', '{required_skills}')";
                            }

                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Зміни успішно збережено!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні змін: " + ex.Message);
            }
        }

        private void LoadData()
        {
            // Очистка DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Duration", "Duration");
            dataGridView1.Columns.Add("materials", "materials");
            dataGridView1.Columns.Add("required_skills", "required_skills");

            // Підключення до БД
            string connectionString = "server=localhost;user=root;password=;database=test";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Створення команди для вибірки записів з таблиці repair_services, відсортованих за ознакою, вибраною в ComboBox
            string selectedField = comboBox1.SelectedItem.ToString();
            string selectQuery = $"SELECT * FROM repair_services ORDER BY {selectedField}";
            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            // Створення об'єкта для читання даних з БД
            MySqlDataReader reader = command.ExecuteReader();

            // Додавання рядків з таблиці repair_services до DataGridView
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["service_name"].ToString(), reader["description"].ToString(), reader["price"].ToString(), reader["duration"].ToString(), reader["materials"].ToString(), reader["required_skills"].ToString());
            }

            // Закриття з'єднання з БД
            reader.Close();
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)//видалення з БД 
        {
            // Отримуємо назву з текстового поля
            string service_name = textBox1.Text;

            // Встановлюємо підключення до БД
            using (var connection = new MySqlConnection(connectionString))
            {
                // Виконуємо запит на видалення запису з таблиці repair_services
                var query = "DELETE FROM repair_services WHERE service_name = @name";
                using (var command = new MySqlCommand(query, connection))
                {
                    // Додаємо параметр
                    command.Parameters.AddWithValue("@name", service_name);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Запис успішно видалено", "Успіх");
                    }
                    else
                    {
                        MessageBox.Show("Запис не було видалено", "Помилка");
                    }
                }
            }

            // Оновлюємо дані в dataGridView1
            LoadData();
        }


    }
}
