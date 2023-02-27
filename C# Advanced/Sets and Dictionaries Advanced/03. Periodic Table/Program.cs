using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] element =
                    Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < element.Length; j++)
                {
                    set.Add(element[j]);
                }
            }

            set = set.OrderBy(x => x).ToHashSet();

            Console.WriteLine(string.Join(" ", set));
        }
    }
}
