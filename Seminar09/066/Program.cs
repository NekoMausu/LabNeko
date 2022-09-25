// Задайте значение M и N. Напишите программу, которая найдет
// сумму натуральных элементов в промежутке от M до N

int PW(int m, int n)
{
    if (m != n) return m += PW(++m, n);
    return m;
}

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{PW(a, b)}");