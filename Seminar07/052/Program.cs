// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце

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


void SumArray(int[,] array)
{
    int divide=array.GetLength(0);
    double result = 0;
    for (int n = 0; n < array.GetLength(1); n++)
    {
        for (int m = 0; m < array.GetLength(0); m++)
        {
            result += array[m, n];
        }
        Console.Write($"{result/divide:f1}, ");
        result = 0;
    }
}



Console.WriteLine($"Задайте размерность массива ");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int[,] array = GetArray(n, m);
ShowArray(array);
SumArray(array);