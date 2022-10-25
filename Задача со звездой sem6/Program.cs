// Задача со звездочкой: Напишите программу, которая реализует обход введенного 
// двумерного массива, начиная с крайнего нижнего левого элемента против часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9


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
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] arr = NewArray(3, 3);
PrintArray(arr);
Console.WriteLine();




int i = 2;
int j = -1;

while (j != i)
{
    Console.Write($"{arr[i, ++j]} ");
}
while (i != 0)
{
    Console.Write($"{arr[--i, j]} ");
}
while (j != 0)
{
    Console.Write($"{arr[i, --j]} ");
}
while (i < 1)
{
    Console.Write($"{arr[++i, j++]} ");
}
Console.Write($"{arr[i, j]} ");