using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Autovermietung
{
    public partial class RegisterForm : Form
    {
        private DbManager dbManager;

        public RegisterForm(DbManager dbmanager)
        {
            InitializeComponent();
            dbManager = dbmanager;
        }

        private void registerButtonClick(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt16(yearTextBox.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Das Jahr muss in Zahlen angegeben werden");
                return;
            }
            if (passwordTextBox.Text == password2TextBox.Text && dbManager.IsUserAvailable(accountnameTextBox.Text) && drivingLicenseCheckBox.Checked && CheckForAge())
            {
                dbManager.RegisterUser(accountnameTextBox.Text, passwordTextBox.Text, firstNameTextBox.Text, surnameTextBox.Text, emailTextBox.Text, (int)monthNumericUpDown.Value, Convert.ToInt16(yearTextBox.Text), ibanTextBox.Text);
            }
            else if (passwordTextBox.Text != password2TextBox.Text)
            {
                MessageBox.Show("Passwort ist falsch");
            }
            else if (!dbManager.IsUserAvailable(accountnameTextBox.Text))
            {
                MessageBox.Show("Username ist falsch");
            }
            else if (!drivingLicenseCheckBox.Checked)
            {
                MessageBox.Show("Führerschein ist falsch");
            }
            else
            {
                MessageBox.Show("Alter ist falsch");
            }
        }

        private bool CheckForAge()
        {
            if (Convert.ToInt16(yearTextBox.Text) <= DateTime.Now.Year - 18 && monthNumericUpDown.Value <= DateTime.Now.Month)
            {
                return true;
            }
            return false;
        }
    }
}
