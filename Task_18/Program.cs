//Задача 18: Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.WriteLine("Введите номер четверти на плоскости");

int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1: Console.WriteLine("x > 0 && y > 0");break;
    case 2: Console.WriteLine("x < 0 && y > 0");break;
    case 3: Console.WriteLine("x < 0 && y < 0");break;
    case 4: Console.WriteLine("x > 0 && y < 0");break;
    default: Console.WriteLine("Неверный номер четверти");break;
}
string Quarter(NumQ)
{
switch (num)
{
    case 1: return "x > 0 && y > 0";break;
    case 2: return "x < 0 && y > 0";break;
    case 3: return "x < 0 && y < 0";break;
    case 4: return "x > 0 && y < 0";break;
    default: return "Неверный номер четверти";break;
}
}
string result = Quarter(num);