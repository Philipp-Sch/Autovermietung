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
        private string encrypted;
        private Reservieren reservieren = new Reservieren();

        public RegisterForm(DbManager dbmanager)
        {
            InitializeComponent();
            encrypted = "";
        }

        private void registerButtonClick(object sender, EventArgs e)
        {
            write(e.ToString(), false);
        }

        private void write(string password, bool box) //false = textbox 1, true = textbox 2
        {
            if (!box)
            {
                encrypted += passwordTextBox.Text[passwordTextBox.Text.Length];
                passwordTextBox.Text = passwordTextBox.Text.Remove(passwordTextBox.Text.Length - 1);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            reservieren.Verbindung();
        }
    }
}
