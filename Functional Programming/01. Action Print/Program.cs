string[] namesArr = Console.ReadLine().Split();

Action<string[]> name = namesArr => Console.WriteLine(string.Join("\n", namesArr));
name(namesArr);



