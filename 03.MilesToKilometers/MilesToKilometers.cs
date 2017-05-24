using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            var mile = double.Parse(Console.ReadLine());
            var mileToKilimoter = mile * 1.60934;
            Console.WriteLine($"{mileToKilimoter:F2}");
        }
    }
}
