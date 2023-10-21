/*
27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();

int SumNumber(int number)
{
    number = Math.Abs(number);
    int result = 0;

    for (int i = number; i > 0; i /= 10)
    {
        result += i % 10;
    }

    return result;
}

int userResult = SumNumber(-1234);
System.Console.WriteLine(userResult);