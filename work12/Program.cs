﻿//Найти третью цифру числа или сообщить ,что ее нет.
string a = Console.ReadLine();
int b = a.Length;
if (b < 3 )
{
     Console.WriteLine("третьей цифры числа нет");
    
}
else 
{
    Console.WriteLine(a[2]);
}

