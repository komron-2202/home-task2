int n = Convert.ToInt32(Console.ReadLine());
int MinDigit (int n){
    int min = 9;
    while (n > 0){
        int d = n % 10;
        if (d < min){
            min = d;
        }
        n /= 10;
    }
    return min;
}
int MaxDigit (int n){
    int max = 0;
    while (n > 0){
        int d = n % 10;
        if (d > max){
            max = d;
        }
        n /= 10;
    }
    return max;
}
Console.WriteLine(MinDigit(n) + MaxDigit(n));