using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hospital
{
    public partial class Registration : Form
    {

        private const string NamePattern = @"^[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+$";
        private const string AddressPattern = @"^[А-ЯЁа-яё0-9\s\.,-]+$";
        private const string PhonePattern = @"^\+7\s\(\d{3}\)\s\d{3}-\d{2}-\d{2}$";
        private const string InsurancePattern = @"^\d{16}$";
        private const string EmailPattern = @"^[A-Za-z0-9_.+-]+@[A-Za-z0-9-]+\.[A-Za-z0-9-.]+$";
        private const string LoginPattern = @"^[A-Za-z0-9_-]{4,16}$";
        private const string PasswordPattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,16}$";

        public Registration()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void RegSubmit_Click(object sender, EventArgs e)
        {
            bool allRight = true;

            var fullname = RegFullname.Text;
            var birthdate = RegBirthdate.Value;
            var address = RegAddress.Text;
            var phoneNumber = RegPhoneNumber.Text;
            var insuranceNumber = RegInsuranceNumber.Text;
            var email = RegEmail.Text;
            var sex = RegSex.SelectedItem == null ? null : RegSex.SelectedItem.ToString();
            var login = RegLogin.Text;
            var password = RegPassword.Text;

            if (string.IsNullOrWhiteSpace(fullname) || !Regex.IsMatch(fullname, NamePattern))
            {
                allRight = false;
                MessageBox.Show(@"Формат ФИО: Фамилия Имя Отчество", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (string.IsNullOrWhiteSpace(address) || !Regex.IsMatch(address, AddressPattern))
            {
                allRight = false;
                MessageBox.Show(@"Формат адреса: Улица, дом, квартира (может включать цифры, буквы, пробелы и знаки препинания)", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (string.IsNullOrWhiteSpace(phoneNumber) || !Regex.IsMatch(phoneNumber, PhonePattern))
            {
                allRight = false;
                MessageBox.Show(@"Формат номера телефона: +7 (XXX) XXX-XX-XX", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (string.IsNullOrWhiteSpace(insuranceNumber) || !Regex.IsMatch(insuranceNumber, InsurancePattern))
            {
                allRight = false;
                MessageBox.Show(@"Формат номера полиса ОМС: Числовой код (16 цифр)", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            
            if (string.IsNullOrWhiteSpace(sex))
            {
                allRight = false;
                MessageBox.Show(@"Выберите пол", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, EmailPattern))
            {
                allRight = false;
                MessageBox.Show(@"Формат электронной почты: example@example.com", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (string.IsNullOrWhiteSpace(login) || !Regex.IsMatch(login, LoginPattern))
            {
                allRight = false;
                MessageBox.Show(@"Формат логина: Латинские буквы, цифры, знаки подчеркивания и дефисы (от 4 до 16 символов)", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (string.IsNullOrWhiteSpace(password) || !Regex.IsMatch(password, PasswordPattern))
            {
                allRight = false;
                MessageBox.Show(@"Формат пароля: Латинские буквы, цифры, специальные символы (от 8 до 16 символов)", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            // connection & inserting data 
            if (allRight)
            {


                string connectionString = "server=127.0.0.1;database=health;uid=root;password=;";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query =
                        "insert into patient (Fullname, Birthdate, Address, PhoneNumber, InsuranceNumber, Email, Sex, Login, Password)" +
                        "VALUES (@Fullname, @Birthdate, @Address, @PhoneNumber, @InsuranceNumber, @Email, @Sex, @Login, @Password)";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Fullname", fullname);
                    cmd.Parameters.AddWithValue("@Birthdate", birthdate);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@InsuranceNumber", insuranceNumber);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Sex", sex);
                    cmd.Parameters.AddWithValue("@Login", login);
                    cmd.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(@"Пользователь успешно зарегистрирован!", @"Успех!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                var loginForm = new Login();
                Hide();
                loginForm.ShowDialog();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginForm = new Login();
            Hide();
            loginForm.ShowDialog();
            Close();
        }
    }
}