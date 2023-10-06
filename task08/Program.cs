/*
08. Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number),
а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.
*/

System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int start = 1;

do
{
    System.Console.Write(start);
    start += 1;
    if (start != number + 1)
    {
        System.Console.Write("    ");
    }
}
while (start != number + 1);