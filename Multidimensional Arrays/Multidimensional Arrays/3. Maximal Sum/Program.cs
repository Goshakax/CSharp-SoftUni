int[] matrixRowCol = Console.ReadLine()
             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();
int rows = matrixRowCol[0];
int cols = matrixRowCol[1];
int[,] matrix = new int[rows, cols];
int startingRow = 0;
int startingCol = 0;
int maxSum = 0;

ReadMatrix(matrix);

if (rows < 3 || cols < 3)
{

}
else
{
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            int currSum = 0;

            if (row == rows - 2 || col == cols - 2 || row == rows - 1 || col == cols - 1)
            {
                break;
            }
            else
            {
                for (int currRow = row; currRow < row + 3; currRow++)
                {
                    for (int currCol = col; currCol < col + 3; currCol++)
                    {
                        currSum += matrix[currRow, currCol];
                    }
                }

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    startingRow = row;
                    startingCol = col;

                }
            }
        }
    }


    Console.WriteLine($"Sum = {maxSum}");
    PrintMatrix(matrix, startingRow, startingCol);
}




void PrintMatrix(int[,] matrix, int startingRow, int startingCol)
{

    for (int currRow = startingRow; currRow < startingRow + 3; currRow++)
    {
        for (int currCol = startingCol; currCol < startingCol + 3; currCol++)
        {
            Console.Write(matrix[currRow, currCol] + " ");
        }

        Console.WriteLine();
    }
}

void ReadMatrix(int[,] matrix)
{

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        int[] rowData =
            Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = rowData[col];
        }
    }
}