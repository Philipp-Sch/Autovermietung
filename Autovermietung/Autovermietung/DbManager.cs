using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Data;

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




        public List<Car> GetCars()
        {
            List<Car> carModels = new List<Car>();
            using (MySqlConnection mySqlConnection = new MySqlConnection(@"host=localhost;user=root;database=carsharing"))
            {
                try
                {
                    mySqlConnection.Open();
                    using (MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("Select * From fahrzeug", mySqlConnection))
                    {
                        DataTable dataTable = new DataTable();
                        mySqlDataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            carModels.Add(new Car()
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

                    return carModels;
                }
                finally
                {
                    mySqlConnection.Close();
                }
            }
            return carModels;      
        }
    }
}
