using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Autovermietung
{
    public partial class RocketForm : Form
    {
        static string connectionString;
        MySqlConnection con = new MySqlConnection(connectionString);
        MySqlCommand cmd;

        public RocketForm()
        {
            InitializeComponent();
            connectionString = @"host=localhost;user=root;database=carsharing";
            startTimeTextBox.Text = dateTimePicker2.Value.ToString();
        }

        private void AusleihButton_Click(object sender, EventArgs e)
        {
            Rent();
        }

        private void CarListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            Sync();
        }

        private void HinzufügenButton_Click(object sender, EventArgs e)
        {
            AddCar();
        }

        private void AddCar()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO fahrzeug SET Name='" + nameTextBox.Text + "',Gangschaltart=" + gangschaltartTextBox.Text + ",Marke='" + markeTextBox.Text + "',Treibstoff=" + treibstoffTextBox + ",Leistung=" + leistungTextBox + ",Anhängerkupplung=" + anhängekuppelTextBox.Text + ",Sitzplätze" + sitzplätzeTextBox.Text + ",Kofferraumgröße=" + kofferraumgrößeTextBox.Text + ",Autoklasse='" + klasseTextBox.Text + "'";
            cmd.CommandText = "INSERT INTO standort SET Postleitzahl=" + postleitzahlTextBox + ",Stadt='" + stadtTextBox + "',Straße='" + straßeTextBox.Text + "'";

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Reset();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }

        }
        private void Sync()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Fahrzeug-ID FROM fahrzeug";
            try
            {
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                Clear();

                while (reader.Read())
                {
                    CarListBox.Items.Add(reader["Fahrzeug-ID"]).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void Reset()
        {
            nameTextBox.Text = "";
            gangschaltartTextBox.Text = "";
            markeTextBox.Text = "";
            treibstoffTextBox.Text = "";
            leistungTextBox.Text = "";
            anhängekuppelTextBox.Text = "";
            sitzplätzeTextBox.Text = "";
            postleitzahlTextBox.Text = "";
            kofferraumgrößeTextBox.Text = "";
            stadtTextBox.Text = "";
            klasseTextBox.Text = "";
            straßeTextBox.Text = "";
        }
        private void Clear()
        {
            CarListBox.Items.Clear();
        }
        private void Rent()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO buchung SET Username='" + usernameTextBox.Text + "',Start='" + startTimeTextBox.Text + "'";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                Reset();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
