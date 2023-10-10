/*
11. Напишите программу, которая выводит случайное трехзначное число
и удаляет вторую цифру этого числа.
*/

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);

int first = number / 100;
int third = number % 10;

int result = first * 10 + third; 
System.Console.WriteLine(result);