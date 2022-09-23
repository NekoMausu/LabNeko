// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убываю элементы каждой стороки двумерн. массива

int[,] GetArray(int i, int j)
{
    int[,] result = new int[i, j];
    for (int n = 0; n < i; n++)
        for (int m = 0; m < j; m++)
            result[n, m] = new Random().Next(0, 10);
    return result;
}

void ShowArray(int[,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            Console.Write($"{array[n, m]} ");
        }
        Console.WriteLine();
    }
}

int[,] Sort(int[,] massiv)
{
    int min;
    for (int l = 0; l < massiv.GetLength(0); l++)
    {
        min = massiv[l, 0];
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int i = 1; i < massiv.GetLength(1); i++)
            {
                if (min < massiv[l, i])
                {
                    massiv[l, i - 1] = massiv[l, i];
                    massiv[l, i] = min;

                }
                else
                {
                    min = massiv[l, i];
                }
            }
            min = massiv[l, 0];
        }
    }
    return massiv;
}








Console.WriteLine($"Задайте размерность массива ");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int[,] array = GetArray(n, m);
ShowArray(array);
Console.WriteLine();
array = Sort(array);
ShowArray(array);
