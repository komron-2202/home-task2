int n = Convert.ToInt32(Console.ReadLine());
int EvenCount(int n)
{
    int j = 0;
    while (n > 0)
    {
        int a = n % 10;
        n = n / 10;
        if (a % 2 == 0)
        {
            j++;
        }
    }
    return j;
}
int OddCount(int n)
{
    int t = 0;
    while (n > 0)
    {
        int a = n % 10;
        n = n / 10;
        if (a % 2 != 0)
        {
            t++;
        }
    }
    return t;
}
int DigitCount(int n)
{
    int j = 0;
    while (n > 0)
    {
        int a = n % 10;
        n = n / 10;
        j++;
    }
    return j;
}
int SumDigit(int n)
{
    int s = 0;
    while (n > 0)
    {
        int a = n % 10;
        n = n / 10;
        s += a;
    }
    return s;
}
Console.WriteLine("Even: " + EvenCount(n));
Console.WriteLine("Odd " + OddCount(n));
System.Console.WriteLine("Digit: " + DigitCount(n));
Console.WriteLine("Sum: " +  SumDigit(n));