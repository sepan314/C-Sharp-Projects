﻿using System;
namespace a18
{
    public class Employee : Person
    {

        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

    }
}
