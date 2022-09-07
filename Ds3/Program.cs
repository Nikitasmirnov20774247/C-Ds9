Console.Clear();

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.Write("!! Числа m или n не могут быть отрицательными !!");
    return;
}

int AckermanFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermanFunction(m - 1, 1);
  else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.WriteLine();
Console.WriteLine("Функция аккермана:");
Console.WriteLine("A(m, n) = " + AckermanFunction(m, n));