Stack<int> stack = new Stack<int>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{

    int[] cmds = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    string cmd = string.Empty;
    int cmdNum = cmds[0];
    int cmdArg = 0;

    if (cmdNum == 1)
    {
        cmd = "Push";
        cmdArg = cmds[1];
    }
    else if (cmdNum == 2)
    {
        cmd = "Delete";
    }
    else if (cmdNum == 3)
    {
        cmd = "Print max";
    }
    else if (cmdNum == 4)
    {
        cmd = "Print min";
    }

    if (cmd == "Push")
    {
        stack.Push(cmdArg);

    }
    else if (cmd == "Delete")
    {
        stack.Pop();
    }
    else if (cmd == "Print min")
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Min());

        }
    }
    else if (cmd == "Print max")
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Max());
        }

    }

}


Console.WriteLine(string.Join(", ", stack));