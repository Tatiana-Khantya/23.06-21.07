Console.WriteLine("ВВедите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b*b || b == a*a) 
    {Console.WriteLine("Одно из чисел является квадратом другого");
    }
else 
{
Console.WriteLine("Ни одно из чисел не является квадратом другого");
};
