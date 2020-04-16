using System;

namespace a17
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee p1 = new Employee();
            p1.FirstName = "Sample";
            p1.LastName = "Student";
            p1.SayName();

            Console.ReadLine();

        }
    }
}
