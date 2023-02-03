string parentheses = Console.ReadLine();
Stack<string> stack = new Stack<string>();
bool isGood = false;

if (parentheses.Length % 2 != 0)
{
    Console.WriteLine("NO");
}
else
{
    for (int i = 0; i < parentheses.Length / 2; i++)
    {
        if (parentheses[i] == '{' || parentheses[i] == '[' || parentheses[i] == '(')
        {
            stack.Push(parentheses[i].ToString());
        }
    }

    if (stack.Count != 0)
    {
        for (int i = parentheses.Length / 2; i < parentheses.Length; i++)
        {
            if (stack.Peek() == "{" && parentheses[i] == '}')
            {
                stack.Pop();
            }
            else if (stack.Peek() == "[" && parentheses[i] == ']')
            {
                stack.Pop();
            }
            else if (stack.Peek() == "(" && parentheses[i] == ')')
            {
                stack.Pop();
            }
        }
        isGood = true;
    }

    if (isGood)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}

