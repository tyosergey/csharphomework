/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
using System;
Console.Clear();

System.Console.Write("Введите первую координату первой точки: ");
double x1 = double.Parse(Console.ReadLine());
System.Console.Write("Введите вторую координату первой точки: ");
double y1 = double.Parse(Console.ReadLine());
System.Console.Write("Введите первую координату второй точки: ");
double x2 = double.Parse(Console.ReadLine());
System.Console.Write("Введите вторую координату второй точки: ");
double y2 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
System.Console.WriteLine(Math.Round(result, 2));