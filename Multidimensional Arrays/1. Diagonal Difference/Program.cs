int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];
int primarySum = 0;
int secondarySum = 0;
ReadMatrix(matrix, n);

for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {

        if (row == col)
        {
            primarySum += matrix[row, col];
        }

        if (row + col == n - 1)
        {
            secondarySum += matrix[row, col];
        }
    }

}

Console.WriteLine(Math.Abs(primarySum - secondarySum));


void ReadMatrix(int[,] matrix, int n)
{
    for (int row = 0; row < n; row++)
    {
        int[] rowData =
            Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < n; col++)
        {
            matrix[row, col] = rowData[col];
        }
    }
}