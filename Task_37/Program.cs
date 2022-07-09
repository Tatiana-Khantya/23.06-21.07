// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
int[] NewArray(int[] arr)
{
    int size = 0;
    if (arr.Length % 2 == 0) size = arr.Length / 2;
    else size = arr.Length / 2 + 1;
    int[] multArr = new int[size];
    //int j = 0;
    // if (size % 2 > 0) multArr[size - 1] = arr(arr.Length / 2);
    for (int i = 0; i < arr.Length / 2; i++)
    {
        multArr[i] = arr[i] * arr[arr.Length - 1 - i];
       // j++;
    }
        return multArr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i] + "]\n");
    }
}
int[] array = CreateArrayRndInt(7, 0, 10);
PrintArray(array);
int[] newArr = NewArray(array);
PrintArray(newArr);
