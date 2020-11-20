using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spavanac
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTime = Console.ReadLine();
            string[] HM = inputTime.Split(' ');
            int hours = int.Parse(HM[0]);
            int mins = int.Parse(HM[1]);

            mins = mins - 45;

            if (mins < 0)
            {
                if (hours == 0)
                {
                    hours = 23;
                }
                else
                {
                    hours--;
                }
                mins = mins + 60;
            }

            Console.WriteLine(hours + " " + mins);
            Console.ReadKey();
        }
    }
}
