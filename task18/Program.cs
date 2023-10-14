/*
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/

Console.Clear();

System.Console.WriteLine("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());

if (number == 1) System.Console.WriteLine("X и Y больше нуля.");
if (number == 2) System.Console.WriteLine("X меньше нуля, Y больше нуля.");
if (number == 3) System.Console.WriteLine("X и Y меньше нуля.");
if (number == 4) System.Console.WriteLine("X больше нуля, Y меньше нуля.");
if (number < 1 || number > 4) System.Console.WriteLine("Такой четверти нет.");
