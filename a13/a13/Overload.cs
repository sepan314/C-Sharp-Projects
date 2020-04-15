using System;
namespace a13
{
    public class Overload
    {
        public int Method(int integer)
        {
            return integer *= 10;
        }

        public int Method(decimal dec)
        {
            return Convert.ToInt32(dec /= 2);
        }

        public int Method(string str)
        {
            return Convert.ToInt32(str) + 100;
        }


    }
}
