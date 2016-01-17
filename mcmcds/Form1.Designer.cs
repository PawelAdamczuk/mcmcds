namespace mcmcds
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.thinClientLogin = new System.Windows.Forms.Button();
            this.thickClientLogin = new System.Windows.Forms.Button();
            this.comboBoxAddress = new System.Windows.Forms.ComboBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thinClientLogin
            // 
            this.thinClientLogin.Location = new System.Drawing.Point(12, 160);
            this.thinClientLogin.Name = "thinClientLogin";
            this.thinClientLogin.Size = new System.Drawing.Size(136, 23);
            this.thinClientLogin.TabIndex = 0;
            this.thinClientLogin.Text = "Employee login";
            this.thinClientLogin.UseVisualStyleBackColor = true;
            // 
            // thickClientLogin
            // 
            this.thickClientLogin.Location = new System.Drawing.Point(156, 160);
            this.thickClientLogin.Name = "thickClientLogin";
            this.thickClientLogin.Size = new System.Drawing.Size(136, 23);
            this.thickClientLogin.TabIndex = 1;
            this.thickClientLogin.Text = "Administrator login";
            this.thickClientLogin.UseVisualStyleBackColor = true;
            // 
            // comboBoxAddress
            // 
            this.comboBoxAddress.FormattingEnabled = true;
            this.comboBoxAddress.Items.AddRange(new object[] {
            "196.69.69.123",
            "127.0.0.1"});
            this.comboBoxAddress.Location = new System.Drawing.Point(12, 35);
            this.comboBoxAddress.Name = "comboBoxAddress";
            this.comboBoxAddress.Size = new System.Drawing.Size(280, 21);
            this.comboBoxAddress.TabIndex = 2;
            this.comboBoxAddress.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.Location = new System.Drawing.Point(12, 9);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(280, 23);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Address";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAddress.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.Location = new System.Drawing.Point(12, 59);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(280, 23);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Username";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(12, 85);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(280, 20);
            this.textBoxUsername.TabIndex = 6;
            this.textBoxUsername.Text = "bananek";
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "bananek1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(12, 108);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(280, 23);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 192);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.comboBoxAddress);
            this.Controls.Add(this.thickClientLogin);
            this.Controls.Add(this.thinClientLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "DataBananaManagementSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button thinClientLogin;
        private System.Windows.Forms.Button thickClientLogin;
        private System.Windows.Forms.ComboBox comboBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPassword;
    }
}

