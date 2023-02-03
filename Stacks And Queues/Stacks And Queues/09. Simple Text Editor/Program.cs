using System.Text;

int n = int.Parse(Console.ReadLine());
StringBuilder stringBuilder = new StringBuilder();
Stack<string> lastArg = new Stack<string>();
Stack<string> lastCmd = new Stack<string>();

for (int i = 0; i < n; i++)
{
    string[] cmdsArr =
        Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string cmd = cmdsArr[0];


    if (cmd == "1")
    {
        string cmdArg = cmdsArr[1];
        stringBuilder.Append(cmdArg);
        lastArg.Push(cmdArg);
        lastCmd.Push(cmd);

    }
    else if (cmd == "2")
    {
        int cmdArg = int.Parse(cmdsArr[1]);
        string toBeErased =
            stringBuilder
            .ToString()
            .Substring((stringBuilder.Length - 1) - (cmdArg - 1));

        stringBuilder.Remove((stringBuilder.Length - 1) - (cmdArg - 1), cmdArg);

        lastCmd.Push(cmd);
        lastArg.Push(toBeErased);
    }
    else if (cmd == "3")
    {
        int cmdArg = int.Parse(cmdsArr[1]);
        Console.WriteLine(stringBuilder[cmdArg - 1]);

    }
    else if (cmd == "4")
    {
        if (lastCmd.Peek() == "1")
        {
            lastCmd.Pop();
            stringBuilder.Replace(lastArg.Pop(), "");
        }
        else if (lastCmd.Peek() == "2")
        {
            lastCmd.Pop();
            stringBuilder.Append(lastArg.Pop());
        }

    }

}

