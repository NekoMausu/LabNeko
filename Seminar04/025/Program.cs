// Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В
void POW(int[] an)
{
    int num = an[0];
    for (int i = 1; i < an[1]; i++)
    {
        an[0] = num * an[0];
    }
    Console.WriteLine(an[0]);

}



Console.WriteLine("Введите число А ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B ");
int B = int.Parse(Console.ReadLine());
if (B < 0) B=-B;
int[] arrav = new int[2];
arrav[0] = A;
arrav[1] = B;
POW(arrav);

