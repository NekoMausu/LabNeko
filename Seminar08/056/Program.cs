// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов


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

int GetMinArray(int[,] array)
{
    int result = 0;
    int min = 0;
    for (int k = 0; k < array.GetLength(1); k++)
    {
        min += array[0, k];
    }
    int row = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];

        }

        if (min > result)
        {
            min = result;
            row = i;
        }
        result = 0;

    }
    return row;
}







Console.WriteLine($"Задайте размерность массива ");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int[,] array = GetArray(n, m);
ShowArray(array);
Console.WriteLine($"минимальная строка {GetMinArray(array)+1}");