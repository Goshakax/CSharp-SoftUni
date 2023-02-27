using System.Diagnostics.SymbolStore;
using System.Net.Http.Json;

List<string> names = Console.ReadLine().Split().ToList();
string input = string.Empty;

while ((input = Console.ReadLine()) != "Party!")
{
    string[] cmdArr = input.Split();
    string cmd = cmdArr[0];
    string criteria = cmdArr[1];


    if (cmd == "Remove")
    {
        if (criteria == "StartsWith")
        {
            string arg = cmdArr[2];

            Predicate<string> predicate = name => StartsWith(name, arg);
            names.RemoveAll(predicate);
        }
        else if (criteria == "Length")
        {
            int arg = int.Parse(cmdArr[2]);

            Predicate<string> predicate = name => Length(name, arg);
            names.RemoveAll(predicate);
        }
        else if (criteria == "EndsWith")
        {
            string arg = cmdArr[2];

            Predicate<string> predicate = name => EndsWith(name, arg);
            names.RemoveAll(predicate);
        }
    }
    else if (cmd == "Double")
    {
        if (criteria == "StartsWith")
        {
            string arg = cmdArr[2];

            Predicate<string> predicate = name => StartsWith(name, arg);
            var peopleFound = names.FindAll(predicate);

            DoublingPeople(names, peopleFound);

        }
        else if (criteria == "EndsWith")
        {
            string arg = cmdArr[2];

            Predicate<string> predicate = name => EndsWith(name, arg);
            var peopleFound = names.FindAll(predicate);

            DoublingPeople(names, peopleFound);
        }

        else if (criteria == "Length")
        {
            int arg = int.Parse(cmdArr[2]);

            Predicate<string> predicate = name => Length(name, arg);
            var peopleFound = names.FindAll(predicate);

            DoublingPeople(names, peopleFound);
        }
    }
}


if (names.Count != 0)
{
    Console.WriteLine($"{string.Join(", ", names)} are going to the party!");

}
else
{
    Console.WriteLine("Nobody is going to the party!");
}


List<string> DoublingPeople(List<string> names, List<string> peopleFound)
{
    for (int i = 0; i < names.Count; i++)
    {
        for (int j = 0; j < peopleFound.Count; j++)
        {
            if (names[i] == peopleFound[j])
            {
                names.Insert(i, peopleFound[j]);
                peopleFound.Remove(peopleFound[j]);

            }

            if (peopleFound.Count == 0)
            {
                break;
            }
        }
        if (peopleFound.Count == 0)
        {
            break;
        }
    }

    return names;
}

bool StartsWith(string name, string arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        if (name[i] != arg[i])
        {
            return false;
        }
    }
    return true;
}

bool EndsWith(string name, string arg)
{
    //for (int i = arg.Length - 1; i >= 0; i--)
    //{
    //    if (name[name.Length-i] != arg[i])
    //    {
    //        return false;
    //    }
    //}

    string nameLast = name.Substring(name.Length - arg.Length);

    if (nameLast != arg)
    {
        return false;
    }
    return true;
}

bool Length(string name, int arg)
{
    if (name.Length != arg)
    {
        return false;
    }
    return true;
}