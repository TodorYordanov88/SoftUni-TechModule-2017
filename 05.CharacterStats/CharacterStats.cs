using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maximumHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write($"Health: " + new string('|', 1) + new string('|', currentHealth ) + 
                new string('.', maximumHealth - currentHealth) + new string('|', 1));
            Console.WriteLine();
            Console.Write($"Energy: " + new string('|', 1) + new string('|', currentEnergy) +
                              new string('.', maximumEnergy - currentEnergy) + new string('|', 1));
        }
    }
}
