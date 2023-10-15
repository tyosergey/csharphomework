/*
21. Внутри класса Answer напишите метод DistanceBetweenPoints,который принимает на вход
координаты двух точек pointA и pointB в виде массива целых чисел,
и возвращает расстояние между ними в 3D пространстве.


A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

using System;
Console.Clear();

System.Console.Write("Введите первую координату первой точки: ");
double pointA1 = double.Parse(Console.ReadLine());
System.Console.Write("Введите вторую координату первой точки: ");
double pointA2 = double.Parse(Console.ReadLine());
System.Console.Write("Введите третью координату первой точки: ");
double pointA3 = double.Parse(Console.ReadLine());

System.Console.Write("Введите первую координату второй точки: ");
double pointB1 = double.Parse(Console.ReadLine());
System.Console.Write("Введите вторую координату второй точки: ");
double pointB2 = double.Parse(Console.ReadLine());
System.Console.Write("Введите третью координату второй точки: ");
double pointB3 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(pointA1 - pointB1, 2) + Math.Pow(pointA2 - pointB2, 2) + Math.Pow(pointA3 - pointB3, 2));
System.Console.WriteLine(Math.Round(result, 2));