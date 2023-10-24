/*
37. Напишите программу, которая находит сумму элементов с нечетными индексами
в одномерном массиве целых чисел и выводит результат на экран.
*/

Console.Clear();

int[] array = new int[] { 18, 76, 11 };

void SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }    
    }
    System.Console.WriteLine(sum);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        
        if (i < array.Length - 1)
        {
            System.Console.Write("\t");
        }
    }
}

PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Сумма нечётных элементов: ");
SumOddElements(array);