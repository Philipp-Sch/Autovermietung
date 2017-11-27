using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Autovermietung
{
    class DbManager
    {
        private MySqlConnection con;

        public DbManager()
        {
            con = new MySqlConnection(@"host=localhost;user=root;database=carsharing");
        }

        public bool UserAvailable(string name)
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

        public void Register(string name, string password)
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
    }
}
