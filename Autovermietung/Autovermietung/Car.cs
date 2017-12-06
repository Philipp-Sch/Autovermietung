using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovermietung
{
    class Car
    {
        private string producer, model, carClass, fuel;
        private int power, seats, trunk;
        private bool gear, trailer; //automatik = false, manuell = true


        public Car(string producer, string model, string carClass, string fuel, int power, int seats, int trunk, bool gear, bool trailer)
        {
            this.producer = producer;
            this.model = model;
            this.carClass = carClass;
            this.fuel = fuel;
            this.power = power;
            this.seats = seats;
            this.trunk = trunk;
            this.gear = gear;
            this.trailer = trailer;
        }

        public string getProducer()         //Hersteller
        {
            return producer;
        }
        public string getModel()            //Modell
        {
            return model;
        }
        public string getCarClass()         //Fahrzeugklasse
        {
            return carClass;
        }
        public string getFuel()             //Treibstoff
        {
            return fuel;
        }
        public int getPower()               //Leistung
        {
            return power;
        }
        public int getSeats()               //Sitzplätze
        {
            return seats;
        }
        public int getTrunk()               //Kofferraunm
        {
            return trunk;
        }
        public bool getGear()               //Gangschaltart
        {
            return gear;
        }
        public bool getTrailer()            //Anhängerkupplung
        {
            return trailer;
        }
    }
}
