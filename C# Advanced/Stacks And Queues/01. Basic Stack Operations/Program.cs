int[] cmd = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

int numToPush = cmd[0];
int numToPop = cmd[1];
int lookingFor = cmd[2];
int smallest = int.MaxValue;
bool isFound = false;

int[] seq = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();

Stack<int> stack = new Stack<int>();

foreach (var item in seq)
{
    stack.Push(item);
}

for (int i = 0; i < numToPop; i++)
{
    stack.Pop();
}

if (stack.Count == 0)
{
    smallest = 0;
}

while (stack.Count != 0)
{
    int currPop = stack.Pop();
    if (currPop == lookingFor)
    {
        Console.WriteLine("true");
        isFound = true;
        break;
    }
    else if (currPop < smallest)
    {
        smallest = currPop;
    }

}



if (!isFound)
{
    Console.WriteLine(smallest);
}