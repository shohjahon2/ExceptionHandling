using System;
using Task2;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string enteredString = Console.ReadLine();
            try
            {
                Console.WriteLine(enteredString[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}