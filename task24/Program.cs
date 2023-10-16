/*
24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

int Num(int a)
{
    int result = 0;
    for (int i = result; i < a + 1; i++)
    {
        result += i;
    }
    return result;
}

int num = Num(5);
System.Console.WriteLine(num);