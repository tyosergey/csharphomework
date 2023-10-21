/*
29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] CreateArray(int size, int startValue, int endValue)
{
    int[] array = new int[size];
    var random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startValue, endValue);
    }

    return array;
}

void PrintArray(int[] arr)
{
    foreach (int i in arr)
    {
        System.Console.Write(i + "  ");
    }
}

int[] array = CreateArray(8, -10, 11);
PrintArray(array);
