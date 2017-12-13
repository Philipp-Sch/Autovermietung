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



        /// <summary>
        /// Die dahrzeugdaten aus der Datenbank werden ausgelsen und in einer Liste gespeichert.
        /// In der Liste sind mehrere Objekte der Klasse "Car"
        /// </summary>
        /// <returns>Eine Liste mit Car-Objekten</returns>
        public List<Car> GetCars()
        {
            List<Car> carModels = new List<Car>();
            using (MySqlConnection mySqlConnection = new MySqlConnection(@"host=localhost;user=root;database=carsharing"))          //Verbindung zur DB wir hergestellt
            {
                try
                {
                    mySqlConnection.Open();
                    using (MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select * From fahrzeug", mySqlConnection))         //Die Daten werden ´mit dem SQL-Befehl ausgelesen
                    {
                        DataTable dataTable = new DataTable();
                        mySqlDataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            carModels.Add(new Car()                 //Die verschiedenen Car-Objekte werden in der Liste gespeichert
                            {
                                Producer = row.ItemArray[0].ToString(),
                                Model = row.ItemArray[1].ToString(),
                                CarClass = row.ItemArray[2].ToString(),
                                Fuel = row.ItemArray[3].ToString(),
                                Power = Convert.ToInt32(row.ItemArray[4]),
                                Seats = Convert.ToInt32(row.ItemArray[5]),
                                Trunk = Convert.ToInt32(row.ItemArray[6]),
                                Gear = Convert.ToBoolean(row.ItemArray[7]),
                                Trailer = Convert.ToBoolean(row.ItemArray[8])
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    
                    throw;
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
            return carModels;           //Rückgabe der Liste
        }
    }
}
