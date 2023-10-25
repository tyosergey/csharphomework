/*
34. Напишите программу, которая подсчитывает количество четных элементов
в массиве целых положительных трехзначных чисел и выводит результат на экран.
*/

Console.Clear();

int[] CreateArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 501);
    }
    return array;
}

void CountEvenElements(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }

    System.Console.WriteLine(count);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);

        if (i < arr.Length - 1)
        {
            System.Console.Write("\t");
        }
    }
}

System.Console.WriteLine("Массив:");
int[] create = CreateArray();
PrintArray(create);
System.Console.WriteLine();
System.Console.Write("Количество чётных элементов: ");
CountEvenElements(create);