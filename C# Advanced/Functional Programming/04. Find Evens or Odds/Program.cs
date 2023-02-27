using System.Reflection.Metadata;

int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
List<int> list = new List<int>();
string evenOrOdd = Console.ReadLine();

for (int start = nums[0]; start <= nums[1]; start++)
{
    if (evenOrOdd.ToLower() == "even")
    {
        Predicate<int> predicateEven = num => num % 2 == 0;

        if (predicateEven(start))
        {
            list.Add(start);
        }

    }
    else if (evenOrOdd.ToLower() == "odd")
    {
        Predicate<int> predicateOdd = num => num % 2 != 0;

        if (predicateOdd(start))
        {
            list.Add(start);
        }
    }
}

Console.WriteLine(string.Join(' ', list));

