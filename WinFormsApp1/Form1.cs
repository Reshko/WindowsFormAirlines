using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["GosExString"].ConnectionString);

            sqlConnection.Open();

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            MessageBox.Show("Test");
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
      
            String userName = LoginTextBox.Text.Trim();
            String userPassword = PasswordTextBox.Text.Trim();

            // Проверка на пустоту логина
            if (userName != "")
            {
                SqlCommand sqlCommand = new SqlCommand($"SELECT RoleID FROM Users WHERE Email=@Email",sqlConnection);
                sqlCommand.Parameters.AddWithValue("Email", userName);
                object reade_obj = sqlCommand.ExecuteScalar();

                // Проверка что нам возвращает SELECT
                if (reade_obj != null)
                {
                    string reader = sqlCommand.ExecuteScalar().ToString(); // ID РОЛЬ СОТРУДНИКА

                    // Вытаскиваем пароль по Email
                    SqlCommand sqlPassword = new SqlCommand($"SELECT Password FROM Users WHERE Email=@Email_Users", sqlConnection);
                    sqlPassword.Parameters.AddWithValue("Email_Users", userName);
                    string password_reader = sqlPassword.ExecuteScalar().ToString(); // Password Сотрудника
                    
                    // Проверка на соотвествие пароля в бд и форме
                    if (password_reader.Equals(userPassword))
                    {
                        MessageBox.Show("Совпадают");
                        if (reader.Equals("1"))
                        {
                            new LoginForm().Show();
                            this.Hide();
                        }
                        else
                        {
                            new UserForm().Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не совпадают");
                    }
                }
                else
                {
                    MessageBox.Show("Пустой объект");
                }
            }
            else
            {
                MessageBox.Show("Login пустой");
            }

            //if (userName != "" || userPassword != "")
            //{
                
            //}
            //else
            //{
            //    MessageBox.Show("Заполни поле");
            //}
            //new LoginForm().Show();
            //this.Hide();
        }

        private void linkLabelPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelPassword.Text == "Show")
            {
                PasswordTextBox.PasswordChar = '\0';
                linkLabelPassword.Text = "Hide";

            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
                linkLabelPassword.Text = "Show";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
