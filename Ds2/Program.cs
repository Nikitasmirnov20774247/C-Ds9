Console.Clear();

Console.Write("Введите число m(от): ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n(до): ");
int n = int.Parse(Console.ReadLine());

if (n < m)
{
    Console.Write("!! Число n не может быть меньше m !!");
    return;
}

int WriteNumner(int m, int n)
{
    Console.Write(m);
    if (m != n)
    {
        Console.Write(", ");
    }
    if(m == n) return n;
    return WriteNumner(m + 1,n);
}

int WriteNumnerSum(int m, int n, int sum = 0)
{
    sum += m;
    if(m == n) return sum;
    return WriteNumnerSum(m + 1,n, sum);    
}

Console.WriteLine();
Console.WriteLine($"Вывод чисел от {m} до {n}:");
WriteNumner(m,n);

Console.WriteLine();
Console.WriteLine("Сумма данных чисел = " + WriteNumnerSum(m,n));