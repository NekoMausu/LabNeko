// Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
if ((num%1000-num%100)/100==0) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine((num/100)%10);
