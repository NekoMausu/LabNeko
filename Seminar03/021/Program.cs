// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве
Console.WriteLine("Введите x1 первой точки ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1 первой точки ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z1 первой точки ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2 первой точки ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2 первой точки ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z2 первой точки ");
int z2 = int.Parse(Console.ReadLine());
int result = ((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.WriteLine($"{Math.Sqrt(result):f2}");