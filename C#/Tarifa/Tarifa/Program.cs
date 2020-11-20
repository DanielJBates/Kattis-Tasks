using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthlyData = int.Parse(Console.ReadLine());
            int numberOfMonths = int.Parse(Console.ReadLine());
            int rollover = 0;

            for (int i = 0; i < numberOfMonths; i++)
            {
                if (rollover < 0)
                {
                int dataUsed = int.Parse(Console.ReadLine());
                rollover = monthlyData - dataUsed;
                }
                else
                {
                    int dataUsed = int.Parse(Console.ReadLine());
                    rollover = (monthlyData + rollover) - dataUsed; 
                }
            }

            Console.WriteLine(monthlyData + rollover);

            Console.ReadKey();
        }
    }
}
