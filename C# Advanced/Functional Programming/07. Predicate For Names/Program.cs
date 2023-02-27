int n = int.Parse(Console.ReadLine());
List<string> names = Console.ReadLine().Split().ToList();
Predicate<string> validNames = name => name.Length <= n;

var result = names.FindAll(validNames);

Console.WriteLine(string.Join('\n', result));

