using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;

int n = int.Parse(Console.ReadLine());
List<string> names = Console.ReadLine().Split().ToList();

Predicate<string> find = name => IsBiggerThan(n, NameCharSum(name));

string resultName = names.Find(find);

Console.WriteLine(resultName);


int NameCharSum(string name)
{
    int sum = 0;

    foreach (char currChar in name)
    {
        sum += currChar;
    }

    return sum;
}

bool IsBiggerThan(int n, int sum)
{
    if (n > sum)
    {
        return false;
    }
    return true;
}