using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void OfficeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
