string[] names = Console.ReadLine().Split();

Action<string[]> printNamesSir = names => Array.ForEach(names, name => Console.WriteLine($"Sir {name}"));

printNamesSir(names);