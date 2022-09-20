// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь
int Count(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        count += item > 0 ? 1 : 0;
    }
return count;
}




Console.WriteLine("Введите количество чисел ");
int m = int.Parse(Console.ReadLine());
int[] array = new int[m];
for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Введите {i + 1} число ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"{string.Join(" ", array)}");
Console.WriteLine($"{Count(array)}");