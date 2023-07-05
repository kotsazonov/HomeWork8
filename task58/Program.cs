// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

  Console.WriteLine("Введите размерность первой матрицы (строки, столбцы):");
        int rows1 = int.Parse(Console.ReadLine());
        int cols1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите размерность второй матрицы (строки, столбцы):");
        int rows2 = int.Parse(Console.ReadLine());
        int cols2 = int.Parse(Console.ReadLine());

        if (cols1 != rows2)
        {
            Console.WriteLine("Умножение матриц невозможно. Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
            return;
        }

        int[,] matrix1 = GenerateRandomMatrix(rows1, cols1);
        int[,] matrix2 = GenerateRandomMatrix(rows2, cols2);

        int[,] result = MultiplyMatrices(matrix1, matrix2);

        Console.WriteLine("Первая матрица:");
        PrintMatrix(matrix1);

        Console.WriteLine("Вторая матрица:");
        PrintMatrix(matrix2);

        Console.WriteLine("Результат умножения матриц:");
        PrintMatrix(result);
    

    static int[,] GenerateRandomMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }

        return matrix;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

