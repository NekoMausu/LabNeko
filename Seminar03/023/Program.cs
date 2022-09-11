// Напишите программу, которая принимает на вход число N
// и выдает таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine());
int ind = 1;
while (ind <= N)
{
    Console.Write($"{Math.Pow(ind, 3)}, ");
    ind++;
}
