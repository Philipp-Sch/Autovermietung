﻿using System;
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
    public partial class CarDetails : Form
    {
        private DbManager dbmanager = new DbManager();

        public CarDetails()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// In der Listbox werden die Objekte gespeichert. Je nach ausgewähltem Item
        /// werden die entsprechenden Daten des Objekts in den TextBoxen angezeigt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarDetailscs_Load(object sender, EventArgs e)
        {
            #region Change TextBox.Text

            carListBox.Items.AddRange(dbmanager.GetCars().ToArray());               //Die mit Objekten gefüllte Liste wird in die ListBox eingefügt
            producerTextBox.Text = ((Car)carListBox.SelectedItem).Producer;         //Die Werte werden je nach ausgewähltem Item in den TextBoxen angezeigt
            modelTextBox.Text = ((Car)carListBox.SelectedItem).Model;
            classTextBox.Text = ((Car)carListBox.SelectedItem).CarClass;
            powerTextBox.Text = ((Car)carListBox.SelectedItem).Power.ToString();
            seatsTextBox.Text = ((Car)carListBox.SelectedItem).Seats.ToString();
            trunkTextBox.Text = ((Car)carListBox.SelectedItem).Trunk.ToString();
            fuelTextBox.Text = ((Car)carListBox.SelectedItem).Fuel.ToString();
            gearTextBox.Text = ((Car)carListBox.SelectedItem).Gear.ToString();

            if(((Car)carListBox.SelectedItem).Gear)
            {
                gearTextBox.Text = "Manuell";
            }
            else
            {
                gearTextBox.Text = "Automatik";
            }
            if(((Car)carListBox.SelectedItem).Trailer)
            {
                trailerTextBox.Text = "Vorhanden";
            }
            else
            {
                trailerTextBox.Text = "Nicht Vorhanden";
            }
            
            #endregion
        }
    }
}
