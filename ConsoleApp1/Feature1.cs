﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Feature1
    {
        public void WriteInConsole(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteNumberInConsole(int number)
        {
            Console.WriteLine($"Youre input number is {number.ToString()} ");
        }
    }
}