using System;

namespace MyProject
{
    class Program
    {
        static void Main()
        {
            TeacherList list = new TeacherList();
            list.Add_Teacher("Andrew", "Kirsanov", "Maximovich", 18, "Ukraine", "Kherson", "Ladichuka", 99, 3);

            int n = 1;
            while (n != 6)
            {
                Console.WriteLine("1. Show teachers\n2. Add teacher\n3. Remove teacher\n4. Find a teacher\n5. Work with a teacher\n6. Exit");
                Console.WriteLine("\nEnter number:");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        list.Teacher_list_info();
                        break;
                    case 2:
                        Console.WriteLine("\nColecting data...");
                        Console.WriteLine("\nEnter teacher's name:");
                        string Name = Console.ReadLine();

                        Console.WriteLine("\nEnter teacher's second name:");
                        string SecondName = Console.ReadLine();

                        Console.WriteLine("\nEnter teacher's middle name:");
                        string MiddleName = Console.ReadLine();

                        Console.WriteLine("\nEnter teacher's age:");
                        int Age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nEnter country:");
                        string State = Console.ReadLine();

                        Console.WriteLine("\nEnter city:");
                        string City = Console.ReadLine();

                        Console.WriteLine("\nEnter street:");
                        string Street = Console.ReadLine();

                        Console.WriteLine("\nEnter house number:");
                        int House = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nEnter the MaxStudents:");
                        int MaxStudents = Convert.ToInt32(Console.ReadLine());

                        list.Add_Teacher(Name, SecondName, MiddleName, Age, State, City, Street, House, MaxStudents);
                        break;
                    case 3:
                        Console.WriteLine("Enter the second name of the teacher:");
                        list.RemoveTeacher(Console.ReadLine());
                        break;

                    case 4:
                        Console.WriteLine("Enter Second name: ");
                        SecondName = Console.ReadLine();

                        if (list.Find_Teacher(SecondName) == -1)
                        {
                            Console.WriteLine("No teacher with this second name");
                        }
                        else
                        {
                            Console.WriteLine("Id: " + list.Find_Teacher(SecondName));
                        }
                        break;

                    case 5:
                        Console.WriteLine("Enter teacher's id: ");
                        list.Work_With_Teacher(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 6:
                        Console.WriteLine("Exiting...\n");
                        break;

                    default:
                        Console.WriteLine("Wrong number!\n");
                        break;

                }
            }

        }
    }
}