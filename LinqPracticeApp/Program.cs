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

            Console.WriteLine("These Guys are L'Licious:");
            Console.WriteLine();
            foreach (string L in LFruits)
            {
                Console.WriteLine($"{L}");
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("These guys are MULTIPLYING! It's Electrifying! (but only sixeys and foursies)");
            foreach (int num in fourSixMultiples)
            {
                Console.WriteLine(num);
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            List<string> descend = names.OrderByDescending(name => name).ToList();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Show me some names in Reverse Alphabet!");
            descend.ForEach(name => Console.WriteLine($"{name}"));

            // Build a collection of these numbers sorted in ascending order
            List<int> numbersAgain = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            List<int> ascend = numbersAgain.OrderBy(num => num).ToList();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Show me some numbers in order from Smallest to BIGGEST!");
            ascend.ForEach(num => Console.WriteLine($"{num}"));

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };
            double purchaseSum = purchases.Sum();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Show me how rich I am");
            Console.WriteLine($"You got ${purchaseSum}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };
            double mostExpensive = prices.Max();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Show me how expensive");
            Console.WriteLine($"Most expensive item ${mostExpensive}");
        }
    }
}