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

            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение установлено");
            }
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



            if (userName != "" || userPassword != "")
            {
                
            }
            else
            {
                MessageBox.Show("Заполни поле");
            }
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
