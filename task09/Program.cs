/*
09. Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.
*/

int number = new Random().Next(10, 100);
System.Console.WriteLine(number);

int first_number = number / 10;
int second_number = number % 10;

if (first_number > second_number) System.Console.WriteLine($"{first_number} больше, чем {second_number}");
if (second_number > first_number) System.Console.WriteLine($"{second_number} больше, чем {first_number}");
if (first_number == second_number) System.Console.WriteLine($"{first_number} равен {second_number}");
