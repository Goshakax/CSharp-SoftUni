int foodQuantity = int.Parse(Console.ReadLine());
int[] ordersSeq =
     Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
Queue<int> ordersQueue = new Queue<int>(ordersSeq);

Console.WriteLine(ordersQueue.Max());

while (ordersQueue.Count != 0)
{
    int currOrder = ordersQueue.Peek();


    if (foodQuantity >= currOrder)
    {
        foodQuantity -= currOrder;
        ordersQueue.Dequeue();
    }
    else
    {
        break;
    }

}

if (ordersQueue.Count > 0)
{
    Console.WriteLine($"Orders left: {string.Join(" ", ordersQueue)}");
}
else
{
    Console.WriteLine("Orders complete");
}