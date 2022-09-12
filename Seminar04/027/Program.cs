// Напишите функцию и запустите ее, которая принимает на вход число
// и выдает сумму цифр в числе
int SUM(int B)
{
    int res = 0;
    while (B != 0)
    {
        res = B % 10 + res;
        B = B / 10;
    }
    return res;
}




Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine($"{SUM(A)}");
