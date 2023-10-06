/*
03. Напишите программу, которая будет выдавать названия дня недели по заданному номеру.
*/

System.Console.WriteLine("Enter your number to get name of week: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    System.Console.WriteLine("Monday");
}
if (number == 2)
{
    System.Console.WriteLine("Tuesday");
}
if (number == 3)
{
    System.Console.WriteLine("Wednesday");
}
if (number == 4)
{
    System.Console.WriteLine("Thursday");
}
if (number == 5)
{
    System.Console.WriteLine("Friday");
}
if (number == 6)
{
    System.Console.WriteLine("Saturday");
}
if (number == 7)
{
    System.Console.WriteLine("Sunday");
}
if (number > 7)
{
    System.Console.WriteLine("There are seven days in a week.");
}
