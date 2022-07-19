// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

//int num = 40;
//
// int d10 = 1
//  int x = 0;
//while ( num != 0)
//{
//  x = x + x / 2* d10;
//num = num/2;
//d10 = d10*10;
// }

// Console.WriteLine("Введите число: ");
//int a = int.Parse(Console.ReadLine());
// int TenToTwo(int n)
// {
//  if (n == 1) return 1;
// if (n == 0) return 0;
// return n % 2 + 10 * TenToTwo(n / 2);
// }
// Console.WriteLine(TenToTwo(a));

int a = 40;
void ToBin(int n)
{
    if (n == 0) return;
    ToBin(n / 2);
    Console.Write(n % 2);
}
ToBin(a);
