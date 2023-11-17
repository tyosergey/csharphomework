/*
65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
*/

Console.Clear();

void RangeOfNaturalNum(int m, int n)
{
    if (m > n) return;
    else
    {
        System.Console.Write(m + " ");
        RangeOfNaturalNum(m + 1, n);
    }
}

RangeOfNaturalNum(1, 10);