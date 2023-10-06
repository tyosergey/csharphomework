/*
02. Внутри класса Answer напишите метод CompareNumbers,
который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
*/

System.Console.WriteLine("Enter first number: ");
int first_number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter second number: ");
int second_number = Convert.ToInt32(Console.ReadLine());

if (first_number > second_number)
{
    System.Console.WriteLine($"{first_number} more than {second_number}");
}
if (first_number < second_number)
{
    System.Console.WriteLine($"{first_number} less than {second_number}");
}
if (first_number == second_number)
{
    System.Console.WriteLine($"{first_number} equals {second_number}");
}
