/*
26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
int userNum = int.Parse(Console.ReadLine());

int AmountOfDigits(int userNum)
{
    int count = 0;
    for (int i = userNum; i > 0; i /= 10)
    {
        count += 1;
    }
    return count;
}

int result = AmountOfDigits(userNum);
System.Console.WriteLine(result);
