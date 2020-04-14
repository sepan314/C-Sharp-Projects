using System;
using System.Collections.Generic;

namespace a10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     1.");

            string[] text = { "a", "b", "c", "d", "e" };
            Console.WriteLine("Please enter a string: ");
            string str = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                text[i] += str;
            }

            foreach (string i in text)
            {
                Console.WriteLine(i);
            }

            //Console.WriteLine("2.");
            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("     3.");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("     4.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("     5.");
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("     6.");
            List<string> str_list = new List<string>() { "mon", "tues", "wed", "thurs", "fri" };
            Console.WriteLine("Please enter a string: ");
            string str1 = Console.ReadLine();
            bool str_exist = false;
            for (int i = 0; i < str_list.Count; i++)
            {
                if (str_list[i] == str1)
                {
                    str_exist = true;
                    Console.WriteLine(i);
                    break;

                }
            }
            if (!str_exist)
            {
                Console.WriteLine("Your string is not in list.");

            }

            Console.WriteLine("     9.");
            List<string> str_list2 = new List<string>() { "jan", "feb", "mar", "apr", "apr" };
            Console.WriteLine("Please enter a string: ");
            string str2 = Console.ReadLine();
            bool str_exist2 = false;
            for (int i = 0; i < str_list2.Count; i++)
            {
                if (str_list2[i] == str2)
                {
                    str_exist2 = true;
                    Console.WriteLine(i);
                }
            }
            if (!str_exist2)
            {
                Console.WriteLine("Your string is not in list.");

            }

            Console.WriteLine("     11.");
            List<string> str_list3 = new List<string>() { "jan", "feb", "mar", "apr", "apr" };
            List<string> str_new = new List<string>();
            string msg;
            foreach (string i in str_list3)
            {

                if (str_new.Contains(i))
                {
                    msg = "Has appeared in the list already";

                }
                else
                {
                    msg = "Has not appeared in the list already";
                }
                Console.WriteLine(i + " : " + msg);
                str_new.Add(i);


            }



            Console.ReadLine();

        }
    }
}
