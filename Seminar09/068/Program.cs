// Напишите программу вычисления функции Аккермана
// Даны два неотрицательных числа m и n

int PW(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return PW(m - 1, 1);
    if (m > 0 && n > 0) return PW(m - 1, PW(m, n - 1));
    return PW(n, m);
}

int res = PW(3, 5);
Console.WriteLine($"{res}");