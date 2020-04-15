using System;
using System.Collections.Generic;

namespace a11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> int_list = new List<int>() { 4, 10, 20 };
                Console.WriteLine("Please enter an integer: ");
                int input = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < int_list.Count; i++)
                {
                    int_list[i] = int_list[i] / input;
                    Console.WriteLine(int_list[i]);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("Continued...");
            Console.ReadLine();

        }
    }
}
