/*
63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/

Console.Clear();

void RangeOfNaturalNum(int start = 1, int end)
{
    if (start > end) return;
    else
    {
        System.Console.Write(start + " ");
        RangeOfNaturalNum(start + 1, end);
    }
}

RangeOfNaturalNum(10);