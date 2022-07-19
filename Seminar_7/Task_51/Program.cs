// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

Console.Clear();
int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

int SumElem(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            { sum = sum + arr[i, j]; }
        }
    }
    return sum;
}
// int FillMatrix(int[,] arr)
//{
  //  int sum = 0;
   // int index = 0;
   // if(arr.GetLength(0) > arr.GetLength(1)) index = 1;
   // for (int i = 0; i < arr.GetLength(index); i++)
    // {
    //    sum += arr[i, i];
    //}
    //return sum;
//}


void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],2} | ");
            else Console.Write($"{arr[i, j],2} ]");
        }
        Console.WriteLine();
    }
}
int[,] arrayResult = CreateMatrixRndInt(5, 3, 1, 10);
PrintMatrix(arrayResult);
Console.WriteLine();
int result = SumElem(arrayResult);
Console.WriteLine(result);