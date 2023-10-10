System.Console.WriteLine("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 8)
{
    if (number == 6 || number == 7)
{
    System.Console.WriteLine("Выходной день.");
}
else
{
    System.Console.WriteLine("Будний день.");
}
}