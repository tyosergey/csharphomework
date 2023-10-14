System.Console.WriteLine("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    System.Console.WriteLine("Выходной день.");
}
else if (number > 7 || number < 1)
{
    System.Console.WriteLine("Ошибка!");
}
else
{
    System.Console.WriteLine("Будний день.");
}
