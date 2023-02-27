int[] clothesSeq =Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse).ToArray();

Stack<int> stackClothes = new Stack<int>(clothesSeq);
int rackCapacity = int.Parse(Console.ReadLine());
int currRack = rackCapacity;
int racks = 1;

while (stackClothes.Count != 0)
{
    int currClothing = stackClothes.Peek();


    if (currRack - currClothing >= 0)
    {
        currRack -= currClothing;
        stackClothes.Pop();
    }
    else
    {
        racks++;
        currRack = rackCapacity;
    }
}

Console.WriteLine(racks);