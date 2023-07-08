Console.Clear();
int size = 5;
int[,] array = new int[size, size];
SpiralFillArray(array, size);       // Метод № 1 - заполнение массива по спирали. 
PrintArray(array, size);            // Метод № 2 - вывод массива на печать. 

// МЕТОДЫ
// Метод № 1 - заполнение массива по спирали. 
void SpiralFillArray(int[,] array, int size)
{
    int value = 1;                // Значение элемента [0, 0].          
    int i = 0;
    int j = 0;
    while (value <= size * size)  // Диапазон значений элементов массива. 
    {
        array[i, j] = value;
        if (i <= j + 1 && i + j < size - 1)  // Заполнение строк слева направо.
            j++;                             // Возврат увлеличенного значения j.
        else if (i < j && i + j >= size - 1) // Заполнение столбцов сверху вниз. 
            i++;                             // Возврат увлеличенного значения i.
        else if (i >= j && i + j > size - 1) // Заполнение строк справа налево. 
            j--;                             // Возврат уменьшенного значения j.
        else                                 // Заполнение столбцов снизу вверх. 
            i--;                             // Возврат уменьшенного значения i. 
        value++;
    }
}

//  Метод № 2 - вывод массива на печать.
void PrintArray(int[,] array, int size)
{
    Console.WriteLine($"Массив, имеющий размер {size} х {size}, заполнен по спирали.");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + " ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
