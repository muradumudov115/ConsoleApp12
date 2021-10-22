using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student();
            obj1.name = "murad";
            obj1.surname = "umudov";
            obj1.age = 18;

            
            Student obj2 = new Student();
            obj2.name = "sahil";
            obj2.surname = "mamedov";
            obj2.age = 15;
            Console.WriteLine(obj1.Fullname());
            Console.WriteLine();
            Console.WriteLine(obj2.Fullname());


        }
    }
    class Student
    {
        public string name;
        public string surname; 
        public int age;
        public string Fullname()
        {
            return $"{name} {surname}";
        }
    }
}