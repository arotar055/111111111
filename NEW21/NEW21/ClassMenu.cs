using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class ClassMenu
    {
        private Academy_Group academyGroup = new Academy_Group();
        private bool running = true;

        public void Menu()
        {
            while (running)
            {
                DisplayMenu();

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        RemoveStudent();
                        break;
                    case "3":
                        EditStudent();
                        break;
                    case "4":
                        ShowGroup();
                        break;
                    case "5":
                        SaveData();
                        break;
                    case "6":
                        LoadData();
                        break;
                    case "7":
                        SearchStudent();
                        break;
                    case "8":
                        SortStudents();
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Remove Student");
            Console.WriteLine("3. Edit Student");
            Console.WriteLine("4. Show Group");
            Console.WriteLine("5. Save Data");
            Console.WriteLine("6. Load Data");
            Console.WriteLine("7. Search Student");
            Console.WriteLine("8. Sort Students");
            Console.WriteLine("0. Exit");
            Console.Write("Your choice: ");
        }

        private void AddStudent()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.Write("Enter average score: ");
                if (double.TryParse(Console.ReadLine(), out double average))
                {
                    Console.Write("Enter group number: ");
                    if (int.TryParse(Console.ReadLine(), out int groupNumber))
                    {
                        Student student = new Student(name, surname, age, phone, average, groupNumber);
                        academyGroup.Add(student);
                    }
                    else
                    {
                        Console.WriteLine("Invalid group number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid average score.");
                }
            }
            else
            {
                Console.WriteLine("Invalid age.");
            }
        }

        private void RemoveStudent()
        {
            Console.Write("Enter the surname of the student to remove: ");
            string surname = Console.ReadLine();
            academyGroup.Remove(surname);
        }

        private void EditStudent()
        {
            Console.Write("Enter the surname of the student to edit: ");
            string surname = Console.ReadLine();

            Console.Write("Enter new name: ");
            string newName = Console.ReadLine();
            Console.Write("Enter new surname: ");
            string newSurname = Console.ReadLine();
            Console.Write("Enter new phone: ");
            string newPhone = Console.ReadLine();
            Console.Write("Enter new age: ");
            if (int.TryParse(Console.ReadLine(), out int newAge))
            {
                Console.Write("Enter new average score: ");
                if (double.TryParse(Console.ReadLine(), out double newAverage))
                {
                    Console.Write("Enter new group number: ");
                    if (int.TryParse(Console.ReadLine(), out int newGroupNumber))
                    {
                        Student newStudent = new Student(newName, newSurname, newAge, newPhone, newAverage, newGroupNumber);
                        academyGroup.Edit(surname, newStudent);
                    }
                    else
                    {
                        Console.WriteLine("Invalid group number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid average score.");
                }
            }
            else
            {
                Console.WriteLine("Invalid age.");
            }
        }

        private void ShowGroup()
        {
            academyGroup.Print();
        }

        private void SaveData()
        {
            academyGroup.Save();
        }

        private void LoadData()
        {
            academyGroup.Load();
        }

        private void SearchStudent()
        {
            Console.WriteLine("Choose a criterion for searching:");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Surname");
            Console.WriteLine("3. Phone");
            Console.WriteLine("4. Age");
            Console.WriteLine("5. Average Score");
            Console.WriteLine("6. Group Number");
            Console.Write("Your choice: ");

            if (int.TryParse(Console.ReadLine(), out int criterion))
            {
                academyGroup.Search(criterion);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        private void SortStudents()
        {
            Console.WriteLine("Choose a sorting criterion:");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Surname");
            Console.WriteLine("3. Age");
            Console.Write("Your choice: ");

            if (int.TryParse(Console.ReadLine(), out int criterion))
            {
                academyGroup.Sort(criterion);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}