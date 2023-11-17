/*
69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/

Console.Clear();

int Pow(int num, int square)
{
    if (square == 1) return num;
    else
    {
        return num * Pow(num, square - 1);
    }
}

int result = Pow(3, 2);
System.Console.WriteLine(result);