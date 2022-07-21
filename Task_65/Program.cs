// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.WriteLine("Задайте два числа: ");
Console.WriteLine("Число M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число N = ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int n, int m)
{
    if (n > m)
    {
        NaturalNumber(n - 1, m);
        Console.Write($"{n} ");
    }
    if (n < m)
    {
        //if (m == n - 1) return;
        NaturalNumber(m - 1, n);
        Console.Write($"{m} ");

    }
    if (n == m) Console.Write($"{m} ");
}
NaturalNumber(n, m);
//else NaturalNumber(m, n);
