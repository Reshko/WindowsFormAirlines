
namespace WinFormsApp1
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.OfficeComboBox = new System.Windows.Forms.ComboBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.OfficeLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.BirthdateTextBox = new System.Windows.Forms.TextBox();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(266, 457);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(94, 29);
            this.CancelBtn.TabIndex = 25;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(111, 457);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(94, 29);
            this.SaveBtn.TabIndex = 24;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // OfficeComboBox
            // 
            this.OfficeComboBox.FormattingEnabled = true;
            this.OfficeComboBox.Items.AddRange(new object[] {
            "All office",
            "Moscow",
            "Kiev",
            "Minsk"});
            this.OfficeComboBox.Location = new System.Drawing.Point(191, 285);
            this.OfficeComboBox.Name = "OfficeComboBox";
            this.OfficeComboBox.Size = new System.Drawing.Size(181, 28);
            this.OfficeComboBox.TabIndex = 21;
            this.OfficeComboBox.SelectedIndexChanged += new System.EventHandler(this.OfficeComboBox_SelectedIndexChanged);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(191, 213);
            this.LastNameTextBox.Multiline = true;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(181, 34);
            this.LastNameTextBox.TabIndex = 20;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(191, 136);
            this.FirstNameTextBox.Multiline = true;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(181, 34);
            this.FirstNameTextBox.TabIndex = 19;
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.Location = new System.Drawing.Point(191, 60);
            this.EmailAddressTextBox.Multiline = true;
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(181, 34);
            this.EmailAddressTextBox.TabIndex = 18;
            // 
            // OfficeLabel
            // 
            this.OfficeLabel.AutoSize = true;
            this.OfficeLabel.Location = new System.Drawing.Point(64, 285);
            this.OfficeLabel.Name = "OfficeLabel";
            this.OfficeLabel.Size = new System.Drawing.Size(49, 20);
            this.OfficeLabel.TabIndex = 16;
            this.OfficeLabel.Text = "Office";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(64, 213);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(76, 20);
            this.LastNameLabel.TabIndex = 15;
            this.LastNameLabel.Text = "Last name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(64, 139);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(77, 20);
            this.FirstNameLabel.TabIndex = 14;
            this.FirstNameLabel.Text = "First name";
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Location = new System.Drawing.Point(64, 60);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(105, 20);
            this.EmailAddressLabel.TabIndex = 13;
            this.EmailAddressLabel.Text = "Email address ";
            // 
            // BirthdateTextBox
            // 
            this.BirthdateTextBox.Location = new System.Drawing.Point(191, 334);
            this.BirthdateTextBox.Multiline = true;
            this.BirthdateTextBox.Name = "BirthdateTextBox";
            this.BirthdateTextBox.Size = new System.Drawing.Size(181, 34);
            this.BirthdateTextBox.TabIndex = 27;
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Location = new System.Drawing.Point(64, 334);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(70, 20);
            this.BirthdateLabel.TabIndex = 26;
            this.BirthdateLabel.Text = "Birthdate";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(191, 388);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(181, 34);
            this.PasswordTextBox.TabIndex = 29;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(64, 388);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 20);
            this.PasswordLabel.TabIndex = 28;
            this.PasswordLabel.Text = "Last name";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 546);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.BirthdateTextBox);
            this.Controls.Add(this.BirthdateLabel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.OfficeComboBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.EmailAddressTextBox);
            this.Controls.Add(this.OfficeLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.EmailAddressLabel);
            this.Name = "AddUserForm";
            this.Text = "Add user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox OfficeComboBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
        private System.Windows.Forms.Label OfficeLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.TextBox BirthdateTextBox;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
    }
}