using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hospital
{
    public partial class Registration : Form
    {

        private const string NamePattern = @"^[0-9А-Яа-я\s,._+;()*~'#@!?&-]+$";
        private const string AddressPattern = @"[А-Яа-я0-9'\.\-\s\,]";

        public Registration()
        {
            InitializeComponent();
        }

        private void RegSubmit_Click(object sender, EventArgs e)
        {
            string Fullname = RegFullname.Text;
            DateTime Birthdate = RegBirthdate.Value;
            string Address = RegAddress.Text;
            string PhoneNumber = RegPhoneNumber.Text;
            string InsuranceNumber = RegInsuranceNumber.Text;
            string Email = RegEmail.Text;
            string Sex = RegSex.SelectedItem.ToString();
            string Login = RegLogin.Text;
            string Password = RegPassword.Text;

            if (string.IsNullOrWhiteSpace(Fullname) || !Regex.IsMatch(Fullname, NamePattern))
            {
                throw HospitalException.InvalidNameException(Fullname);
            }

            if (string.IsNullOrWhiteSpace(Address) || !Regex.IsMatch(Address, AddressPattern))
            {
                throw HospitalException.InvalidAddressException(Address);
            }
            
            // connection & inserting data 
            
            string connectionString = "server=127.0.0.1;database=hospital;uid=root;password=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "insert into patient (Fullname, Birthdate, Address, PhoneNumber, InsuranceNumber, Email, Sex, Login, Password)" +
                               "VALUES (@Fullname, @Birthdate, @Address, @PhoneNumber, @InsuranceNumber, @Email, @Sex, @Login, @Password)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Fullname", Fullname);
                cmd.Parameters.AddWithValue("@Birthdate", Birthdate);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                cmd.Parameters.AddWithValue("@InsuranceNumber", InsuranceNumber);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Sex", Sex);
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Password", Password);
                
                connection.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(@"Пользователь успешно зарегистрирован!", @"Успех!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
            var login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}