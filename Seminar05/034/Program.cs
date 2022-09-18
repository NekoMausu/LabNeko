// Задайте массив заполненый случайными положительными
// трехзначными числами. Напишите программу, которая покажет
// количество четных чисел в массиве.
void SAP(int[] massiv)
{
    int sum = 0;
    foreach (int b in massiv)
    {
        sum += b % 2 == 0 ? 1 : 0;
    }
    Console.WriteLine($"{sum}");
}



int[] array = new int[20];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);

Console.WriteLine($"{string.Join(" " ,array)}");
SAP(array);