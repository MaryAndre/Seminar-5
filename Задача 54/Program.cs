// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] NewArray(int row, int col, int minValue, int maxValue)
{
    int[,] arraynew = new int[row, col];
    for (int i = 0; i < arraynew.GetLength(0); i++)
    {
        for (int j = 0; j < arraynew.GetLength(1); j++)
        {
            arraynew[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return arraynew;
}

void PrintArray(int[,] arrprint)
{
    for (int i = 0; i < arrprint.GetLength(0); i++)
    {
        for (int j = 0; j < arrprint.GetLength(1); j++)
        {
            Console.Write($"{arrprint[i, j]}\t ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortArray(int[,] arrsort)
{
    int temp = 0;
    for (int i = 0; i < arrsort.GetLength(0); i++)
    {
        for (int j = 0; j < arrsort.GetLength(1); j++)
        {
            for (int k = 0; k < arrsort.GetLength(1) - 1; k++)
            {
                if (arrsort[i, k] < arrsort[i, k + 1])
                {
                    temp = arrsort[i, k];
                    arrsort[i, k] = arrsort[i, k + 1];
                    arrsort[i, k + 1] = temp;
                }
            }
        }
    }
    return arrsort;
}

Console.Clear();
Console.Write("Введите строки, столбцы массива через пробел: ");
string[] sign = Console.ReadLine()!.Split(" ");
int rows = int.Parse(sign[0]);
int colums = int.Parse(sign[1]);

Console.Write("Введите начальное и конечное число случайной регенерации чисел через пробел: ");
string[] sign1 = Console.ReadLine()!.Split(" ");
int minvalue = int.Parse(sign1[0]);
int maxvalue = int.Parse(sign1[1]);

int[,] arrayA = NewArray(rows, colums, minvalue, maxvalue);

Console.WriteLine("Начальный массив:");
PrintArray(arrayA);
Console.WriteLine("Отсортированный массив:");
PrintArray(SortArray(arrayA));