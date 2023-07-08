// Задача 64: Задайте значение N. Напишите программу, которая выведет
//  все натуральные четные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

       Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine($"Натуральные четные числа от {N} до 1:");
        PrintEvenNumbers(N);

        Console.ReadLine();

    static void PrintEvenNumbers(int n)
    {
        if (n <= 1)
            return;

        if (n % 2 == 0)
        {
            Console.WriteLine(n);
        }

        PrintEvenNumbers(n - 1);
    }
