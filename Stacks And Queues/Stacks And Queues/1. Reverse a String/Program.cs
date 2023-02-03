string input = Console.ReadLine();
Stack<char> stack = new Stack<char>();

foreach (char item in input)
{
    stack.Push(item);
}


Console.WriteLine(string.Join("", stack));