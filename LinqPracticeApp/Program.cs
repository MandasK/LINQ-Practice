using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter ' L

            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit[0] == 'L'
            select fruit;

            Console.WriteLine("These Guys are L'Licious.");
            Console.WriteLine();
            foreach (string L in LFruits)
            {
                Console.WriteLine($"{L}");
            }

        }
    }
}