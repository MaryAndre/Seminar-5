// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int RowWithMinsumOfElem(int[,] array)
{
    int minsum = 0;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0)
        {
            minsum = sum;
        }
        else if (sum < minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    return index;
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
int result = RowWithMinsumOfElem(arrayA) + 1;

Console.WriteLine("Массив:");
PrintArray(arrayA);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result} строка ");