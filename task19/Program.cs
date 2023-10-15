/*
19. Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number
и проверяет, является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное
и False в следующей строке.

Для остальных чисел вернуть True или False.


14212 -> False
12821 -> True
234322 -> Число не пятизначное
False
*/

Console.Clear();

System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

// rev - reverse, s - string, array - list, s - new string from array list, rev - convert to int
int rev = number;
string s = rev.ToString();
char[] array = s.ToCharArray();
Array.Reverse(array);
s = new String(array);
rev = Convert.ToInt32(s);

if (number < 10000 || number > 99999)
{
    System.Console.WriteLine("Число не пятизначное.");
}
else if (number == rev)
{
    System.Console.WriteLine("True");
}
else if (number != rev)
{
    System.Console.WriteLine("False");
}