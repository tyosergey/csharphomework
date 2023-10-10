/*
13. Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
*/

System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 999)
{
    for (int i = number; i > 100; i = i / 10)
    {
        number = i;
        if (number < 1000)
        {
            int first = number % 100;
            int result = number % 10;
            System.Console.WriteLine(result);
        }
    }
}
else if (number < 1000 && number > 99)
{
    int first = number % 100;
    int result = number % 10;
    System.Console.WriteLine(result);
}
else if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет.");
}