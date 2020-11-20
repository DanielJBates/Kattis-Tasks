using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck_In_A_Time_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int loops = int.Parse(Console.ReadLine());

            for (int i = 0; i < loops; i++)
            {
                Console.WriteLine((i + 1) + " Abracadabra");
            }
        }
    }
}
