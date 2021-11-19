using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class TeacherList
    {
        private List<Teacher> list_of_teachers;

        public TeacherList() { list_of_teachers = new List<Teacher>(); }

        public void Add_Teacher(string Name, string SecondName, string MiddleName, int Age, string State, string City, string Street, int House, int MaxStudents)
        {
            list_of_teachers.Add(new Teacher(Name, SecondName, MiddleName, Age, State, City, Street, House, MaxStudents));
            Console.WriteLine("Teacher added");
        }

        public void RemoveTeacher(string SecondName)
        {
            foreach (Teacher i in list_of_teachers)
            {
                if (i.Second_name == SecondName)
                {
                    list_of_teachers.Remove(i);
                    Console.WriteLine("Teacher removed");
                    break;
                }
            }

        }


        public void Teacher_list_info()
        {
            if (list_of_teachers.Count == 0)
            {
                Console.WriteLine("No teachers yet");
                return;
            }
            Console.WriteLine("Teachers:");
            foreach (Teacher teacher in list_of_teachers)
            {
                Console.WriteLine($"{teacher.Second_name} {teacher.Name} {teacher.Middle_name} {teacher.Age} y.o.\n");
            }

        }

        public int Find_Teacher(string SecondName)
        {
            foreach (Teacher teacher in list_of_teachers)
            {

                if (SecondName == teacher.Second_name)
                {
                    return list_of_teachers.IndexOf(teacher);
                }

            }

            return -1;
        }

        public void Work_With_Teacher(int id)
        {

            int n = 1;
            while (n != 5)
            {
                Console.WriteLine("\n1. Teacher Inforamation\n2. Add student\n3. Remove student\n4. Students\n5. Exit");
                Console.WriteLine("Enter number:");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        list_of_teachers[id].Display_Teacher_Info();
                        break;

                    case 2:
                        Console.WriteLine("\nColecting data...");
                        Console.WriteLine("\nEnter student's name:");
                        string Name = Console.ReadLine();

                        Console.WriteLine("\nEnter student's second name:");
                        string SecondName = Console.ReadLine();

                        Console.WriteLine("\nEnter student's middle name:");
                        string MiddleName = Console.ReadLine();

                        Console.WriteLine("\nEnter student's age:");
                        int Age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nEnter country:");
                        string State = Console.ReadLine();

                        Console.WriteLine("\nEnter city:");
                        string City = Console.ReadLine();

                        Console.WriteLine("\nEnter street:");
                        string Street = Console.ReadLine();

                        Console.WriteLine("\nEnter house number:");
                        int House = Convert.ToInt32(Console.ReadLine());

                        list_of_teachers[id].Add_Student(new Student(Name, SecondName, MiddleName, Age, State, City, Street, House));
                        break;

                    case 3:
                        Console.WriteLine("\nEnter name and second name to remove\nName: ");
                        Name = Console.ReadLine();
                        Console.WriteLine("\nSecond name: ");
                        SecondName = Console.ReadLine();
                        list_of_teachers[id].Remove_Student_By_Name(Name, SecondName);
                        break;

                    case 4:
                        list_of_teachers[id].Show_Students();
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Wrong number!");
                        break;
                }
            }
        }
    }
}

