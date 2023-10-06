/*
07. Напишите программу, которая принимает на вход трехзначное число
и на выходе показывает последнюю цифру этого числа.
*/

System.Console.WriteLine("Enter three digits number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number % 10;

System.Console.WriteLine($"{result} - последняя цифра числа {number}");
