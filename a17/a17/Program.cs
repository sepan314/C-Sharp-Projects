using System;

namespace a17
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee p1 = new Employee();
            p1.Id = 1;

            Employee p2 = new Employee();
            p2.Id = 2;

            Console.WriteLine(p1 == p2);

            Console.ReadLine();

        }


    }
}
