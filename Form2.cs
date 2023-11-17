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

namespace _1._2
{

    public partial class Form2 : Form
    {
        string connectionString = "server=localhost;user=root;password=;database=test";
        string query = "SELECT order_name, customer_name, order_date, description, status FROM orders";
        Dictionary<string, decimal> prices = new Dictionary<string, decimal>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//повернення на попередню форму
        {
            this.Hide(); // приховуємо поточну форму
            Form1 form1 = new Form1(); // створюємо новий екземпляр форми 1
            form1.Show(); // показуємо форму 1
        }

        private void button2_Click(object sender, EventArgs e)//вивід 
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.CommandText = "SELECT order_name, customer_name, order_date, description, status FROM orders";
                    MySqlDataReader reader = command.ExecuteReader();

                    listBox1.Items.Clear();
                    while (reader.Read())
                    {
                        string orderName = reader["order_name"].ToString();
                        string customerName = reader["customer_name"].ToString();
                        string orderDate = DateTime.Parse(reader["order_date"].ToString()).ToString("dd.MM.yy");
                        string description = reader["description"].ToString();
                        string status = reader["status"].ToString();

                        string item = $"Order Name: {orderName}, Customer Name: {customerName}, Order Date: {orderDate}, Status: {status}";

                        listBox1.Items.Add(item);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private int ticketNumber = 0;
        private void button3_Click(object sender, EventArgs e)//купівля білетів
        {
            if (listBox1.SelectedIndex == -1)//перевірка чи вибрав користувач виставку
            {
                MessageBox.Show("Будь ласка, виберіть замовлення!");
                return;
            }
            // Отримати вибраний елемент з listBox1
            string selectedOrder = listBox1.SelectedItem.ToString();

            // Додати одиницю до номеру білету
            ticketNumber++;

            // Відобразити повідомлення "білет успішно куплено"
            MessageBox.Show($"Повторне замовлення №{ticketNumber} : \"{selectedOrder}\" успішно замовлено!");
        }
    }
}
