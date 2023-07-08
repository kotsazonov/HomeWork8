     int m1 = 2;
        int n1 = 3;
        int result1 = Ackermann(m1, n1);
        Console.WriteLine($"A({m1}, {n1}) = {result1}");

        int m2 = 3;
        int n2 = 2;
        int result2 = Ackermann(m2, n2);
        Console.WriteLine($"A({m2}, {n2}) = {result2}");

        Console.ReadLine();
    

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

