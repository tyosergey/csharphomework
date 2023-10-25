/*
44. Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
*/

Console.Clear();

void Fibonacci(int num)
{
    int[] array = new int[num + 1];
    if (num == 0) System.Console.WriteLine("1");
    else
    {
        for (int i = 0; i < 2; i++)
        {
            array[i] = i;
            System.Console.Write(array[i] + " ");
        }
    
        for (int i = 2; i < num; i++)
        {
        array[i] = array[i - 2] + array[i - 1];
        System.Console.Write(array[i] + " ");
        }
    }
}

Fibonacci(15);