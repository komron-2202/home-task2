int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int Pow(int x, int y)
{
    int p = 1;
    for (int i = 0; i < y; i++)
    {
        p = p * x;
    }
    return p;
}
Console.WriteLine(Pow(x, y));