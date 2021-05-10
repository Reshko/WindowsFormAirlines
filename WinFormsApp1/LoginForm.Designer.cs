
namespace WinFormsApp1
{
    partial class LoginForm
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
            this.OfficeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChangeRoleBtn = new System.Windows.Forms.Button();
            this.DisableRoleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OfficeLabel
            // 
            this.OfficeLabel.AutoSize = true;
            this.OfficeLabel.Location = new System.Drawing.Point(3, 68);
            this.OfficeLabel.Name = "OfficeLabel";
            this.OfficeLabel.Size = new System.Drawing.Size(49, 20);
            this.OfficeLabel.TabIndex = 0;
            this.OfficeLabel.Text = "Office";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All Office",
            "Moscow",
            "Kiev",
            "Minsk"});
            this.comboBox1.Location = new System.Drawing.Point(80, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(80, 113);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 273);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ChangeRoleBtn
            // 
            this.ChangeRoleBtn.Location = new System.Drawing.Point(80, 409);
            this.ChangeRoleBtn.Name = "ChangeRoleBtn";
            this.ChangeRoleBtn.Size = new System.Drawing.Size(103, 29);
            this.ChangeRoleBtn.TabIndex = 3;
            this.ChangeRoleBtn.Text = "Change role";
            this.ChangeRoleBtn.UseVisualStyleBackColor = true;
            // 
            // DisableRoleBtn
            // 
            this.DisableRoleBtn.Location = new System.Drawing.Point(219, 409);
            this.DisableRoleBtn.Name = "DisableRoleBtn";
            this.DisableRoleBtn.Size = new System.Drawing.Size(174, 29);
            this.DisableRoleBtn.TabIndex = 4;
            this.DisableRoleBtn.Text = "Disable/Enable Login";
            this.DisableRoleBtn.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisableRoleBtn);
            this.Controls.Add(this.ChangeRoleBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.OfficeLabel);
            this.Name = "LoginForm";
            this.Text = "AMONIC Airlines Automation System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OfficeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ChangeRoleBtn;
        private System.Windows.Forms.Button DisableRoleBtn;
    }
}