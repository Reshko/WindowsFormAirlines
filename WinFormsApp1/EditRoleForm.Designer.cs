
namespace WinFormsApp1
{
    partial class EditRoleForm
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
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.OfficeLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.OfficeComboBox = new System.Windows.Forms.ComboBox();
            this.UserRadioBtn = new System.Windows.Forms.RadioButton();
            this.AdminRadioBtn = new System.Windows.Forms.RadioButton();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Location = new System.Drawing.Point(49, 70);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(105, 20);
            this.EmailAddressLabel.TabIndex = 0;
            this.EmailAddressLabel.Text = "Email address ";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(49, 149);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(77, 20);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(49, 223);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(76, 20);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last name";
            // 
            // OfficeLabel
            // 
            this.OfficeLabel.AutoSize = true;
            this.OfficeLabel.Location = new System.Drawing.Point(49, 295);
            this.OfficeLabel.Name = "OfficeLabel";
            this.OfficeLabel.Size = new System.Drawing.Size(49, 20);
            this.OfficeLabel.TabIndex = 3;
            this.OfficeLabel.Text = "Office";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(49, 362);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(39, 20);
            this.RoleLabel.TabIndex = 4;
            this.RoleLabel.Text = "Role";
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.Location = new System.Drawing.Point(176, 70);
            this.EmailAddressTextBox.Multiline = true;
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(181, 34);
            this.EmailAddressTextBox.TabIndex = 5;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(176, 146);
            this.FirstNameTextBox.Multiline = true;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(181, 34);
            this.FirstNameTextBox.TabIndex = 6;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(176, 223);
            this.LastNameTextBox.Multiline = true;
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(181, 34);
            this.LastNameTextBox.TabIndex = 7;
            // 
            // OfficeComboBox
            // 
            this.OfficeComboBox.FormattingEnabled = true;
            this.OfficeComboBox.Items.AddRange(new object[] {
            "All office",
            "Moscow",
            "Kiev",
            "Minsk"});
            this.OfficeComboBox.Location = new System.Drawing.Point(176, 295);
            this.OfficeComboBox.Name = "OfficeComboBox";
            this.OfficeComboBox.Size = new System.Drawing.Size(181, 28);
            this.OfficeComboBox.TabIndex = 8;
            // 
            // UserRadioBtn
            // 
            this.UserRadioBtn.AutoSize = true;
            this.UserRadioBtn.Location = new System.Drawing.Point(176, 362);
            this.UserRadioBtn.Name = "UserRadioBtn";
            this.UserRadioBtn.Size = new System.Drawing.Size(59, 24);
            this.UserRadioBtn.TabIndex = 9;
            this.UserRadioBtn.TabStop = true;
            this.UserRadioBtn.Text = "User";
            this.UserRadioBtn.UseVisualStyleBackColor = true;
            this.UserRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // AdminRadioBtn
            // 
            this.AdminRadioBtn.AutoSize = true;
            this.AdminRadioBtn.Location = new System.Drawing.Point(176, 392);
            this.AdminRadioBtn.Name = "AdminRadioBtn";
            this.AdminRadioBtn.Size = new System.Drawing.Size(74, 24);
            this.AdminRadioBtn.TabIndex = 10;
            this.AdminRadioBtn.TabStop = true;
            this.AdminRadioBtn.Text = "Admin";
            this.AdminRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Location = new System.Drawing.Point(96, 467);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(94, 29);
            this.ApplyBtn.TabIndex = 11;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(251, 467);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(94, 29);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EditRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 551);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.AdminRadioBtn);
            this.Controls.Add(this.UserRadioBtn);
            this.Controls.Add(this.OfficeComboBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.EmailAddressTextBox);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.OfficeLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.EmailAddressLabel);
            this.Name = "EditRoleForm";
            this.Text = "Edit Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label OfficeLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.ComboBox OfficeComboBox;
        private System.Windows.Forms.RadioButton UserRadioBtn;
        private System.Windows.Forms.RadioButton AdminRadioBtn;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}