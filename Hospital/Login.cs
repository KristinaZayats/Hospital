using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hospital
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registration = new Registration();
            Hide();
            registration.ShowDialog();
            Close();
        }

        private void LogSubmit_Click(object sender, EventArgs e)
        {
            if (File.Exists("login.txt"))
            {
                File.Delete("login.txt");
            }
            string connectionString = "server=127.0.0.1;database=health;uid=root;password=;";
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string login = LogLogin.Text;
                string password = LogPassword.Text;

                string query = "SELECT COUNT(*) FROM patient WHERE Login = @Login AND Password = @Password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show(@"Вход выполнен успешно!", @"Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    using (StreamWriter writer = new StreamWriter("login.txt"))
                    {
                        writer.WriteLine(login);
                    }
                    var appointmentBuilder = new AppointmentBuilder();
                    Hide();
                    appointmentBuilder.ShowDialog();
                    Close();
                }
                
                else
                {
                    MessageBox.Show(@"Неверный логин или пароль!", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}