using System;

namespace a4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person1");
            Console.WriteLine("Hourly Rate?");
            double p1_rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int p1_hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person2");
            Console.WriteLine("Hourly Rate?");
            double p2_rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int p2_hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1");
            double p1_annual = p1_rate * p1_hours * 52;
            Console.WriteLine(p1_annual);
            Console.WriteLine("Annual Salary of Person 2");
            double p2_annual = p2_rate * p2_hours * 52;
            Console.WriteLine(p2_annual);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1_annual > p2_annual);

            Console.ReadLine();
        }
    }
}
