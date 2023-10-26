/*
Задача 43: Напишите программу, которая найдёт точку пересечения
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();

double FirstDirect(double x)
{
    System.Console.Write("b1:\t");
    double b1 = int.Parse(Console.ReadLine());
    System.Console.Write("k1:\t");
    double k1 = int.Parse(Console.ReadLine());
    double first = k1 * x + b1;
    return first;
}

double SecondDirect(double x)
{
    System.Console.Write("b2:\t");
    double b2 = int.Parse(Console.ReadLine());
    System.Console.Write("k2:\t");
    double k2 = int.Parse(Console.ReadLine());
    double second = k2 * x + b2;
    return second;
}

double first = FirstDirect(0.5);
double second = SecondDirect(0.5);
System.Console.Write(first + "\t");
System.Console.Write(second);