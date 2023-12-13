int akkerman(int m, int n)
{
if (m == 0) 
    return n + 1;
else 
    if (n == 0) 
        return akkerman(m - 1, 1);
    else 
        return akkerman(m - 1, akkerman(m, n - 1));
}
Console.Clear();
Console.Write("Введите неотрицательное число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите неотрицательное число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");