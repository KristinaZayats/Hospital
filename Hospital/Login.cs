using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hospital
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registration = new Registration();
            this.Hide();
            registration.ShowDialog();
            this.Close();
        }

        private void LogSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;database=hospital;uid=root;password=;";
            
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

                    var idk = new idk();
                    this.Hide();
                    idk.ShowDialog();
                    this.Close();
                    using (StreamWriter writer = new StreamWriter("login.txt"))
                    {
                        writer.WriteLine(login);
                    }
                }
                
                else
                {
                    MessageBox.Show(@"Неверный логин или пароль!", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}