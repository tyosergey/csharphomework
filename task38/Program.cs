/*
38. Разница между максимальным и минимальным элементами массива.
*/

Console.Clear();

double[] array = { 3.17, 8.94, 2.36, 5.72, 0.85 };

 double FindMax(double[] array)
 {
     double max = array[0];
     for (int i = 0; i < array.Length; i++)
     {
         if (array[i] > max) max = array[i];
     }
     return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    double max = FindMax(array);
    double min = FindMin(array);

    double calc = max - min;
    double result = Math.Round(calc, 2);

    return result;
}

void PrintArray(double[] array)
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

System.Console.WriteLine("Массив: ");
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Разность между максимальным и минимальным элементом = ");
double result = CalcDifferenceBetweenMaxMin(array);
System.Console.Write(result);