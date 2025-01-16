int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
int x = Convert.ToInt32(Console.ReadLine());
void IncrementArrayElements(int n,int x){
    for (int i = 0; i < n; i++)
    {
        a[i] += x;
        Console.WriteLine(a[i]);
    }
}
IncrementArrayElements(n, x);