// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

int[] ArrMin(int[,] array)
{
    int[] arr = new int[2];
    int min = array[0, 0];
    int lineMin = 0;
    int columnMin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                lineMin = i;
                columnMin = j;
            }
        }
    }
    return new int[] { lineMin, columnMin };
}
int[,] NewMatrix(int[,] arr, int[] array)
{
    int[,] arrayNew = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0)-1; i++)
    {
        if (i != array[0]) ;
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j != array[1]) arrayNew[i, j] = arr[i, j];
            }
        }
    }
    return arrayNew;
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
int[,] arrayResult = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(arrayResult);
Console.WriteLine();
int[] arrMin = ArrMin(arrayResult);
Console.WriteLine($"{arrMin[0]}, {arrMin[1]}");
int[,] arrayNew = NewMatrix(arrayResult, arrMin);
PrintMatrix(arrayNew);


void PrintMatrixNoMin(int[,] matrix, int[] matrixMin)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != matrixMin[0])
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != matrixMin[1])
                {
                    if (j == 0)
                        Console.Write("|");
                    if (j < matrix.GetLength(1) - 1)
                        Console.Write($"{matrix[i, j], 3}| ");
                    else
                        Console.Write($"{matrix[i, j], 3}|");
                }
            }
            Console.WriteLine();
        }
    }
}
