﻿/*
22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.Clear();

System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i < number + 1; i++)
{
    System.Console.WriteLine($"{i} * {i} = {i*i}");
}