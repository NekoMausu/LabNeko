// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива
double Diffmin(double[] massiv)
{
    double min = massiv[0];
    foreach (double b in massiv)
    {
        min = min > b ? b : min;
    }
Console.WriteLine($"минимальное число {min:f2}");
return min;
}

double Diffmax(double[] massiv)
{
    double max = massiv[0];
    foreach (double b in massiv)
    {
        max = max < b ? b : max;
    }
Console.WriteLine($"максимально число {max:f2}");
return max;
}


double[] array = new double[20];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 100) + new Random().NextDouble();
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]:f2}   ");
Console.WriteLine();
Console.WriteLine($"разница между максимальным и минимальным {Diffmax(array)-Diffmin(array):f2}");