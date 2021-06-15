using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter adapter = null;

        private DataTable dataTable = null;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            dataTable.Clear();


            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["GosExString"].ConnectionString);

            sqlConnection.Open();

            adapter = new SqlDataAdapter("SELECT * FROM Users",sqlConnection);

            dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }
    }
}
