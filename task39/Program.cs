/*
39. Напишите программу, которая перевернет одномерный массив.
Последний будет на первом месте, а первый на последнем.
*/

Console.Clear();

int[] CreateArray()
{
    int[] array = new int[10];
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 6);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
        {
            System.Console.Write(",\t");
        }
    }
    System.Console.Write("]");
}

void Reverse(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] current = CreateArray();
PrintArray(current);
System.Console.WriteLine();
Reverse(current);
PrintArray(current);