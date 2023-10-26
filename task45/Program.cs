/*
45. Напишите программу, которая будет создавать копию заданного
одномерного массива с помощью поэлементного копирования.
*/

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10);
    }
    return array;
}

int[] CopyArray(int[] arr)
{
    int[] array = new int[arr.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = arr[i]; 
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

void PrintCopy(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

int[] array = CreateArray(5);
int[] copy = CopyArray(array);
PrintArray(array);
System.Console.WriteLine();
PrintArray(copy);
