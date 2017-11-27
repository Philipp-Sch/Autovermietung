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

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButtonClick(object sender, EventArgs e)
        {
            var a = SHA256(passwordTextBox.Text);
        }

        public String SHA256(String text)
        {
            StringBuilder stringBuilder = new StringBuilder();

            using (SHA256 sha256 = SHA256Managed.Create())
            {
                Byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));

                foreach (Byte b in bytes)
                    stringBuilder.Append(b.ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}
