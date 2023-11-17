/*
67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/

Console.Clear();

int SumOfRangeNumber(int number)
{
    if (number == 0) return 0;
    else
    {
        return number % 10 + SumOfRangeNumber(number / 10);
    }
}

int result = SumOfRangeNumber(123);
System.Console.WriteLine(result);