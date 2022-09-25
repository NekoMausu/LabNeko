// функция sqrt

int SQRT(int N)
{
    int start = 1;
    int corentN = N;
    while (start + 1 != N)
    {
        if ((((N + start) / 2) * ((N + start) / 2)) > corentN)
        {
            N = ((N + start) / 2);
        }
        else if ((((N + start) / 2) * ((N + start) / 2)) < corentN)
        {
            start = ((N + start) / 2);
        }
        else return (N+start)/2;

    }
    return start;
}

int a = int.Parse(Console.ReadLine());
int res = SQRT(a);
Console.Write($"результат {res}");