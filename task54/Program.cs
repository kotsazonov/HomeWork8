// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

  Console.Write("Введите количество строк: ");
        int rowCount = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int colCount = int.Parse(Console.ReadLine());

        int[,] array = new int[rowCount, colCount];

        Random rand = new Random();
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                array[i, j] = rand.Next(100); 
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        for (int i = 0; i < rowCount; i++)
        {
            BubbleSortDescending(array, i);
        }

        Console.WriteLine("Упорядоченный массив:");
        PrintArray(array);
    
    static void BubbleSortDescending(int[,] arr, int row)
    {
        int n = arr.GetLength(1);
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[row, j] < arr[row, j + 1])
                {
                    int temp = arr[row, j];
                    arr[row, j] = arr[row, j + 1];
                    arr[row, j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[,] arr)
    {
        int rowCount = arr.GetLength(0);
        int colCount = arr.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

