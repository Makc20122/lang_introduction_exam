// TASK 2

long Ackermann(long m, long n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Ackermann(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    else return 0;
}
Console.WriteLine("Введите первое число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Ackermann(m, n));