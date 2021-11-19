using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Teacher : Human
    {
        private int max_students;
        private int c_of_students;
        private List<Student> list_of_students;


        public int MaxStudents
        {
            get { return max_students; }
            set { max_students = value; }
        }
        public Teacher() { }
        public Teacher(string Name, string SecondName, string MiddleName, int Age, string State, string City, string Street, int House, int MaxStudents) : base(Name, SecondName, MiddleName, Age, State, City, Street, House)
        {
            max_students = MaxStudents;
            c_of_students = 0;
            list_of_students = new List<Student>(max_students);
        }
        public void Display_Teacher_Info()
        {
            base.Print();
            Console.WriteLine("Max students: " + this.max_students);
            Console.WriteLine("Students taken: " + this.c_of_students);

        }
        public void Show_Students()
        {
            if (list_of_students.Count == 0)
            {
                Console.WriteLine("No students yet");
                return;
            }
            foreach (Student student in list_of_students)
            {
                student.Show_some_info();
            }
        }
        public void Show_Students_More_Info()
        {
            if (list_of_students.Count == 0)
            {
                Console.WriteLine("There is no students");
                return;
            }
            foreach (Student student in list_of_students)
            {
                student.Print();
            }
        }
        public void Add_Student(Student student)
        {
            if (c_of_students == max_students)
            {
                Console.WriteLine("Unable to add a student due to a counter limit");
            }
            else
            {
                c_of_students++;
                list_of_students.Add(student);
                Console.WriteLine("Student was added");
            }      
        }
        public void Remove_Student(Student student)
        {
            if (c_of_students == 0)
            {
                Console.WriteLine("Nothing to remove");
            }
            else
            {
                list_of_students.Remove(student);
                c_of_students--;
                Console.WriteLine("Student removed");
            }
        }
        public void Remove_Student_By_Name(string Name, string SecondName)
        {
            if (c_of_students == 0)
            {
                Console.WriteLine("Nothing to remove");
            }
            else
            {
                foreach (Student student in list_of_students)
                {
                    if (student.Name == Name & student.Second_name == SecondName)
                    {
                        c_of_students--;
                        list_of_students.Remove(student);
                        Console.WriteLine("student removed");
                    }
                }
            }

        }
    }
}
