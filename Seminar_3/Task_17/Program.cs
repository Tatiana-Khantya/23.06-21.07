// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.


Console.Clear();
Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Первая четверь");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверь");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверь");
// else if (x > 0 && y < 0) Console.WriteLine("Четвёртая четверь");
// else Console.WriteLine("Введены некорректные координаты");

string Quarter(int x, int y)
{
    if (x > 0 && y > 0) return "Первая четверь";
    if (x < 0 && y > 0) return "Вторая четверь";
    if (x < 0 && y < 0) return "Третья четверь";
    if (x > 0 && y < 0) return "Четвёртая четверь";
    return"Введены некорректные координаты";
}
string Quarter(int x, int y)
{
    switch ((x, y))
    {
        case ( > 0, > 0):
            return "Первая четверь";
        case ( < 0, > 0):
            return "Вторая четверь";
        case ( < 0, < 0):
            return "Третья четверь";
        case ( > 0, < 0):
            return "Четвёртая четверь";
        default:
            return "Введены некорректные координаты";
    }
}



string result = Quarter(x, y);

Console.WriteLine(result);

