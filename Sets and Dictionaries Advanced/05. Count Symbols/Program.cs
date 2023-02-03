using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<char, int>();
            string input = Console.ReadLine();

            foreach (char currChar in input)
            {
                if (!dict.ContainsKey(currChar))
                {
                    dict.Add(currChar, 0);
                }

                dict[currChar]++;
            }

            dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var currChar in dict)
            {
                Console.WriteLine($"{currChar.Key}: {currChar.Value} time/s");
            }

        }
    }
}
