/*
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] CreateArray()
{
    int[] array = new int[12];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void SumNumber(int[] arr)
{
    int plus = 0;
    int minus = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) plus += arr[i];
        else minus += arr[i];
    }
    System.Console.Write($"сумма положительных чисел равна {plus}, сумма отрицательных равна {minus}.");
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

System.Console.Write("В массиве ");
PrintArray(CreateArray());
SumNumber(CreateArray());