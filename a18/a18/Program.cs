using System;

namespace a18
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee p1 = new Employee();
            p1.name = "John Smith";
            p1.Quit();

            IQuittable p2 = new Employee { name = "Sarah Smith" };
            p2.Quit();


            Console.ReadLine();

        }
    }
}
