string[] songsSeq =
                Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
Queue<string> songsQueue = new Queue<string>(songsSeq);

while (songsQueue.Count != 0)
{
    List<string> cmds =
        Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

    string cmd = cmds[0];

    if (cmd == "Play")
    {
        songsQueue.Dequeue();
    }
    else if (cmd == "Show")
    {
        Console.WriteLine(string.Join(", ", songsQueue));
    }
    else if (cmd == "Add")
    {
        string songAdd = string.Empty;

        cmds.RemoveAt(0);

        songAdd = string.Join(' ', cmds);

        if (!songsQueue.Contains(songAdd))
        {
            songsQueue.Enqueue(songAdd);
        }
        else
        {
            Console.WriteLine($"{songAdd} is already contained!");
        }
    }
}

Console.WriteLine("No more songs!");