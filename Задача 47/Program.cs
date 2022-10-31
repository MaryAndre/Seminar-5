// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] NewArray(int m, int n)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble() * (10 + 10) - 10;
        }
    }
    return arr;
}

void PrintArray(double[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write($"{arr1[i, j]:f1}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();       
Console.Write("Введите кол-во строк, столбцов через пробел: ");
string[] sign = Console.ReadLine()!.Split(" ");
int row = int.Parse(sign[0]);
int colums = int.Parse(sign[1]);

double[,] array = NewArray(row, colums);
PrintArray(array);