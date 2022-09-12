// Напишите программу, которая задает массив из N элементов,
// заполненных случайными числами из [a,b) и выводит их на экран
void POW(int[] an)
{
    int[] massiv=new int[an[0]];
    for (int i = 0; i < an[0]; i++)
    {
        massiv[i] = new Random().Next(an[1], an[2]);
        Console.Write($"{massiv[i]}, ");
    }
}




Console.WriteLine("Введите длину массива ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите мнимальное число ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число -1 ");
int B = int.Parse(Console.ReadLine());
int[] arrav = new int[3];
arrav[0] = N;
arrav[1] = A;
arrav[2] = B;
POW(arrav);