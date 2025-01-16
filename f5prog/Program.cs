int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
void Swap(int a, int b){
    int t = a;
    a = b;
    b = t;
    Console.WriteLine($"a = {a}, b = {b}");
}
Swap(x, y);