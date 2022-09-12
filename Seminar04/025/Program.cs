// Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В
int POW(int numberA, int numberB)
{
    int result = numberA;
    for (int i = 1; i < numberB; i++)
    {
        result*=numberA;
    }
    return result;
}

Console.WriteLine("Введите число А ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B ");
int B = int.Parse(Console.ReadLine());
if (B < 0) B = -B;
Console.WriteLine(POW(A,B));