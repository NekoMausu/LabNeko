// Напишите программу, которая задает массив из N элементов,
// заполненных случайными числами из [a,b) и выводит их на экран
int[] FillArray(int numA, int numB, int numN)
{
    int[] massiv = new int[numN];
    for (int i = 0; i < numN; i++)
    {
        massiv[i] = new Random().Next(numA, numB);
    }
    return massiv;
}


void WriteArray(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]}, ");
    }
}



Console.WriteLine("Введите длину массива ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите мнимальное число ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число -1 ");
int B = int.Parse(Console.ReadLine());
WriteArray(FillArray(A,B,N));