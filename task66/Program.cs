/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumOfRangeElements(int m, int n)
{
    if (m == n) return m;
    else
    {
        return m + SumOfRangeElements(m + 1, 8);
    }
}

int result = SumOfRangeElements(4, 8);
System.Console.WriteLine(result);