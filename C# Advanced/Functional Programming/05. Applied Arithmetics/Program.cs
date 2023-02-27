using System.Data.Common;
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] updatedArr = new int[nums.Length];

string input = string.Empty;

while ((input = Console.ReadLine()) != "end")
{
    string cmd = input;

    if (cmd == "add")
    {
        Func<int[], int[]> afterCmd = (int[] nums) => AddCmd(nums);
        updatedArr = afterCmd(nums);
    }
    else if (cmd == "multiply")
    {
        Func<int[], int[]> afterCmd = (int[] nums) => MultiplyCmd(nums);
        updatedArr = afterCmd(nums);
    }
    else if (cmd == "subtract")
    {
        Func<int[], int[]> afterCmd = (int[] nums) => SubtractCmd(nums);
        updatedArr = afterCmd(nums);
    }
    else if (cmd == "print")
    {
        Console.WriteLine(string.Join(' ', updatedArr));
    }
}


int[] SubtractCmd(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i]--;
    }

    return nums;
}

int[] MultiplyCmd(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] *= 2;
    }

    return nums;
}

int[] AddCmd(int[] nums)
{

    for (int i = 0; i < nums.Length; i++)
    {
        nums[i]++;
    }

    return nums;
}