using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Autovermietung
{
    public class DbManager
    {
        private MySqlConnection con = new MySqlConnection(@"host=localhost;user=root;database=carsharing");
        private StringBuilder stringBuilder = new StringBuilder();

        public bool IsUserAvailable(string name)
        {
            try
            {
                con.Open();
                using(var select = new MySqlCommand("SELECT EXISTS (SELECT * FROM User WHERE Benutzername='" + name + "')", con))
                {
                    object exists = select.ExecuteScalar();
                    return !Convert.ToBoolean(exists);
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public void RegisterUser(string name, string password, string firstName, string surname, string email, int month, int year, string iban)
        {
            try
            {
                MySqlCommand insert = new MySqlCommand(
                    "INSERT INTO User VALUES(@a, @p, @e, @f, @s, @b, @d, @i)");
                insert.Parameters.AddWithValue("a", name);
                insert.Parameters.AddWithValue("p", password);
                insert.Parameters.AddWithValue("f", firstName);
                insert.Parameters.AddWithValue("s", surname);
                insert.Parameters.AddWithValue("e", email);
                if(month > 10)
                    insert.Parameters.AddWithValue("b", "DATE('MM.YYYY', '" + month + "." + year + "')");
                else
                    insert.Parameters.AddWithValue("b", "DATE('MM.YYYY', '0" + month + "." + year + "')");
                insert.Parameters.AddWithValue("i", iban);
                insert.Parameters.AddWithValue("d", 1);
                con.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show(insert.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        private string SHA256(string password)
        {
            using (SHA256 sha256 = SHA256Managed.Create())
            {
                Byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                foreach (Byte b in bytes)
                    stringBuilder.Append(b.ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}
