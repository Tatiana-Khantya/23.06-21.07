// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] ReplaceMatrix(int[,] array)
{
    int[,] arr = new int[array.GetLength(1), array.GetLength(0)];
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                arr[j, i] = array[i, j];
            }
        }
    }
    return arr;
}

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
int[,] arrayResult = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(arrayResult);
Console.WriteLine();
if (arrayResult.GetLength(0) != arrayResult.GetLength(1)) Console.WriteLine("Невозможно заменить строки на столбцы");
else
{
    int[,] resultMatrix = ReplaceMatrix(arrayResult);
    PrintMatrix(resultMatrix);
}

