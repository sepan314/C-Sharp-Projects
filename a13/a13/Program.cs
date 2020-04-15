using System;

namespace a13
{
    class Program
    {
        static void Main(string[] args)
        {
            Overload s1 = new Overload();
            Console.WriteLine(s1.Method(3));

            Overload s2 = new Overload();
            Console.WriteLine(s2.Method(5.5m));

            Overload s3 = new Overload();
            Console.WriteLine(s3.Method("20"));

            Console.ReadLine();
        }
    }
}
