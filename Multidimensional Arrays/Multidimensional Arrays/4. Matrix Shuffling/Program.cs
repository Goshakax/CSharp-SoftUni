int[] matrixRowCol =
               Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
int rows = matrixRowCol[0];
int cols = matrixRowCol[1];
string[,] matrix = new string[rows, cols];
string input = string.Empty;

ReadMatrix(matrix);

while ((input = Console.ReadLine()) != "END")
{
    string[] inputArr = input
        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
    string cmd = inputArr[0];

    if (inputArr.Length != 5 || cmd != "swap")
    {
        Console.WriteLine("Invalid input!");
    }
    else
    {
        int row1 = int.Parse(inputArr[1]);
        int col1 = int.Parse(inputArr[2]);
        int row2 = int.Parse(inputArr[3]);
        int col2 = int.Parse(inputArr[4]);

        if (row1 >= rows || col1 >= cols || row2 >= rows || col2 >= cols)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            string element1 = string.Empty;
            string element2 = string.Empty;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == row1 && col == col1)
                    {
                        element1 = matrix[row, col];
                    }
                    else if (row == row2 && col == col2)
                    {
                        element2 = matrix[row, col];
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == row1 && col == col1)
                    {
                        matrix[row, col] = element2;
                    }
                    else if (row == row2 && col == col2)
                    {
                        matrix[row, col] = element1;
                    }
                }
            }

            PrintMatrix(matrix);
        }

    }
}



void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }
        Console.WriteLine();
    }
}

void ReadMatrix(string[,] matrix)
{

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        string[] rowData =
            Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = rowData[col];
        }
    }
}