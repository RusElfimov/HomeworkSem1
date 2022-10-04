// Показать четные числа от 1 до N.
Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
int N1 = 1;


while (N1<=N)
    {
        int x = N1++;
        if (x%2==0)
        Console.WriteLine(x);
    }
     


