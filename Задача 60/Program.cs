// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[] NewArray1d(int row, int col, int dep)
{
    int[] arr = new int[row * col * dep];
    if ((100 - 10) < arr.Length)
    {
        return arr;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        int num = new Random().Next(10, 100);
        if (arr.Contains(num))
        {
            i--;
        }
        else
        {
            arr[i] = num;
        }
    }
    return arr;
}

int[,,] NewArray1dToArray3d(int row, int col, int dep, int[] array1d)
{
    int[,,] arr = new int[row, col, dep];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                int index = k + j * dep + i * col * dep;
                arr[i, j, k] = array1d[index];
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }

    }

}

Console.Clear();
Console.Write("Введите строки, столбцы и глубину трехмерного массива через пробел: ");
string[] s = Console.ReadLine()!.Split(" ");
int numA = int.Parse(s[0]);
int numB = int.Parse(s[1]);
int numC = int.Parse(s[2]);

int[] array1d = NewArray1d(numA, numB, numC);
int[,,] array3d = NewArray1dToArray3d(numA, numB, numC, array1d);

if (array1d[0] < 10)
{
    Console.WriteLine("Диапазон чисел меньше, чем размерность массива");
}
else
{
    Console.WriteLine("Трёхмерный массив:");
    PrintArray(array3d);
}