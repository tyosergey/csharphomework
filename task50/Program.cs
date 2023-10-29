/*
50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 и 2 -> 2
1 и 7 -> такого числа в массиве нет
*/
Console.Clear();

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

void FindElement(int[,] arr, int row, int column)
{
    int result;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (row > arr.GetLength(0) || column > arr.GetLength(1))
            {
                System.Console.WriteLine("Такого числа в массиве нет, адрес неверный!");
                break;
            }
            else if (arr[i, j] == arr[row, column])
            {
                result = arr[i, j];
                System.Console.WriteLine(result);
                break;
            }
        }
    }
}

int[,] array = CreateArray(4, 4);
PrintArray(array);
System.Console.WriteLine();
FindElement(array, 2, 2);