using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filip
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] subStrings = input.Split(' ');

            char[] first = subStrings[0].ToCharArray();
            char[] second = subStrings[1].ToCharArray();

            Array.Reverse(first);
            string firstS = new string(first);
            Array.Reverse(second);
            string secondS = new string(second);

            if (int.Parse(firstS) > int.Parse(secondS))
            {
                Console.WriteLine(firstS);
            }
            else
            {
                Console.WriteLine(secondS);
            }
            
        }
    }
}
