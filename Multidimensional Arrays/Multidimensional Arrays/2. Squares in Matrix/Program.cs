int[] matrixRowCol = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
int rows = matrixRowCol[0];
int cols = matrixRowCol[1];
int counter = 0;
string[,] matrix = new string[rows, cols];

ReadMatrix(matrix, rows, cols);

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        if (row == rows - 1 || col == cols - 1)
        {
            break;
        }
        else if (matrix[row, col] == matrix[row + 1, col] && matrix[row + 1, col] == matrix[row, col + 1] && matrix[row, col + 1] == matrix[row + 1, col + 1])
        {
            counter++;
        }

    }
}

Console.WriteLine(counter);


void ReadMatrix(string[,] matrix, int rows, int cols)
{
    for (int row = 0; row < rows; row++)
    {
        string[] rowData =
            Console.ReadLine()
            .Split();

        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = rowData[col];
        }
    }
}