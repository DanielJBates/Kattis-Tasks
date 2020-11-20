using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_Two_Stones
{
    class Program
    {
        static void Main(string[] args)
        {
            int stones = int.Parse(Console.ReadLine());

            if (stones % 2 == 0)
            {
                Console.WriteLine("Bob");
            }
            else
            {
                Console.WriteLine("Alice");
            }

            Console.ReadKey();
        }
    }
}
