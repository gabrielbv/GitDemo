using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Feature1
    {
        public void WriteInConsole(string message)
        {
            Console.WriteLine(message);
        }

        public void WriteNumberInConsole(int numbers)
        {
            Console.WriteLine(numbers.ToString());
        }
    }
}