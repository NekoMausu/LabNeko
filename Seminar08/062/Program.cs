// Заполните спирально массив 4 на 4
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7

int[,] GetArray(int i)
{
    int w = 1;
    int[,] result = new int[i, i];
    for (int count = 0; count < i / 2; count++)
    {
        for (int n = 0 + count; n < i - count; n++)
        {
            result[count, n] = w;
            w++;
        }
        for (int m = 1 + count; m < i - count; m++)
        {
            result[m, i - 1 - count] = w;
            w++;
        }
        for (int n = i - 2 - count; n >= 0 + count; n--)
        {
            result[i - 1 - count, n] = w;
            w++;
        }
        for (int m = i - 2 - count; m > 0 + count; m--)
        {
            result[m, count] = w;
            w++;

        }
    }
    if (i % 2 != 0) result[i / 2, i / 2] = w;
    return result;
}

void ShowArray(int[,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            Console.Write($"{array[n, m]}\t");
        }
        Console.WriteLine();
    }
}



Console.WriteLine($"Задайте размерность массива ");
int n = int.Parse(Console.ReadLine());
int[,] array = GetArray(n);
ShowArray(array);
