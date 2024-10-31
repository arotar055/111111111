using System;
using System.Collections;

namespace ConsoleApp10
{
    public class Student : Person, IComparable
    {
        public double Average { get; set; }
        public int NumberOfGroup { get; set; }

        public Student() { }

        public Student(string name, string surname, int age, string phone, double average, int numberOfGroup)
            : base(name, surname, age, phone)
        {
            Average = average;
            NumberOfGroup = numberOfGroup;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Average Grade: {Average}, Group Number: {NumberOfGroup}");
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Student otherStudent = obj as Student;
            if (otherStudent != null)
            {
                return string.Compare(this.Name, otherStudent.Name);
            }
            else
            {
                throw new ArgumentException("Object is not a Student");
            }
        }

        public class SortBySurname : IComparer
        {
            public int Compare(object x, object y)
            {
                return string.Compare(((Student)x).Surname, ((Student)y).Surname);
            }
        }

        public class SortByAge : IComparer
        {
            public int Compare(object x, object y)
            {
                return ((Student)x).Age.CompareTo(((Student)y).Age);
            }
        }
    }
}
