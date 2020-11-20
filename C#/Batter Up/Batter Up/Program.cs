using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batter_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            int bats = int.Parse(Console.ReadLine());
            int batCount = 0;
            double battingAvg = 0;
            string runs = Console.ReadLine();
            string[] runsSplit = runs.Split(' ');

            for (int i = 0; i < bats; i++)
            {
                if (runsSplit[i] == "-1")
                {
                    continue;
                }
                battingAvg += int.Parse(runsSplit[i]);
                batCount++;
            }

            battingAvg = battingAvg / batCount;

            Console.WriteLine(battingAvg);

            Console.ReadKey();
        }
    }
}
