// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели (от 1 до 7) ");
int day = int.Parse(Console.ReadLine());
if (0<day&&day<6) Console.WriteLine("Рабочий день");
else if (day==6||day==7) Console.WriteLine("Выходной");
else Console.WriteLine("Такого дня недели нет");
