﻿/*
23. Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N)
и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
*/
Console.Clear();
System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i < number + 1; i++)
{
    System.Console.WriteLine($"{i} * {i} * {i} = {i * i * i}");
}