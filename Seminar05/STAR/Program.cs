// Разобраться с алгоритмом сортировки методом пузырька.
// Реализовать невозрастающую сортировку.
void Sort(int[] massiv)
{
    int min = massiv[0];
    for (int j = 0; j < massiv.Length; j++)
    {
        for (int i = 1; i < massiv.Length; i++)
        {
            if (min < massiv[i])
            {
                massiv[i - 1] = massiv[i];
                massiv[i] = min;

            }
            else
            {
                min = massiv[i];
            }
        }
        min=massiv[0];
    }

    Console.WriteLine($"{string.Join(" ", massiv)}");
}



int[] array = new int[20];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 10);
Console.WriteLine($"{string.Join(" ", array)}");
Sort(array);