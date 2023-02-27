using System.Collections.Generic;
using System.Reflection.Metadata;

List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
int n = int.Parse(Console.ReadLine());
Predicate<int> dividedBy = x => x % n != 0;

var result = nums.FindAll(dividedBy);
result.Reverse();

Console.WriteLine(string.Join(' ', result));
