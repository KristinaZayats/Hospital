using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hospital
{
    public partial class idk : Form
    {
        public idk()
        {
            InitializeComponent();
            label2.Hide();
            listBox2.Hide();
            listBox3.Hide();
            listBox4.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT Name FROM Hospital";
                MySqlCommand command = new MySqlCommand(query, connection);

                connection.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string hospitalName = reader.GetString("Name");
                        listBox1.Items.Add(hospitalName);
                    }
                }
            }
        }

        string connectionString = "server=127.0.0.1;database=hospital;uid=root;password=;";

        private string selectedHospital, selectedSpeciality, selectedDoctor, selectedAppointment;

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedHospital = listBox1.SelectedItem.ToString();
                listBox1.Hide();
                button1.Hide();
                List<string> specialties = new List<string>();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query =
                        "SELECT Speciality FROM Doctor WHERE HospitalID = (SELECT HospitalID FROM Hospital WHERE Name = @selectedHospital)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@selectedHospital", selectedHospital);

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
                MessageBox.Show("Пожалуйста выберите поликлинику", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                selectedSpeciality = listBox2.SelectedItem.ToString();
                listBox2.Hide();
                button2.Hide();
                List<string> doctors = new List<string>();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query =
                        "SELECT Fullname FROM Doctor WHERE HospitalID = (SELECT HospitalID FROM Hospital WHERE Name = @selectedHospital)" +
                        "and Speciality = @selectedSpeciality";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@selectedHospital", selectedHospital);
                    command.Parameters.AddWithValue("@selectedSpeciality", selectedSpeciality);

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
                MessageBox.Show("Пожалуйста выберите специализацию", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null)
            {
                selectedDoctor = listBox3.SelectedItem.ToString();
                listBox3.Hide();
                button3.Hide();
                List<string> appointments = new List<string>();
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query =
                        "SELECT AppointmentDate, AppointmentTime FROM Appointment WHERE DoctorID = (SELECT DoctorID FROM Doctor WHERE Fullname = @selectedDoctor) and Availability = 'Да' order by AppointmentDate";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@selectedDoctor", selectedDoctor);

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
                MessageBox.Show("Пожалуйста выберите врача", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem != null)
            {
                selectedAppointment = listBox4.SelectedItem.ToString();
                listBox4.Hide();
                button4.Hide();

                label2.Text = "Вы собираетесь записаться на приём:\n" +
                              "Поликлиника: " + selectedHospital +
                              "\nВрач: " + selectedDoctor + " (" + selectedSpeciality + ")" +
                              "\nВремя: " + selectedAppointment;


                button5.Show();
                button6.Show();
                label2.Show();
            }
            else
            {
                MessageBox.Show("Пожалуйста выберите время", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button5_Click(object sender, EventArgs e)
{
    using (MySqlConnection connection = new MySqlConnection(connectionString))
    {
        string login = File.ReadAllText("login.txt").Replace("\r", "").Replace("\n", "");

        string getPatientIdQuery = "SELECT PatientID FROM Patient WHERE Login = @login";
        MySqlCommand getPatientIdCommand = new MySqlCommand(getPatientIdQuery, connection);
        getPatientIdCommand.Parameters.AddWithValue("@login", login);

        string getHospitalIdQuery = "SELECT HospitalID FROM Hospital WHERE Name = @selectedHospital";
        MySqlCommand getHospitalIdCommand = new MySqlCommand(getHospitalIdQuery, connection);
        getHospitalIdCommand.Parameters.AddWithValue("@selectedHospital", selectedHospital);

        string getDoctorIdQuery = "SELECT DoctorID FROM Doctor WHERE Fullname = @selectedDoctor AND HospitalID = @hospitalId";
        MySqlCommand getDoctorIdCommand = new MySqlCommand(getDoctorIdQuery, connection);
        getDoctorIdCommand.Parameters.AddWithValue("@selectedDoctor", selectedDoctor);

        string checkAppointmentQuery = "SELECT COUNT(*) FROM Appointment WHERE PatientID = @patientId AND DoctorID = @doctorId";
        MySqlCommand checkAppointmentCommand = new MySqlCommand(checkAppointmentQuery, connection);

        string updateAppointmentQuery = "UPDATE Appointment SET PatientID = @patientId, Availability = 'Нет' WHERE DoctorID = @doctorId and AppointmentTime = @appointmentTime and AppointmentDate = @appointmentDate";
        MySqlCommand updateAppointmentCommand = new MySqlCommand(updateAppointmentQuery, connection);

        connection.Open();

        int patientId;

        using (MySqlDataReader reader = getPatientIdCommand.ExecuteReader())
        {
            if (reader.Read())
            {
                patientId = Convert.ToInt32(reader["PatientID"].ToString());
            }
            else
            {
                MessageBox.Show("Пациент не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        int hospitalId = Convert.ToInt32(getHospitalIdCommand.ExecuteScalar());

        getDoctorIdCommand.Parameters.AddWithValue("@hospitalId", hospitalId);
        int doctorId = Convert.ToInt32(getDoctorIdCommand.ExecuteScalar());

        checkAppointmentCommand.Parameters.AddWithValue("@patientId", patientId);
        checkAppointmentCommand.Parameters.AddWithValue("@doctorId", doctorId);
        int appointmentCount = Convert.ToInt32(checkAppointmentCommand.ExecuteScalar());

        if (appointmentCount > 0)
        {
            MessageBox.Show("Вы уже записаны к этому врачу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            updateAppointmentCommand.Parameters.AddWithValue("@appointmentDate", selectedAppointment.Split(' ')[0]);
            updateAppointmentCommand.Parameters.AddWithValue("@appointmentTime", selectedAppointment.Split(' ')[1]);
            updateAppointmentCommand.Parameters.AddWithValue("@doctorId", doctorId);
            updateAppointmentCommand.Parameters.AddWithValue("@patientId", patientId);

            updateAppointmentCommand.ExecuteNonQuery();

            MessageBox.Show("Успешная запись на прием", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
    }
}
