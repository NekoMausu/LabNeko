// Напишите функцию, которая принимает одно число - высоту елочки
// и рисует ее в консоли звездочками.
void tree(int Depth)
{
    int d = 1;
    int v = 1;
    int z=Depth;
    for (int i = 1; i <= Depth; i++)
    {
        d = v;
        while (d != 0)
        {
            while (z>1)
            {
                z--;
                Console.Write(" ");
            }
            Console.Write("*");
            d--;
        }
        v += 2;
        Console.WriteLine(" ");
        z=Depth-i;
    }
}
Console.WriteLine("Введите высоту елочки ");
int H = int.Parse(Console.ReadLine());
tree(H);