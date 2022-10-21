// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] NewArray(int size, int minval, int maxval)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minval, maxval);
    }
    return array;
}

int SummOddIndexNum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

Console.WriteLine("Введите длину массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] arr = NewArray(n, -10, 10);
SummOddIndexNum(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {SummOddIndexNum(arr)}");
Console.WriteLine(String.Join(",", arr));