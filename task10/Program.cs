/*
10. Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
*/

int number = new Random().Next(99, 1000);
System.Console.WriteLine(number);

int first = number % 100;
int middle = first / 10;

System.Console.WriteLine(middle);