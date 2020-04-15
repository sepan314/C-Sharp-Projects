using System;
namespace a16
{
    public class App16
    {
        public void Method1(int int1)
        {
            Console.WriteLine(int1 / 2);
        }

        public void Method1()
        {
            Console.WriteLine("Boo ya");
        }

        public void Method2(out int a, out int b)
        {
            a = 25;
            b = 50;
        }


    }

}
