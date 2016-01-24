using System.Data.SqlClient;

namespace mcmcds
{
    partial class FormAddEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private SqlConnection conn;

        

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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.WageLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.wageBox = new System.Windows.Forms.TextBox();
            this.positionBox = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 25);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(260, 20);
            this.NameBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // WageLabel
            // 
            this.WageLabel.AutoSize = true;
            this.WageLabel.Location = new System.Drawing.Point(12, 48);
            this.WageLabel.Name = "WageLabel";
            this.WageLabel.Size = new System.Drawing.Size(36, 13);
            this.WageLabel.TabIndex = 2;
            this.WageLabel.Text = "Wage";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(12, 87);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(44, 13);
            this.PositionLabel.TabIndex = 3;
            this.PositionLabel.Text = "Position";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 227);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(77, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Employee";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // wageBox
            // 
            this.wageBox.Location = new System.Drawing.Point(12, 64);
            this.wageBox.Name = "wageBox";
            this.wageBox.Size = new System.Drawing.Size(260, 20);
            this.wageBox.TabIndex = 6;
            // 
            // positionBox
            // 
            this.positionBox.Location = new System.Drawing.Point(12, 103);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(260, 20);
            this.positionBox.TabIndex = 7;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(12, 126);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(33, 13);
            this.LoginLabel.TabIndex = 8;
            this.LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 165);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Password";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(12, 142);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(260, 20);
            this.loginBox.TabIndex = 10;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(12, 181);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(260, 20);
            this.passwordBox.TabIndex = 11;
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.positionBox);
            this.Controls.Add(this.wageBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.WageLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Name = "FormAddEmployee";
            this.Text = "FormAddEmployee";
            this.Load += new System.EventHandler(this.FormAddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label WageLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox wageBox;
        private System.Windows.Forms.TextBox positionBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
    }
}