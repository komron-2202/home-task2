int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int Max(int val1, int val2){
    if(val1 < val2){
        return val2;
    }else{
        return val1;
    }
}
Console.WriteLine(Max(a, b));