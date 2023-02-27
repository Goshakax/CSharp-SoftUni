int rows = int.Parse(Console.ReadLine());
double[][] jaggedArr = new double[rows][];

ReadJaggedArray(jaggedArr, rows);

for (int row = 0; row < rows; row++)
{

    if (row == rows - 1)
    {
        break;
    }
    else if (jaggedArr[row].Length == jaggedArr[row + 1].Length)
    {
        for (int col = 0; col < jaggedArr[row].Length; col++)
        {
            jaggedArr[row][col] *= 2;
            jaggedArr[row + 1][col] *= 2;
        }
    }
    else
    {
        for (int col = 0; col < jaggedArr[row].Length; col++)
        {
            jaggedArr[row][col] /= 2;

        }

        for (int col = 0; col < jaggedArr[row + 1].Length; col++)
        {
            jaggedArr[row + 1][col] /= 2;
        }
    }
}

string input = string.Empty;

while ((input = Console.ReadLine()) != "End")
{
    string[] cmdArr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string cmd = cmdArr[0];

    if (cmd == "Add")
    {
        int rowArg = int.Parse(cmdArr[1]);
        int colArg = int.Parse(cmdArr[2]);
        int value = int.Parse(cmdArr[3]);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < jaggedArr[row].Length; col++)
            {
                if (rowArg == row && colArg == col)
                {
                    jaggedArr[row][col] += value;
                }
            }
        }
    }
    else if (cmd == "Subtract")
    {
        int rowArg = int.Parse(cmdArr[1]);
        int colArg = int.Parse(cmdArr[2]);
        int value = int.Parse(cmdArr[3]);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < jaggedArr[row].Length; col++)
            {
                if (rowArg == row && colArg == col)
                {
                    jaggedArr[row][col] -= value;
                }
            }
        }
    }
}

PrintJaggedArray(jaggedArr, rows);



void PrintJaggedArray(double[][] jaggedArr, int rows)
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < jaggedArr[row].Length; col++)
        {
            Console.Write(jaggedArr[row][col] + " ");
        }
        Console.WriteLine();
    }
}

void ReadJaggedArray(double[][] jaggedArr, int rows)
{
    for (int row = 0; row < rows; row++)
    {
        double[] rowArr =
            Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        jaggedArr[row] = new double[rowArr.Length];

        for (int col = 0; col < jaggedArr[row].Length; col++)
        {
            jaggedArr[row][col] = rowArr[col];
        }
    }
}