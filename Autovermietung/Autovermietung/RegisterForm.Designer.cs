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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.registerButton = new System.Windows.Forms.Button();
            this.accountnameLabel = new System.Windows.Forms.Label();
            this.accountnameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.password2TextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.monthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ibanTextBox = new System.Windows.Forms.TextBox();
            this.ibanLabel = new System.Windows.Forms.Label();
            this.drivingLicenseCheckBox = new System.Windows.Forms.CheckBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).BeginInit();
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
            this.registerButton.Click += new System.EventHandler(this.registerButtonClick);
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
            this.passwordTextBox.Size = new System.Drawing.Size(101, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // password2TextBox
            // 
            this.password2TextBox.Location = new System.Drawing.Point(93, 60);
            this.password2TextBox.Name = "password2TextBox";
            this.password2TextBox.Size = new System.Drawing.Size(101, 20);
            this.password2TextBox.TabIndex = 5;
            this.password2TextBox.UseSystemPasswordChar = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 89);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "E-Mail";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(93, 86);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(101, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 115);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(49, 13);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "Vorname";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(93, 112);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(101, 20);
            this.firstNameTextBox.TabIndex = 9;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(93, 138);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(101, 20);
            this.surnameTextBox.TabIndex = 10;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(12, 141);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(59, 13);
            this.surnameLabel.TabIndex = 11;
            this.surnameLabel.Text = "Nachname";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(12, 166);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(73, 13);
            this.birthdateLabel.TabIndex = 12;
            this.birthdateLabel.Text = "Geburtsdatum";
            // 
            // monthNumericUpDown
            // 
            this.monthNumericUpDown.Location = new System.Drawing.Point(93, 164);
            this.monthNumericUpDown.Name = "monthNumericUpDown";
            this.monthNumericUpDown.Size = new System.Drawing.Size(28, 20);
            this.monthNumericUpDown.TabIndex = 13;
            // 
            // ibanTextBox
            // 
            this.ibanTextBox.Location = new System.Drawing.Point(93, 190);
            this.ibanTextBox.Name = "ibanTextBox";
            this.ibanTextBox.Size = new System.Drawing.Size(101, 20);
            this.ibanTextBox.TabIndex = 15;
            // 
            // ibanLabel
            // 
            this.ibanLabel.AutoSize = true;
            this.ibanLabel.Location = new System.Drawing.Point(12, 193);
            this.ibanLabel.Name = "ibanLabel";
            this.ibanLabel.Size = new System.Drawing.Size(32, 13);
            this.ibanLabel.TabIndex = 16;
            this.ibanLabel.Text = "IBAN";
            // 
            // drivingLicenseCheckBox
            // 
            this.drivingLicenseCheckBox.AutoSize = true;
            this.drivingLicenseCheckBox.Location = new System.Drawing.Point(93, 216);
            this.drivingLicenseCheckBox.Name = "drivingLicenseCheckBox";
            this.drivingLicenseCheckBox.Size = new System.Drawing.Size(87, 17);
            this.drivingLicenseCheckBox.TabIndex = 18;
            this.drivingLicenseCheckBox.Text = "Führerschein";
            this.drivingLicenseCheckBox.UseVisualStyleBackColor = true;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(127, 163);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(67, 20);
            this.yearTextBox.TabIndex = 19;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.drivingLicenseCheckBox);
            this.Controls.Add(this.ibanLabel);
            this.Controls.Add(this.ibanTextBox);
            this.Controls.Add(this.monthNumericUpDown);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.password2TextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.accountnameTextBox);
            this.Controls.Add(this.accountnameLabel);
            this.Controls.Add(this.registerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.NumericUpDown monthNumericUpDown;
        private System.Windows.Forms.TextBox ibanTextBox;
        private System.Windows.Forms.Label ibanLabel;
        private System.Windows.Forms.CheckBox drivingLicenseCheckBox;
        private System.Windows.Forms.TextBox yearTextBox;
    }
}