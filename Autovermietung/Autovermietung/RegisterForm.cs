using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autovermietung
{
    public partial class RegisterForm : Form
    {
        private string encrypted;
        private DbManager dbManager;

        public RegisterForm(DbManager dbmanager)
        {
            InitializeComponent();
            encrypted = "";
            dbManager = dbmanager;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void password2TextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox == password2TextBox && dbManager.UserAvailable(accountnameTextBox.Text)) //Abfrage nach Verfügbarkeit des Benutzernamens
            {

            }
            else
            {
                MessageBox.Show("Passwort stimmt nicht überein oder dein Benutzername ist schon vergeben");
            }
        }
    }
}
