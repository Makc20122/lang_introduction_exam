// TASK 1

void printNumbers(int m, int n)
{
    if (!(m == n + 1))
    {
        Console.Write($"{m} ");
        printNumbers(m + 1, n);
    }
}

Console.WriteLine("Введите первое число:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int n = Convert.ToInt32(Console.ReadLine());
printNumbers(m, n);