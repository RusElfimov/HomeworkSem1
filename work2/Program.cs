//По заданному номеру дня недели вывести его название.
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;


if (x==a)
{
    Console.WriteLine("Понедельник");
} 

else if (x==b)
{
    Console.WriteLine("вторник");
} 

else if (x==c)
{
    Console.WriteLine("среда");
} 

else if (x==d)
{
    Console.WriteLine("четверг");
} 

else if (x==e)
{
    Console.WriteLine("пятница");
} 

else if (x==f)
{
    Console.WriteLine("суббота");
} 

else if (x==g)
{
    Console.WriteLine("воскресенье");
} 
else 
{
    Console.WriteLine("Это не день недели");
}


    