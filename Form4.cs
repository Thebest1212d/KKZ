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
    public partial class Form4 : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=test";
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//повернення назад
        {
            this.Hide(); // приховуємо поточну форму
            Form1 form1 = new Form1(); // створюємо новий екземпляр форми 1
            form1.Show(); // показуємо форму 1
        }

        private void button2_Click(object sender, EventArgs e)//Додання постачальників до БД
        {
            string companyName = textBox1.Text;
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            string email = textBox4.Text;
            string phoneNumber = textBox5.Text;
            string servicesAndEquipment = richTextBox1.Text;

            string query = "INSERT INTO Suppliers (CompanyName, FirstName, LastName, Email, PhoneNumber, ServicesAndEquipment) VALUES (@CompanyName, @FirstName, @LastName, @Email, @PhoneNumber, @ServicesAndEquipment)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@CompanyName", companyName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@ServicesAndEquipment", servicesAndEquipment);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ви успішно зареєструвалися!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка: " + ex.Message);
                }
            }
        }
    }
}
