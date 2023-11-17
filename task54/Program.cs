/*
54. Сортировка строк матрицы по убыванию.
Исходная матрица:
9   1   7   
1   2   3   
4   5   6   

Матрица с упорядоченными по убыванию строками:
9   7   1   
3   2   1   
6   5   4
*/

/*
1. Создать массив
2. Заполнить массив
3. Создать метод, который сортирует массив
4. Создать метод, который печатает массив
*/

int[,] CreateArray()
{
    int[,] array = new int[3, 3];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int[,] SortArray(int[,] arr)
{
    int[,] sorted = new int[3, 3];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > arr[i, j + 1]) sorted[i, j] = arr[i, j];
        }
    }
    return sorted;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.WriteLine(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] creating = CreateArray();
int[,] sorting = SortArray(creating);
PrintArray(sorting);
