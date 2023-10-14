/*
17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
и выдаёт номер четверти плоскости, в которой находится эта точка.
x=34; y=-30 -> 4 
x=2; y=4-> 1
x=-34; y=-30 -> 3
*/

Console.Clear();

System.Console.Write("Введите координату точки X: ");
int x = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату точки Y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.WriteLine("Точка находится в первой четверти");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Точка находится во второй четверти");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в третьей четверти");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в четвертой четверти");
}
else if (x == 0 || y == 0)
{
    System.Console.WriteLine("Точка находится на оси координат");
}