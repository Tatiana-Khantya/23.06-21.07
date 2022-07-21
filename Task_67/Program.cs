// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.WriteLine("Задайте число: ");
int num = Convert.ToInt32(Console.ReadLine());

int NaturalNumber(int n)
{
    if (n != 0) return n % 10 + NaturalNumber(n / 10);
    return 0;
}
int number = NaturalNumber(num);
Console.WriteLine(number);
