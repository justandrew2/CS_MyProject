using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Student : Human
    {
        private int student_mark;
        private Marks student_rating;
        Random number = new Random();
        public int Student_mark
        {
            get { return student_mark; }
            set { student_mark = value; }
        }
        public Student() { }

        public Student(string Name, string SecondName, string MiddleName, int Age, string State, string City, string Street, int House) : base(Name, SecondName, MiddleName, Age, State, City, Street, House)
        {
            student_mark = number.Next(1, 6);
            student_rating = (Marks)student_mark;
        }
        public Student(string Name, string SecondName, string MiddleName, int Age, string State, string City, string Street, int House, int Mark) : base(Name, SecondName, MiddleName, Age, State, City, Street, House)
        {
            student_mark = Mark;
            student_rating = (Marks)student_mark;
        }
        public void Show_some_info()
        {
            Console.WriteLine(this.Name + " " + this.Second_name);
        }
        public void Display_Student_Info()
        {
            base.Print();
            Console.WriteLine("Average marks: " + this.student_mark + "\nRating: " + this.student_rating);
        }
    }
}