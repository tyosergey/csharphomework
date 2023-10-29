/*
52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void Mean(int[,] arr)
{
    double mean = 0;
    double result = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            mean += arr[i, j];
        }
        result = mean / arr.GetLength(0);
        System.Console.Write(Math.Round(result, 2) + "\t");
        result = 0;
        mean = 0;
    }
}

int[,] array = CreateArray(3, 4);
PrintArray(array);
System.Console.WriteLine();
Mean(array);
