Queue<int> queue = new Queue<int>();
int[] reqs = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
int numToEnqueue = reqs[0];
int numToDequeue = reqs[1];
int lookingFor = reqs[2];
int smallest = int.MaxValue;
bool isFound = false;
int[] seq = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();


foreach (var item in seq)
{
    queue.Enqueue(item);
}

for (int i = 0; i < numToDequeue; i++)
{
    queue.Dequeue();
}

if (queue.Count == 0)
{
    smallest = 0;
}

while (queue.Count != 0)
{
    int currNum = queue.Dequeue();

    if (currNum == lookingFor)
    {
        Console.WriteLine("true");
        isFound = true;
        break;
    }
    else if (currNum < smallest)
    {
        smallest = currNum;
    }
}

if (!isFound)
{
    Console.WriteLine(smallest);
}
