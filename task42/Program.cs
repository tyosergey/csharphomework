/*
42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

void DecToBin(int num)
{
    string result = "";
    int bin = 0;
    for (int i = num; i > 0; i /= 2)
    {
        bin = i % 2;
        result = bin + result;
    }
    System.Console.WriteLine(result);
}

DecToBin(12300);