/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

int Factorial(int number)
{
    int result = 1;
    for (int i = result; i < number + 1; i++)
    {
        result *= i;
    }
    return result;
}

System.Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

int num = Factorial(a);
System.Console.WriteLine($"Факториал {a} = {num}");