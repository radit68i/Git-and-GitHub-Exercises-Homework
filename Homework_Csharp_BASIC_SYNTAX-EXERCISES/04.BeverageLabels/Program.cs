﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            //double energyContent = volume / 100.0 * energy * 1.0;
            //double sugarContent = volume / 100.0 * sugar * 1.0;

            double energyContent = (double)volume / 100d * (double)energy;
            double sugarContent = (double)volume / 100d * (double)sugar;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");


        }
    }
}
