using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Autovermietung
{
    public class DbManager
    {
        private MySqlConnection con = new MySqlConnection(@"host=localhost;user=root;database=carsharing");
        private StringBuilder stringBuilder = new StringBuilder();

        public bool IsUserAvailable(string name)
        {
            bool available = false;
            try
            {
                MySqlCommand select = new MySqlCommand("SELECT Benutzername FROM User WHERE Benutzername=" + name, con);
                MySqlDataReader reader = select.ExecuteReader();
                if (!reader.Read())
                {
                    available = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
            return available;
        }

        public void RegisterUser(string name, string password)
        {
            try
            {
                con.Open();
                MySqlCommand insert = new MySqlCommand("INSERT INTO User(Benutzername, Passwort) VALUES(" + name + ", " + SHA256(password));
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
