int x = Convert.ToInt32(Console.ReadLine());
void Divisors(int x){
    for(int i = 1; i <= x; i++){
        if(x % i == 0){
            Console.WriteLine(i);
        }
    }
}
Divisors(x);