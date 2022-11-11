// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Компоненты матрицы С вычисляются следующим образом:
// C1,1 = A1,1 · B1,1 + A1,2 · B2,1 =
// = 2 · 3 + 4 · 3 = 6 + 12 = 18

// C1,2 = A1,1 · B1,2 + A1,2 · B2,2 =
// = 2 · 4 + 4 · 3 = 8 + 12 = 20

// C2,1 = A2,1 · B1,1 + A2,2 · B2,1 =
// = 3 · 3 + 2 · 3 = 9 + 6 = 15

// C2,2 = A2,1 · B1,2 + A2,2 · B2,2 =
// = 3 · 4 + 2 · 3 = 12 + 6 = 18

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

int[,] MultiArrays(int[,] arrA, int[,] arrB)
{
    if (arrA.GetLength(1) != arrB.GetLength(0)) //количество столбцов матрицы arrА не равно количеству строк матрицы arrВ.
    {
        return arrA;
    }
    int[,] mass = new int[arrA.GetLength(0), arrB.GetLength(1)];
    for (int i = 0; i < arrA.GetLength(0); i++)
    {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
            for (int k = 0; k < arrB.GetLength(0); k++)
            {
                mass[i, j] += arrA[i, k] * arrB[k, j];
            }
        }
    }
    return mass;
}

Console.Clear();
Console.Write("Введите строки, столбцы 1 матрицы через пробел: ");
string[] s = Console.ReadLine()!.Split(" ");
int rows = int.Parse(s[0]);
int colums = int.Parse(s[1]);

Console.Write("Введите начальное и конечное число случайной регенерации чисел для 1 матрицы через пробел: ");
string[] s1 = Console.ReadLine()!.Split(" ");
int minval = int.Parse(s1[0]);
int maxval = int.Parse(s1[1]);

Console.Write("Введите строки, столбцы 2 матрицы через пробел: ");
string[] s2 = Console.ReadLine()!.Split(" ");
int rows1 = int.Parse(s2[0]);
int colums1 = int.Parse(s2[1]);

Console.Write("Введите начальное и конечное число случайной регенерации чисел для 2 матрицы через пробел: ");
string[] s3 = Console.ReadLine()!.Split(" ");
int minval1 = int.Parse(s3[0]);
int maxval1 = int.Parse(s3[1]);

int[,] arrayA = NewArray(rows, colums, minval, maxval);
int[,] arrayB = NewArray(rows1, colums1, minval1, maxval1);
int[,] arrayC = MultiArrays(arrayA, arrayB);

Console.WriteLine();
if (arrayC == arrayA)
{
    Console.WriteLine("Кол-во столбцов 1 матрицы не совпадает с кол-вом строк 2 матрицы");
    Console.WriteLine("Матрицы нельзя перемножить");
}
else
{
    Console.WriteLine("Матрица 1:");
    PrintArray(arrayA);
    Console.WriteLine("Матрица 2:");
    PrintArray(arrayB);
    Console.WriteLine("Произведение двух матриц: ");
    PrintArray(arrayC);
}