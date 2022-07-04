// SЗадача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int[] FillArray (int num)
{
    int [] array = new int[num];
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0,2);
        index++;
    }
    return array;
 }

void PrintArray (int[] col)
{
    Console.Write("[");
    int length = col.Length;
    int i = 0;
    while (i < length)
    {
        Console.Write($"{col[i]}, ");
        i++;
    }
    Console.Write("]");
}

int [] arr = FillArray (num);
PrintArray (arr);