using System;

namespace a24
{
    class Program
    {
        static void Main(string[] args)
        {
            var Person1 = new Person();
            Console.WriteLine("Person 1: {0} {1}, {2}", Person1.FirstName, Person1.LastName, Person.species);
            Console.WriteLine($"Person 1 Type: {Person1.GetType()}");

            Person Person2 = new Person("Jane", "Smith");
            Console.WriteLine("Person 2: {0} {1}, {2}", Person2.FirstName, Person2.LastName, Person.species);
            Console.WriteLine($"Person 2 Type: {Person2.GetType()}");

            Console.ReadLine();

        }
    }
}
