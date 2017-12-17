using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Autovermietung
{
    public class Reservieren
    {
        public string connect = @"host=localhost;user=root;database=carsharing";
        MySqlConnection con = new MySqlConnection();
        DbManager dbm = new DbManager();
        
        
        
        /*  public void hinzuüfgen(string marke, string türen, string motor)
          {
              using (con)
              {
                  con.Open();
                  MySqlCommand com = new MySqlCommand("INSERT INTO carsharing (marke, türen, motor) VALUES('" + marke + "','" + türen + "','" + motor + "'))", con);
                  com.ExecuteNonQuery();
              }

          }*/

        public void Anzeigen()
        {
            dbm.GetCars();
        }

        public void reserviert()
        {
            con.Open();
            string myup = "UPDATE Car SET Reserviert ";   //reservierung setzen
            

        }


        public void Verbindung()
        {
            try
            {
                con.Open();

            }

            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                con.Close();
            }


        }


    }
}