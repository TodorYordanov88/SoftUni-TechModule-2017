﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyContent = double.Parse(Console.ReadLine());
            var sugarContent = double.Parse(Console.ReadLine());

            var kCal = (volume / 100) * energyContent;
            var sugar = (volume / 100) * sugarContent;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kCal}kcal, {sugar}g sugars");
        }
    }
}
