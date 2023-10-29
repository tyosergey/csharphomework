/*
51. Задайте двумерный массив. Найдите сумму элементов, находящихся
на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

int[,] CreateArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Matrix(int[,] arr)
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

int SumDiagonal(int[,] arr)
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        result += arr[i, i];
    }
    return result;
}

int[,] array = CreateArray(4, 4);
Matrix(array);
System.Console.WriteLine();
int sum = SumDiagonal(array);
System.Console.WriteLine(sum);
