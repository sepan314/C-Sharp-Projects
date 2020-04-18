using System;
using System.Collections.Generic;

namespace a19
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> e1 = new Employee<string>();
            e1.Things = new List<string>() { "pen", "paper", "keys" };

            Employee<int> e2 = new Employee<int>
            {
                Things = new List<int>() { 1, 3, 5, 7 }
            };

            foreach (string item in e1.Things)
            {
                Console.WriteLine(item);
            }

            foreach (int item in e2.Things)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
