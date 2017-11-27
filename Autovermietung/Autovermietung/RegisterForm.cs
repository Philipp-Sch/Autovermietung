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

        public RegisterForm()
        {
            InitializeComponent();
            encrypted = "";
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            write(e.ToString(), false);
        }

        private void password2TextBox_TextChanged(object sender, EventArgs e)
        {
            write(e.ToString(), true);
        }

        private void write(string password, bool box) //false = textbox 1, true = textbox 2
        {
            if (!box)
            {
                encrypted += passwordTextBox.Text[passwordTextBox.Text.Length];
                passwordTextBox.Text = passwordTextBox.Text.Remove(passwordTextBox.Text.Length - 1);
            }
        }
    }
}
