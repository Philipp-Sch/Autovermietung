namespace Autovermietung
{
    partial class RegisterForm
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
            this.registerButton = new System.Windows.Forms.Button();
            this.accountnameLabel = new System.Windows.Forms.Label();
            this.accountnameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.password2TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(199, 227);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(73, 23);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Registieren";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // accountnameLabel
            // 
            this.accountnameLabel.AutoSize = true;
            this.accountnameLabel.Location = new System.Drawing.Point(12, 9);
            this.accountnameLabel.Name = "accountnameLabel";
            this.accountnameLabel.Size = new System.Drawing.Size(75, 13);
            this.accountnameLabel.TabIndex = 1;
            this.accountnameLabel.Text = "Benutzername";
            // 
            // accountnameTextBox
            // 
            this.accountnameTextBox.Location = new System.Drawing.Point(93, 6);
            this.accountnameTextBox.Name = "accountnameTextBox";
            this.accountnameTextBox.Size = new System.Drawing.Size(101, 20);
            this.accountnameTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 37);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(50, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Passwort";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(93, 34);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(101, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // password2TextBox
            // 
            this.password2TextBox.Location = new System.Drawing.Point(93, 60);
            this.password2TextBox.Name = "password2TextBox";
            this.password2TextBox.Size = new System.Drawing.Size(101, 20);
            this.password2TextBox.TabIndex = 5;
            this.password2TextBox.TextChanged += new System.EventHandler(this.password2TextBox_TextChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.password2TextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.accountnameTextBox);
            this.Controls.Add(this.accountnameLabel);
            this.Controls.Add(this.registerButton);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label accountnameLabel;
        private System.Windows.Forms.TextBox accountnameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox password2TextBox;
    }
}