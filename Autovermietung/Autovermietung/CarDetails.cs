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
        private Car car;
        private DbManager dbmanager;

        public CarDetails()
        {
            InitializeComponent();
            
            dbmanager = new DbManager();
        }

        private void CarDetailscs_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(dbmanager.GetCars().ToArray());

            //producerLabel.Text = listBox1.SelectedItem.



            //producerTextBox.Text = car.getProducer();
            //modelTextBox.Text = car.getModel();
            //classTextBox.Text = car.getCarClass();
            //powerTextBox.Text = car.getPower().ToString();
            //seatsTextBox.Text = car.getSeats().ToString();
            //trunkTextBox.Text = car.getTrunk().ToString();
            //fuelTextBox.Text = car.getFuel();
            //if (car.getGear() == true)
            //    gearTextBox.Text = "Manuell";
            //else
            //    gearTextBox.Text = "Automatik";
            //if (car.getTrailer() == true)
            //    trailerTextBox.Text = "Ja";
            //else
            //    trailerTextBox.Text = "Nein";
        }
    }
}
