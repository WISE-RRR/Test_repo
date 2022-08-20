//Pervaya zadacha (1)

/*int a, b;

    Console.WriteLine("Введите два числа : ");
 
    a = Convert.ToInt32(Console.ReadLine());
 
    b = Convert.ToInt32(Console.ReadLine());
 
    if (a > b)
    {
        Console.WriteLine("Наибольшее число: " + a);
    }
    else
    {
        Console.WriteLine("Наибольшее число: " + b);
    }*/


//Vtoraya zadacha (2)

/*int a, b, c;

    Console.WriteLine("Введите три числа : ");

    a = Convert.ToInt32(Console.ReadLine());

    b = Convert.ToInt32(Console.ReadLine());

    c = Convert.ToInt32(Console.ReadLine());

    if(a > b && a > c)
    {
        Console.WriteLine("Наибольшее число: " + a);
    }
    if(b > c)
    {
        Console.WriteLine("Наибольшее число: " + b);
    }
    else
    {
        Console.WriteLine("Наибольшее число: " + c);
    }*/


//Tretya zadacha (3)

/*int a;

    Console.WriteLine("Введите число : ");

    a = Convert.ToInt32(Console.ReadLine());

        if ((a % 2) == 0)
        {
            Console.WriteLine("Чётное");
        }
        else
        {
            Console.WriteLine("Нечётное");
        }*/


//Chetvertaya zadacha (4)

int n;
int res = 1;

    Console.WriteLine("Введите число: ");

    n = Convert.ToInt32(Console.ReadLine());

    while(res <= n)
    {
        if((res % 2) == 0)
        {
            Console.Write(res + " ");
        }
        res++;
    }

