using System;

namespace ConsoleApp10
{
    public class Person
    {
        public string Name { get; set; } = "";
        public string Surname { get; set; } = "";
        public int Age { get; set; } = 0;
        public string Phone { get; set; } = "";

        public Person() { }

        public Person(string name, string surname, int age, string phone)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Phone = phone;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Phone: {Phone}");
        }
    }
}
