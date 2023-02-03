using System.Text;

int end = int.Parse(Console.ReadLine());
int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
var nums = new List<int>();

for (int i = 1; i <= end; i++)
{
    nums.Add(i);
}

Predicate<int> validation = num => ArrForeachNum(dividers, num);

var result = nums.FindAll(validation);

Console.WriteLine(string.Join(' ', result));

bool ArrForeachNum(int[] dividers, int num)
{

    foreach (var item in dividers)
    {
        if (num % item != 0)
        {
            return false;
        }
    }

    return true;
}