using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Feature1
    {
        public void WriteInConsole(string message = "")
        {
            if (String.IsNullOrEmpty(message))
            {
                message = " No Message Provided";
            }
            Console.WriteLine(message);
        }

        public void WriteNumberInConsole(int number)
        {
            Console.WriteLine($"Youre input number is {number.ToString()} ");
        }
    }
}