using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovermietung
{
    public class Car
    {
        private string producer, model, carClass, fuel;
        private int power, seats, trunk;
        private bool gear, trailer; //automatik = false, manuell = true


        public Car()
        {

        }


        public string Producer
        {
            get { return producer; }            //"Get" um einen Wert auszugeben
            set { producer = value; }           //"Set" um einen Wert zu setzen/verändern
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string CarClass
        {
            get { return carClass; }
            set { carClass = value; }
        }

        public string Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        public int Trunk
        {
            get { return trunk; }
            set { trunk = value; }
        }

        public bool Gear
        {
            get { return Gear; }
            set { gear = value; }
        }

        public bool Trailer
        {
            get { return trailer; }
            set { trailer = value; }
        }
    }
}
