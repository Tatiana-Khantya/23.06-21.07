﻿// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int Pro(int number)
{
    int pro = 1;
    for (int i = 1; i <= number; i++)
    {
        pro = pro * i;
    }
    return pro;
}
int result = Pro(num);
Console.WriteLine($"Произведение чисел от 1 до {num} = {result}");