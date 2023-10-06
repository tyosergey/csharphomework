/*
01. Напишите программу, которая на вход принимает два числа
и проверяет является ли первое число квадратом второго.
*/

System.Console.WriteLine("Enter first number: ");
int first_number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter second number: ");
int second_number = Convert.ToInt32(Console.ReadLine());

int pow = first_number * first_number;

if(pow == second_number)
{
    Console.WriteLine($"Number {first_number} is a power of {second_number}");
}
else
{
    Console.WriteLine($"Number {first_number} is not a power of {second_number}");
}
