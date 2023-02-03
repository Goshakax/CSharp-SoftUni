using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            HashSet<int> similar = new HashSet<int>();
            int[] arg =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int set1 = arg[0];
            int set2 = arg[1];

            for (int i = 0; i < set1; i++)
            {
                int num = int.Parse(Console.ReadLine());
                set.Add(num);
            }

            for (int i = 0; i < set2; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (set.Contains(num))
                {
                    similar.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", similar));

        }
    }
}
