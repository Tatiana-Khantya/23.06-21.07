// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.WriteLine("Задайте два числа: ");
Console.WriteLine("Число A = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число B = ");
int b = Convert.ToInt32(Console.ReadLine());

int SquareNumber(int a, int b)
{
    if (b == 0) return 1;
   return SquareNumber(a, b - 1) * a;
    
}
int number = SquareNumber(a, b);
Console.WriteLine(number);
