using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hospital
{
    public partial class AppointmentBuilder : Form
    {
        public AppointmentBuilder()
        {
            InitializeComponent();
            MaximizeBox = false;
            label2.Hide();
            listBox2.Hide();
            listBox3.Hide();
            listBox4.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            label3.Hide();
            label4.Hide();
            button8.Hide();

            using (var connection = new MySqlConnection(ConnectionString))
            {
                const string query = "SELECT Name FROM Hospital";
                var command = new MySqlCommand(query, connection);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var hospitalName = reader.GetString("Name");
                        listBox1.Items.Add(hospitalName);
                    }
                }
            }
        }

        private const string ConnectionString = "server=127.0.0.1;database=health;uid=root;password=;";

        private string _selectedHospital, _selectedSpeciality, _selectedDoctor, _selectedAppointment;

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                _selectedHospital = listBox1.SelectedItem.ToString();
                listBox1.Hide();
                button1.Hide();
                List<string> specialties = new List<string>();
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    string query =
                        "SELECT Speciality FROM Doctor WHERE HospitalID = (SELECT HospitalID FROM Hospital WHERE Name = @selectedHospital)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@selectedHospital", _selectedHospital);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string specialty = reader.GetString("Speciality");
                            specialties.Add(specialty);
                        }
                    }
                }

                foreach (var speciality in specialties)
                {
                    listBox2.Items.Add(speciality);
                }

                listBox2.Show();
                button2.Show();

            }
            else
            {
                MessageBox.Show(@"Пожалуйста выберите поликлинику", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                _selectedSpeciality = listBox2.SelectedItem.ToString();
                listBox2.Hide();
                button2.Hide();
                List<string> doctors = new List<string>();
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    string query =
                        "SELECT Fullname FROM Doctor WHERE HospitalID = (SELECT HospitalID FROM Hospital WHERE Name = @selectedHospital)" +
                        "and Speciality = @selectedSpeciality";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@selectedHospital", _selectedHospital);
                    command.Parameters.AddWithValue("@selectedSpeciality", _selectedSpeciality);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string doctor = reader.GetString("Fullname");
                            doctors.Add(doctor);
                        }
                    }
                }

                foreach (var doctor in doctors)
                {
                    listBox3.Items.Add(doctor);
                }

                listBox3.Show();
                button3.Show();
            }
            else
            {
                MessageBox.Show(@"Пожалуйста выберите специализацию", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null)
            {
                _selectedDoctor = listBox3.SelectedItem.ToString();
                listBox3.Hide();
                button3.Hide();
                List<string> appointments = new List<string>();
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    string query =
                        "SELECT AppointmentDate, AppointmentTime FROM Appointment WHERE DoctorID = (SELECT DoctorID FROM Doctor WHERE Fullname = @selectedDoctor) and Availability = 'Да' order by AppointmentDate";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@selectedDoctor", _selectedDoctor);

                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string appointment = reader.GetString("AppointmentDate").Split(' ')[0] + " " +
                                                 reader.GetString("AppointmentTime");
                            appointments.Add(appointment);
                        }
                    }
                }

                foreach (var appointment in appointments)
                {
                    listBox4.Items.Add(appointment);
                }

                listBox4.Show();
                button4.Show();
            }
            else
            {
                MessageBox.Show(@"Пожалуйста выберите врача", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem != null)
            {
                _selectedAppointment = listBox4.SelectedItem.ToString();
                listBox4.Hide();
                button4.Hide();

                label2.Text = @"Вы собираетесь записаться на приём:" +
                              "\nПоликлиника: " + _selectedHospital +
                              "\nВрач: " + _selectedDoctor + @" (" + _selectedSpeciality + @")" +
                              "\nВремя: " + _selectedAppointment;

                button5.Show();
                button6.Show();
                label2.Show();
            }
            else
            {
                MessageBox.Show(@"Пожалуйста выберите время", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var connection = new MySqlConnection(ConnectionString))
            {
                var login = File.ReadAllText("login.txt").Replace("\r", "").Replace("\n", "");

                const string getPatientIdQuery = "SELECT PatientID FROM Patient WHERE Login = @login";
                var getPatientIdCommand = new MySqlCommand(getPatientIdQuery, connection);
                getPatientIdCommand.Parameters.AddWithValue("@login", login);

                const string getHospitalIdQuery = "SELECT HospitalID FROM Hospital WHERE Name = @selectedHospital";
                var getHospitalIdCommand = new MySqlCommand(getHospitalIdQuery, connection);
                getHospitalIdCommand.Parameters.AddWithValue("@selectedHospital", _selectedHospital);

                const string getDoctorIdQuery = "SELECT DoctorID FROM Doctor WHERE Fullname = @selectedDoctor AND HospitalID = @hospitalId";
                var getDoctorIdCommand = new MySqlCommand(getDoctorIdQuery, connection);
                getDoctorIdCommand.Parameters.AddWithValue("@selectedDoctor", _selectedDoctor);

                const string checkAppointmentQuery = "SELECT COUNT(*) FROM Appointment WHERE PatientID = @patientId AND DoctorID = @doctorId";
                var checkAppointmentCommand = new MySqlCommand(checkAppointmentQuery, connection);

                const string updateAppointmentQuery = "UPDATE Appointment SET PatientID = @patientId, Availability = 'Нет' WHERE DoctorID = @doctorId and AppointmentTime = @appointmentTime and AppointmentDate = @appointmentDate";
                var updateAppointmentCommand = new MySqlCommand(updateAppointmentQuery, connection);

                connection.Open();

                string patientId = null;
                using (var reader = getPatientIdCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        patientId = reader["PatientID"].ToString();
                    }
                }

                string hospitalId = null;
                using (var reader = getHospitalIdCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        hospitalId = reader["HospitalID"].ToString();
                    }
                }
                
                
                getDoctorIdCommand.Parameters.AddWithValue("@hospitalId", hospitalId);
                string doctorId = null;
                using (var reader = getDoctorIdCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        doctorId = reader["DoctorID"].ToString();
                    }
                }

                checkAppointmentCommand.Parameters.AddWithValue("@patientId", patientId);
                checkAppointmentCommand.Parameters.AddWithValue("@doctorId", doctorId);
                var appointmentCount = Convert.ToInt32(checkAppointmentCommand.ExecuteScalar());

                if (appointmentCount > 0)
                {
                    MessageBox.Show(@"Вы уже записаны к этому врачу", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var appointmentDateTmp = _selectedAppointment.Split(' ')[0];
                    var appointmentDay = appointmentDateTmp.Split('.')[0];
                    var appointmentMonth = appointmentDateTmp.Split('.')[1];
                    var appointmentYear = appointmentDateTmp.Split('.')[2];
                    var appointmentTime = _selectedAppointment.Split(' ')[1];
                    var appointmentDate = appointmentYear + "-" + appointmentMonth + "-" + appointmentDay;
                    
                    updateAppointmentCommand.Parameters.AddWithValue("@appointmentDate", appointmentDate);
                    updateAppointmentCommand.Parameters.AddWithValue("@appointmentTime", appointmentTime);
                    updateAppointmentCommand.Parameters.AddWithValue("@doctorId", doctorId);
                    updateAppointmentCommand.Parameters.AddWithValue("@patientId", patientId);

                    updateAppointmentCommand.ExecuteNonQuery();

                    MessageBox.Show(@"Успешная запись на прием", @"Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    label2.Hide();
                    button5.Hide();
                    button6.Hide();
                    button7.Hide();
                    
                    label3.Show();
                    label4.Show();
                    button8.Show();
                    
                    const string getPatientNameQuery = "SELECT Fullname FROM Patient WHERE Login = @login";
                    var getPatientNameCommand = new MySqlCommand(getPatientNameQuery, connection);
                    getPatientNameCommand.Parameters.AddWithValue("@login", login);
                    
                    string patientName = null;
                    using (var reader = getPatientNameCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            patientName = reader["FullName"].ToString();
                        }
                    }
                    
                    const string getPatientBirthdateQuery = "SELECT Birthdate FROM Patient WHERE Login = @login";
                    var getPatientBirthdateCommand = new MySqlCommand(getPatientBirthdateQuery, connection);
                    getPatientBirthdateCommand.Parameters.AddWithValue("@login", login);
                    
                    string patientBirthdate = null;
                    using (var reader = getPatientBirthdateCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            patientBirthdate = reader["Birthdate"].ToString();
                        }
                    }
                    
                    const string getPatientInsuranceQuery = "SELECT InsuranceNumber FROM Patient WHERE Login = @login";
                    var getPatientInsuranceCommand = new MySqlCommand(getPatientInsuranceQuery, connection);
                    getPatientInsuranceCommand.Parameters.AddWithValue("@login", login);
                    
                    string patientInsurance = null;
                    using (var reader = getPatientInsuranceCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            patientInsurance = reader["InsuranceNumber"].ToString();
                        }
                    }
                    
                    const string getHospitalAddressQuery = "SELECT Address FROM Hospital WHERE HospitalId = @hospitalId";
                    var getHospitalAddressCommand = new MySqlCommand(getHospitalAddressQuery, connection);
                    getHospitalAddressCommand.Parameters.AddWithValue("@hospitalId", hospitalId);
                    
                    string hospitalAddress = null;
                    using (var reader = getHospitalAddressCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            hospitalAddress = reader["Address"].ToString();
                        }
                    }
                    
                    const string getDoctorRoomQuery = "SELECT RoomNumber FROM Doctor WHERE DoctorId = @doctorId";
                    var getDoctorRoomCommand = new MySqlCommand(getDoctorRoomQuery, connection);
                    getDoctorRoomCommand.Parameters.AddWithValue("@doctorId", doctorId);
                    
                    string doctorRoom = null;
                    using (var reader = getDoctorRoomCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            doctorRoom = reader["RoomNumber"].ToString();
                        }
                    }

                    label4.Text = @"Пациент: " +
                                  "\n\tФИО: " + patientName +
                                  "\n\tДата рождения: " + patientBirthdate.Split(' ')[0] +
                                  "\n\tПолис: " + patientInsurance +
                                  "\n\nПрием:" +
                                  "\n\tДата и время: " + _selectedAppointment +
                                  "\n\tМесто: " + _selectedHospital + @" (" + hospitalAddress + @"), " + @"каб. " + doctorRoom +
                                  "\n\tВрач: " + _selectedDoctor + @" (" + _selectedSpeciality + @")";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var loginForm = new Login();
            Hide();
            loginForm.ShowDialog();
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var appointmentBuilder = new AppointmentBuilder();
            Hide();
            appointmentBuilder.ShowDialog();
            Close();
        }
    }
}
