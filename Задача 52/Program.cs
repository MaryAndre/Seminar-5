// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

void ArithmeticMean(int[,] arr)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        sum /= arr.GetLength(0);
        Console.Write($"{sum:f1}; \t");
    }

}


Console.Clear();
Console.Write("Введите кол-во строк, столбцов в создаваемом массиве через пробел: ");
string[] sign = Console.ReadLine()!.Split(" ");
int row = int.Parse(sign[0]);
int colums = int.Parse(sign[1]);

int[,] array = NewArray(row, colums);
PrintArray(array);
Console.WriteLine("Cреднее арифметическое каждого столбца: ");
ArithmeticMean(array);