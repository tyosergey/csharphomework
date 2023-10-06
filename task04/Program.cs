/*
04. Внутри класса Answer напишите метод FindMax,
который принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

System.Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter third number: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}

System.Console.WriteLine($"Max number is {max}");
