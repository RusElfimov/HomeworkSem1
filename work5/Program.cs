//Показать числа от -N до N.
int N = Convert.ToInt32(Console.ReadLine());
int startNumber = N;

        while(startNumber >= -N)
    {        
        Console.Write(startNumber + ", ");
        startNumber --;
    }

