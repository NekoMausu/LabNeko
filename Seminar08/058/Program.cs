// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц

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

int[,] Power(int[,] arr, int[,] arr2)
{
    int sum = 0;
    int[,] result = new int[arr.GetLength(0) < arr2.GetLength(0) ? arr.GetLength(0) : arr2.GetLength(0), arr.GetLength(1) < arr2.GetLength(1) ? arr.GetLength(1) : arr2.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int k = 0; k < arr.GetLength(0); k++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[k, j] * arr2[j, i];
            }
            result[k, i] = sum;
            sum = 0;
        }
    }
    return result;
}



Console.WriteLine($"Задайте размерность массива ");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int[,] array = GetArray(n, m);
ShowArray(array);

Console.WriteLine($"Задайте размерность массива ");
n = int.Parse(Console.ReadLine());
m = int.Parse(Console.ReadLine());
int[,] array2 = GetArray(n, m);
ShowArray(array2);
Console.WriteLine();
ShowArray(Power(array, array2));