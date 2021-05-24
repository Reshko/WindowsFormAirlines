using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
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

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
