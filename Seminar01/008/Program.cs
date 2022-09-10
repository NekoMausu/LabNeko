// Напишите программу, которая на вход принимает число (N)
// а на выходе показывает все четные числа от 1 до N
Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine());
int S = 2;
while (S<N) 
{
Console.Write($"{S}, ");
S=S+2;
}
