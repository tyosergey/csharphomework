/*
40. Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.
*/

bool Triangle(int a, int b, int c)
{
    if (a + b > c & a + c > b & b + c > a) return true;
    return false;
}

System.Console.WriteLine(Triangle(1, 2, 3));
