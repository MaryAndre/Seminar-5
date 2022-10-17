// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] NewArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void EvenNum(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            even++;
        }
    }
    Console.WriteLine($"Кол-во четных элементов: {even}" );
}


Console.WriteLine("Введите длину массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] arr = NewArray(n);
EvenNum(arr);
Console.WriteLine(String.Join(",", arr));