using System;
using System.Collections.Generic;

namespace a9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "red", "yellow", "blue", "green", "pink" };
            Console.WriteLine("Please enter an index number: ");
            int index1 = Convert.ToInt32(Console.ReadLine());
            if (index1 < 0 || index1 >= array1.Length)
            {
                Console.WriteLine("Index out of bounds");
            }
            else
            {
                Console.WriteLine(array1[index1]);
            }

            int[] array2 = { 2, 4, 6, 8, 10 };
            Console.WriteLine("Please enter an index number: ");
            int index2 = Convert.ToInt32(Console.ReadLine());
            if (index2 < 0 || index2 >= array2.Length)
            {
                Console.WriteLine("Index out of bounds");
            }
            else
            {
                Console.WriteLine(array2[index2]);
            }

            List<string> list1 = new List<string>() { "MA", "NY", "CA" };
            Console.WriteLine("Please enter an index number: ");
            int index3 = Convert.ToInt32(Console.ReadLine());
            if (index3 < 0 || index3 >= list1.Count)
            {
                Console.WriteLine("Index out of bounds");
            }
            else
            {
                Console.WriteLine(list1[index3]);
            }

            Console.ReadLine();
        }
    }
}
