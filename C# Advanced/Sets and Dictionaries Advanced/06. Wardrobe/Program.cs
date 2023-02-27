using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(',').ToArray();

                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                }


                foreach (var clothing in clothes)
                {
                    if (!dict[color].ContainsKey(clothing))
                    {
                        dict[color].Add(clothing, 0);
                    }

                    dict[color][clothing]++;
                }

            }

            string[] searching = Console.ReadLine().Split(' ');

            foreach (var curr in dict)
            {
                Console.WriteLine($"{curr.Key} clothes:");

                foreach (var clothing in dict[curr.Key])
                {

                    if (searching[0] == curr.Key && searching[1] == clothing.Key)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }
                }

            }

        }
    }
}
