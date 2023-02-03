int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

Func<int[], int> printSmallest = (int[] nums) => nums.Min();

Console.WriteLine(printSmallest(nums));