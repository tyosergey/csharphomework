/* 12. Напишите программу, которая будет принимать на вход два числа
и выводить, является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит остаток от деления.
*/

System.Console.WriteLine("Enter second number: ");
int second = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter first number: ");
int first = Convert.ToInt32(Console.ReadLine());
int result = second % first;

if (second % first == 0)
{
    System.Console.WriteLine($"{second} является кратным числа {first}");
}
else if (second % first == result)
{
    System.Console.WriteLine($"Остаток от деления: {result}");
}
