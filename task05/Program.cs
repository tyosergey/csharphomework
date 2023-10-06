/*
05. Напишите программу, которая на вход принимает одно число N,
а на выходе показывает все целые числа в промежутке от -N до N.
*/

System.Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
// int negative_number = -1 * number; // Сделайте комментарием на случай, если используется цикл for.

/*
do
{
    System.Console.WriteLine(negative_number);
    negative_number += 1;
}
while (negative_number != number + 1);
*/

// Способ решения с помощью цикла for.


for (int i = -number; i < number + 1; i++)
{
    Console.Write(i);
    if (i < number) System.Console.Write(", ");
}