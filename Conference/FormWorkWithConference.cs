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

namespace Conference
{
    public partial class FormWorkWithConference : Form
    {
        public FormWorkWithConference()
        {
            InitializeComponent();
        }

       
        private void FillDataGridView()
        {
            string newConnection = "Server=127.0.0.1;Port=3306;Database=studentconference;User=root;Password=1234";
            MySqlConnection connection = new MySqlConnection(newConnection);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * from `conference`";
            MySqlDataReader dataReader = command.ExecuteReader();

            dataGridViewConference.Rows.Clear();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32("id");
                string theme = dataReader.GetString("theme");
                string subject = dataReader.GetString("subject");
                DateTime time = dataReader.GetDateTime("time");
                int roomNumber = dataReader.GetInt32("roomNumber");
                string supervisor = dataReader.GetString("supervisor");
                string nameStudent = dataReader.GetString("nameStudent");

                dataGridViewConference.Rows.Add(id, theme, subject, time, roomNumber, supervisor, nameStudent);
            }
            dataReader.Close();
            connection.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxThemeName.Text==String.Empty||textBoxSubjectName.Text==String.Empty||maskedTextBox1.Text==String.Empty||textBoxRoomNumber.Text==String.Empty||textBoxSupervisor.Text==String.Empty||textBoxStudentName.Text==String.Empty)
                {
                    MessageBox.Show("Заполните все поля");
                    return;
                }
                string newConnection = "Server=127.0.0.1;Port=3306;Database=studentconference;User=root;Password=1234";
                MySqlConnection connection = new MySqlConnection(newConnection);
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;

                string theme = textBoxThemeName.Text;
                string subject = textBoxStudentName.Text;
                DateTime time = DateTime.Parse(maskedTextBox1.Text);
                int roomNumber = int.Parse(textBoxRoomNumber.Text);
                string supervisor = textBoxSupervisor.Text;
                string nameStudent = textBoxStudentName.Text;

                command.CommandText = $"Insert into `conference` (`theme`,`subject`,`time`,`roomNumber`,`supervisor`,`nameStudent`)Values('{theme}','{subject}','{time.ToString("yyyy-MM-dd HH:mm:ss")}', '{roomNumber}','{supervisor}','{nameStudent}')";

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Успешно добавлено");
                FillDataGridView();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении");
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string newConnection = "Server=127.0.0.1;Port=3306;Database=studentconference;User=root;Password=1234";
                MySqlConnection connection = new MySqlConnection(newConnection);
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;

                int selectedId = int.Parse(dataGridViewConference.SelectedRows[0].Cells[0].Value.ToString());
                command.CommandText = $"Delete from `conference` where id={selectedId}";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Успешно удалено");
                FillDataGridView();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при удалении");
            }
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string newConnection = "Server=127.0.0.1;Port=3306;Database=studentconference;User=root;Password=1234";
                MySqlConnection connection = new MySqlConnection(newConnection);
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;
                int selectedId = int.Parse(dataGridViewConference.SelectedRows[0].Cells[0].Value.ToString());


                string themeName = textBoxThemeName.Text;
                string subjectName = textBoxSubjectName.Text;
                DateTime timeSet = DateTime.Parse(maskedTextBox1.Text);
                int roomNumber = int.Parse(textBoxRoomNumber.Text);
                string supervisorName = textBoxSupervisor.Text;
                string nameStudent = textBoxStudentName.Text;

                command.CommandText = $"update `conference` set  `theme`='{themeName}',`subject`='{subjectName}',`time`='{timeSet.ToString("yyyy-MM-dd HH:mm:ss")}',`roomNumber`='{roomNumber}',`supervisor`='{supervisorName}',`nameStudent`='{nameStudent}' where `id`= '{selectedId}'";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Успешно изменено");
                FillDataGridView();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при изменении");
            }
         
        }

        private void buttonWriteStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormWriteStudent().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            
        }
        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxThemeName.Clear();
            textBoxSubjectName.Clear();
            maskedTextBox1.Clear();
            textBoxRoomNumber.Clear();
            textBoxSupervisor.Clear();
            textBoxStudentName.Clear();
        }

        private void dataGridViewConference_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewConference.SelectedRows[0];
                textBoxThemeName.Text = row.Cells[1].Value.ToString();
                textBoxSubjectName.Text = row.Cells[2].Value.ToString();
                maskedTextBox1.Text = row.Cells[3].Value.ToString();
                textBoxRoomNumber.Text = row.Cells[4].Value.ToString();
                textBoxSupervisor.Text = row.Cells[5].Value.ToString();
                textBoxStudentName.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите конференцию");
            }
        }
    }
}
