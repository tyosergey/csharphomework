/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int RangeNumToLow(int num)
{
    if (num == 1) return 1;
    else
    {
        System.Console.WriteLine(num);
        return RangeNumToLow(num - 1);
    }
}

int result = RangeNumToLow(5);
System.Console.WriteLine(result);