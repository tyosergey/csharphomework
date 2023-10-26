/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();

int[] CreateArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("Введите элемент массива:\t");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;   
}

void CountZeroPlus(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    System.Console.Write($" -> {count}");
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
}

int[] array = CreateArray(5);
PrintArray(array);
CountZeroPlus(array);