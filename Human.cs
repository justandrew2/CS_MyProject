using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyProject
{
    class Human
    {
        private string name;
        private string middle_name;
        private string second_name;
        private int age;

        private Adress adress = new Adress();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Middle_name
        {
            get { return middle_name; }
            set { middle_name = value; }
        }
        public string Second_name
        {
            get { return second_name; }
            set { second_name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string State
        {
            get { return adress.State; }
            set { adress.State = value; }
        }
        public string City
        {
            get { return adress.City;}
            set { adress.City = value; }
        }
        public string Street
        {
            get { return adress.Street; }
            set { adress.Street = value; }
        }
        public int House
        {
            get { return adress.House; }
            set { adress.House = value; }
        }
        public Human() { }

        public Human(string Name, string SecondName, string MiddleName, int Age, string State, string City, string Street, int House)
        {
            name = Name;
            second_name = SecondName;
            middle_name = MiddleName;
            age = Age;
            adress.setAdress(State, City, Street, House);
        }


        public void Print()
        {
            Console.WriteLine("First Name: " + this.name + "\nSecond Name: " + this.second_name + "\nMiddle Name: " + this.middle_name + "\nAge: " + this.age);
            adress.Print();
        }
    }
}
