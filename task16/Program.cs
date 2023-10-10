/*
16. Напишите программу, которая принимает на вход два числа
и проверяет является ли одно число квадратом другого.
*/

System.Console.WriteLine("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2 || number2 == number1 * number1)
{
    System.Console.WriteLine("Является");
}
else
{
    System.Console.WriteLine("Не является");
}
