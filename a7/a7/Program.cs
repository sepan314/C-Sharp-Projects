using System;

namespace a7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("While Loop...");
            bool condition = true;
            int counter = 1;

            while (condition)
            {
                Console.WriteLine(counter);
                counter++;
                if (counter > 5)
                {
                    condition = false;
                }

            }

            condition = true;
            counter = 1;

            Console.WriteLine("Do/While Loop...");
            do
            {
                Console.WriteLine(counter);
                counter = counter * 5;
                if (counter > 125)
                {
                    condition = false;
                }
            }
            while (condition);


            Console.ReadLine();
        }

    }
}
