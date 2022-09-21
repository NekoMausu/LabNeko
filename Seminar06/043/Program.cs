// Напишите программу, которая найдет точку пересечения
// двух прямых, заданных уравнениями 
// y=k1*x+b1, y=k2*x+b2;
// значения b1,k1,b2,k2 задаются пользователем

void CrossPoint(double [,] arr)
{
    double x;
    double y;
    x=-(arr[0,1]-arr[1,1])/(arr[0,0]-arr[1,0]);
    y=(arr[1,0]*x)+arr[1,1];
    Console.WriteLine($"{x} {y}");
}




double [,] array = new double [2,2];
for (int i=0;i<2;i++)
{
    for (int j=0;j<2;j++)
    {
        array[i,j]=int.Parse(Console.ReadLine());
    }
}

for (int i=0;i<2;i++)
{
    for (int j=0;j<2;j++)
    {
        Console.Write($"{array[i,j]} ");
    }
Console.WriteLine();
}

CrossPoint(array);

