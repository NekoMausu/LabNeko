// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.

void Sum(int[] massiv)
{
    int sum = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        sum += i % 2 == 0 ? 0 : massiv[i];
    }
    Console.WriteLine($"{sum}");
}


int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 100);

Console.WriteLine($"{string.Join(" ", array)}");
Sum(array);