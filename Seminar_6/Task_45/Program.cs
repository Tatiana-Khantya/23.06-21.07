// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]");
    }
}
int[] CopyArray(int[] arr)
{
    int[] arr2 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr2[i] = arr[i];
    }
    return arr2;
}
int[] array1 = CreateArrayRndInt(5, 0, 10);
PrintArray(array1);
Console.WriteLine();
int[] array2 = CopyArray(array1);
PrintArray(array2);