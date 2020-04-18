using System;

namespace a21
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers myNum = new Numbers();
            myNum.Amount = 5.0m;

            Console.WriteLine(myNum.Amount);

            Console.ReadLine();
        }
    }
}
