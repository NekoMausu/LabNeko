// Напишите программу, которая на вход принимает 
// число в двумерном массиве, и возвращает позицию
// этого элемента или же указание, что такого элемента нет

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

string FindNumArray(int[,] array, int find)
{
    string text;
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == find)
                {
                    text = $"[{i},{j}]";
                    return text;
                }

            }
        }
        return text = "такого числа нет";

    }
}



Console.WriteLine($"Задайте размерность массива ");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"Задайте искомое числое ");
int f = int.Parse(Console.ReadLine());
int[,] array = GetArray(n, m);
ShowArray(array);
Console.WriteLine($"{FindNumArray(array, f)}");