/*
0. Напишите программу, которая на вход принимает число и выдаёт его квадрат
(число умноженное на само себя).
*/

System.Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int result = number * number;
Console.WriteLine(result);
