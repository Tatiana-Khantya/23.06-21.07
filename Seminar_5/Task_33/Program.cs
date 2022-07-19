// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
string YesNo(int[] arr, int num)
{
    string result = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) { result = "Да"; break; }
        else result = "Нет";
    }
    return result;
}
// void numArray (int[] arr, int num)
// {
//    for (int i = 0; i < arr.Length; i++)
  //  {
    //    if (num == arr[i])
       // {
         //   Console.WriteLine("yes");
           // return;
        //}
    //}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}
int[] array = CreateArrayRndInt(8, 0, 10);
PrintArray(array);
Console.WriteLine();
string integerInArr = YesNo(array, 5);
Console.WriteLine(integerInArr);
