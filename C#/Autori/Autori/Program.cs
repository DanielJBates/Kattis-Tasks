using System;

namespace Autori
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] subStrings = input.Split('-');

            foreach (string name in subStrings)
            {
                Console.Write(name[0]);
            }
        }
    }
}
