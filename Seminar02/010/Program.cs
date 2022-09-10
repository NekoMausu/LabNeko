// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine());
int num1 = num % 10;
int num2 = num % 100;
Console.WriteLine((num2-num1)/10);
