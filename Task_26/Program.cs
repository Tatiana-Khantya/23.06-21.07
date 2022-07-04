// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int Quantity(int number)
{
    int i = 0;
    while (number > 0)
    {
        i++;
       number /= 10;
    }
    return i;
}
int result = Quantity(num);
Console.WriteLine($"Количество цифр в числе {num} = {result}");

// Console.WriteLine("");
// int num = Convert.ToInt32(Console.ReadLine());
// 
// int Ber(int number)
// {
   // int i = 0;
   // for ( ; number > 0; i++)
   // {
   //     number = number / 10;
   //     
   // }
   // return i;
// }
// int re = Ber(num);
// Console.WriteLine(re);
