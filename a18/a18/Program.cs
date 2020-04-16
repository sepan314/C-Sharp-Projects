using System;

namespace a18
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee p1 = new Employee();
            p1.firstName = "Sample";
            p1.lastName = "Student";
            p1.SayName();

            Console.ReadLine();

        }
    }
}
