// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


//Создает числовую матрицу 
int[,] NewMatrix(int rows, int colums, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, colums];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

// Рассчитывает произведение матриц
int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int Product(int[,] matrix1, int[,] matrix2, int rows, int colums, int num)
    {
        int product = 0;
        if (matrix1.GetLength(1) == num) return product;
        else
        {
            return product = matrix1[rows, num] * matrix2[num, colums] + Product(matrix1, matrix2, rows, colums, num + 1);
        }
    }



    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Product(matrix1, matrix2, i, j, 0);
        }
    }
    return result;
}


BenchmarkRunner.Run ListOfSortingBenchmark();

void ListOfSortingBenchmark()
{
    int[,] matrix1 = NewMatrix(100, 100, 0, 1000);
    int[,] matrix2 = NewMatrix(100, 100, 0, 1000);
    int[,] result = MatrixProduct(matrix1, matrix2);
}
