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
    public partial class FormWriteStudent : Form
    {
        public FormWriteStudent()
        {
            InitializeComponent();
        }

        private void FillDataGridViewWhoGo()
        {
            string newConnection = "Server=127.0.0.1;Port=3306;Database=studentconference;User=root;Password=1234";
            MySqlConnection connection = new MySqlConnection(newConnection);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "Select *from `students`";
            MySqlDataReader dataReader = command.ExecuteReader();
            dataGridViewWhoIsWrite.Rows.Clear();

            while (dataReader.Read())
            {
                int idConference = dataReader.GetInt32("idConference");
                string studentName = dataReader.GetString("nameWriter");
                dataGridViewWhoIsWrite.Rows.Add(idConference,studentName);
            }
        }
        private void FillDataGridViewConference()
        {
            string newConnection = "Server=127.0.0.1;Port=3306;Database=studentconference;User=root;Password=1234";
            MySqlConnection connection = new MySqlConnection(newConnection);
            connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "Select *from `conference`";
            MySqlDataReader dataReader = command.ExecuteReader();
            dataGridViewConference.Rows.Clear();

            while (dataReader.Read())
            {
                int id = dataReader.GetInt32("id");
                string theme = dataReader.GetString("theme");
                dataGridViewConference.Rows.Add(id, theme);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string newConnection = "Server=127.0.0.1;Port=3306;Database=studentconference;User=root;Password=1234";
                MySqlConnection connection = new MySqlConnection(newConnection);
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;

                string nameStudent = textBoxNameStudent.Text;
                int idConference = int.Parse(textBoxNumberConference.Text);

                command.CommandText = $"Insert into `students` (`idConference`,`nameWriter`) values ('{idConference}','{nameStudent}')";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Успешно добавлено");
                FillDataGridViewWhoGo();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении");
            }
            
        }

        private void buttonExitToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormWorkWithConference().Show();
        }

        private void buttonWhoWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string newConnection = "Server=127.0.0.1;Port=3306;Database=studentconference;User=root;Password=1234";
                MySqlConnection connection = new MySqlConnection(newConnection);
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;


                int selectedId = int.Parse(textBoxKnowWhoGo.Text);
                command.CommandText = $"Select *from `students` where `idConference`={selectedId}";
                MySqlDataReader dataReader = command.ExecuteReader();
                //command.ExecuteNonQuery();ъ
                dataGridViewWhoIsWrite.Rows.Clear();
                while (dataReader.Read())
                {
                    int idConference = dataReader.GetInt32("idConference");
                    string studentName = dataReader.GetString("nameWriter");
                    dataGridViewWhoIsWrite.Rows.Add(idConference, studentName);
                }
                dataReader.Close();
                connection.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при выборе");
            }
           
           
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string newConnection = "Server=127.0.0.1;Port=3306;Database=studentconference;User=root;Password=1234";
                MySqlConnection connection = new MySqlConnection(newConnection);
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connection;

                int selectedId = int.Parse(dataGridViewWhoIsWrite.SelectedRows[0].Cells[0].Value.ToString());
                command.CommandText = $"delete from `students` where `id`='{selectedId}'";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Успешно удалено");
                FillDataGridViewWhoGo();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при удалении");
            }
            
        }

        private void FormWriteStudent_Load(object sender, EventArgs e)
        {
            FillDataGridViewWhoGo();
            FillDataGridViewConference();
        }
    }
}
