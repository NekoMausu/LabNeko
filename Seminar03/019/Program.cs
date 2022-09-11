// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. 12321
Console.WriteLine("Введите пятизначное число ");
int num = int.Parse(Console.ReadLine());
if (num % 10 == num / 10000 && (num % 100) / 10 == (num / 1000) % 10) Console.WriteLine("Да");
else Console.WriteLine("Нет");

