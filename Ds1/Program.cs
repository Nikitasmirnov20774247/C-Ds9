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

Console.WriteLine();
Console.WriteLine($"Вывод чисел от {m} до {n}:");
WriteNumner(m,n);