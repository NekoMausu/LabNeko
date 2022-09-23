// Сформируйте трехмерный массив из неповторяющихся двухзначных чисел
// Напишите программу, которая будет выводить массив,
// добовляя индексы каждого элемента

int[,,] GetArray(int i, int j, int k)
{
    int random = 10;
    int[,,] result = new int[i, j, k];
    for (int n = 0; n < i; n++)
        for (int m = 0; m < j; m++)
            for (int l = 0; l < k; l++)
            {
                result[n, m, l] = random;
                random++;
            }
    return result;
}

void ShowArray(int[,,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.Write($"{array[n, m, l]} [{n},{m},{l}] ");
            }
        Console.WriteLine();
    }
}

Console.WriteLine($"Задайте размерность массива ");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int l = int.Parse(Console.ReadLine());
if (n * m * l <= 90)
{
    int[,,] array = GetArray(n, m, l);
    ShowArray(array);
}
else Console.WriteLine($"Ошибка");