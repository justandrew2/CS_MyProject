using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Adress
    {
        private string state;
        private string city;
        private string street;
        private int house;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }  
            set { street = value; }
        }
        public int House
        {
            get { return house; }
            set { house = value; }
        }

        public void Print()
        {
            Console.WriteLine("State: " + this.state + "\nCity: " + this.city + "\nStreet: " + this.street + "\nNumber of house: " + this.house);
        }
        public Adress() { }
        public void setAdress(string State, string City, string Street, int House)
        {
            state = State;
            city = City;
            street = Street;
            house = House;
        }
    }
}
