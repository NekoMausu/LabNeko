// Задайте двумерный массив размером m n, заполненый случайными
// вещественными числами

double[,] GetArray(int i, int j)
{
    double[,] result = new double[i, j];
    for (int n = 0; n < i; n++)
        for (int m = 0; m < j; m++)
            result[n, m] = new Random().Next(0, 10) + new Random().NextDouble();
    return result;
}

void ShowArray(double[,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            Console.Write($"{array[n, m]:f1} ");
        }
        Console.WriteLine();
    }
}


int n=int.Parse(Console.ReadLine());
int m=int.Parse(Console.ReadLine());

double [,] massiv =GetArray(n,m);
ShowArray(massiv);