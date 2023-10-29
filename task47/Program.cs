/*
47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

double[,] ArrayRandom(int m, int n)
{
    double[,] array = new double[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11) + new Random().NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(Math.Round(arr[i, j], 2) + "\t");
        }
        System.Console.WriteLine();
    }
}

double[,] array = ArrayRandom(3, 4);
PrintArray(array);