using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var feature1 = new Feature1();

            feature1.WriteInConsole("This is a demo . I am kind of bored");

            feature1.WriteNumberInConsole(45);
        }
    }
}