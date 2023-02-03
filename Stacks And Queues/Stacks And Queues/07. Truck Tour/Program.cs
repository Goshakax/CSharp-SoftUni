int n = int.Parse(Console.ReadLine());
Queue<string> queue = new Queue<string>();
int litersIn = 0;
string firstIndex = string.Empty;
string index = string.Empty;
string currFirstIndex = string.Empty;

for (int i = 0; i < n; i++)
{
    string pumpsInfo = i.ToString() + " " + Console.ReadLine();
    queue.Enqueue(pumpsInfo);
    if (i + 1 == n)
    {
        break;
    }
}

while (queue.Count != 0)
{

    string[] currInfos = queue.Peek().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int currIndex = int.Parse(currInfos[0]);
    int currLiters = int.Parse(currInfos[1]);
    int kmToNext = int.Parse(currInfos[2]);
    litersIn += currLiters;

    if (litersIn < kmToNext)
    {
        queue.Enqueue(queue.Dequeue());
        litersIn = 0;

        string[] firstPump = queue.Peek()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        firstIndex = firstPump[0];
        currFirstIndex = firstIndex;
    }
    else
    {
        queue.Enqueue(queue.Dequeue());
        litersIn -= kmToNext;
        string[] firstPump = queue.Peek()
.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        index = firstPump[0];

        if (currFirstIndex == string.Empty)
        {
            currFirstIndex = currIndex.ToString();
        }
    }

    if (currFirstIndex == index)
    {
        break;
    }

}


Console.WriteLine(currFirstIndex);
