using MySql.Data.MySqlClient;
namespace _1._2
{
    public partial class Form1 : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=test";//підключення до БД
        public Form1()
        {
            InitializeComponent();
            OutputButton.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)//Ввід значень в БД
        {

            string mail = textBox1.Text;
            string name = textBox2.Text;
            string surname = textBox3.Text;
            string telephone = textBox4.Text;

            string query = "INSERT INTO clients (mail, name, surname, telephone) VALUES (@mail, @name, @surname, @telephone)";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@telephone", telephone);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Data added successfully!");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)//вивід значень
        {

            string connectionString = "server=localhost;user=root;password=;database=test";
            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "SELECT * FROM clients";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                listBox1.Items.Clear();
                while (reader.Read())
                {
                    string mail = reader.GetString("mail");
                    string name = reader.GetString("name");
                    string surname = reader.GetString("surname");
                    string telephone = reader.GetString("telephone");
                    listBox1.Items.Add(name + " " + surname + " " + mail + " " + telephone);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)//перевірка підключення
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=test;uid=root;pwd=\"\";";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open!");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)//видалення з БД
        {
            string email = emailTextBox.Text;

            string connectionString = "server=localhost;user=root;password=;database=test";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;

            try
            {
                connection.Open();
                command.CommandText = "DELETE FROM clients WHERE mail = @mail";
                command.Parameters.AddWithValue("@mail", email);
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Deleted " + rowsAffected + " rows.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)//приховування форми 2
        {
            this.Hide(); // Приховуємо поточну форму
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void button5_Click(object sender, EventArgs e)//приховування форми 3
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button6_Click(object sender, EventArgs e)//вхід адмінів
        {
            string expectedUsername = "a";
            string expectedPassword = "a";

            // Створення елементів для введення логіну та пароля
            Label label1 = new Label();
            label1.Text = "Логін:";
            label1.Location = new Point(10, 600);
            this.Controls.Add(label1);

            TextBox textBox1 = new TextBox();
            textBox1.Location = new Point(120, 600);
            this.Controls.Add(textBox1);

            Label label2 = new Label();
            label2.Text = "Пароль:";
            label2.Location = new Point(10, 640);
            this.Controls.Add(label2);

            TextBox textBox2 = new TextBox();
            textBox2.Location = new Point(120, 640);
            textBox2.PasswordChar = '*';
            this.Controls.Add(textBox2);

            Button button2 = new Button();
            button2.Text = "Увійти";
            button2.Location = new Point(10, 670);
            this.Controls.Add(button2);

            // Обробник події для кнопки "Увійти"
            button2.Click += (sender2, e2) =>
            {
                // Перевірка логіна та пароля
                if (textBox1.Text == expectedUsername && textBox2.Text == expectedPassword)
                {
                    MessageBox.Show("Успішний вхід!");
                    OutputButton.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Невірний логін або пароль!");
                }
            };
        }

        private void button2_Click_1(object sender, EventArgs e)//очищення ListBox1
        {
            listBox1.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)//приховування форми 4
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button8_Click(object sender, EventArgs e)//приховування форми 5
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}