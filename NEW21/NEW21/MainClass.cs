using ConsoleApp10;
using System;
using System.Collections;

class MainClass
{
    public static void Main()
    {
        try
        {
            
            Academy_Group academyGroup = new Academy_Group();

            
            academyGroup.Add(new Student("John", "Doe", 20, "1234567890", 3.5, 101));
            academyGroup.Add(new Student("Jane", "Smith", 21, "0987654321", 3.8, 102));
            academyGroup.Add(new Student("Alice", "Johnson", 22, "1122334455", 3.7, 103));

            Console.WriteLine("Перебор студентов в группе с помощью foreach:");
            foreach (Student student in academyGroup)
            {
                student.Print();
                Console.WriteLine();
            }

            
            ClassMenu menu = new ClassMenu();
            menu.Menu();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}


