// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Создание массива.
int[,] NewArray(int str, int col)
{
    int[,] arr = new int[str, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

// Печать массива в консоль.
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

// Индекс i искомого числа.
int IndexOfI(int[,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == value)
                return i;
        }
    }
    return -1;
}

// Индекс j искомого числа.
int IndexOfJ(int[,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == value)
                return j;
        }
    }
    return -1;
}

Console.Clear();
Console.Write("Введите кол-во строк, столбцов в создаваемом массиве c пробелом: ");
string[] sign = Console.ReadLine()!.Split(" ");
int row = int.Parse(sign[0]);
int colums = int.Parse(sign[1]);

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int[,] array = NewArray(row, colums);
PrintArray(array);
Console.WriteLine();

if (IndexOfI(array, num) < 0 || IndexOfJ(array, num) < 0)
{
    Console.WriteLine($"Числа {num} нет в массиве");
}
else
{
    Console.WriteLine($"Число {num} находится на позиции [{IndexOfI(array, num)}, {IndexOfJ(array, num)}]");
}