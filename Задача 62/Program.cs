// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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
    Console.WriteLine();
}


int[,] array = new int[4, 4];
int x = 0;
int y = 0;
int size = array.GetLength(0);
int count = 1;
while (size > 0)
{
    for (int i = y; i < y + size; i++)
    {
        array[x, i] = count++;
    }

    for (int j = x + 1; j < x + size; j++)
    {
        array[j, y + size - 1] = count++;
    }

    for (int i = y + size - 2; i >= y; i--)
    {
        array[x + size - 1, i] = count++;
    }

    for (int i = x + size - 2; i >= x + 1; i--)
    {
        array[i, y] = count++;
    }
    x++;
    y++;
    size -= 2;
}

Console.WriteLine("Массив:");
PrintArray(array);