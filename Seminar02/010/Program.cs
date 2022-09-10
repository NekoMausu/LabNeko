// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int num1 = num / 10;
num = num1 % 10;
Console.WriteLine(num);
