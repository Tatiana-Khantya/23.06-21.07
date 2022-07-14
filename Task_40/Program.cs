﻿// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
//такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника
//меньше суммы двух других сторон

Console.Clear();
int a = 6;
int b = 4;
int c = 3;

if (a < (b + c) && b < (a + c) && c < (a+b)) Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");
else Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует");