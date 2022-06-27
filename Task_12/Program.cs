

Console.WriteLine("ВВедите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВедите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a%b==0) Console.WriteLine($"Число {a} кратно {b}");

else 
{int num = a % b;
Console.WriteLine($"Число {a} не кратно {b}, остаток {num}");
};



