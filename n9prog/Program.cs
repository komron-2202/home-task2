int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
void Min(int val1, int val2){
    if(val1 < val2){
        Console.WriteLine(val1);
    }else{
        Console.WriteLine(val2);
    }
}
Min(a, b);