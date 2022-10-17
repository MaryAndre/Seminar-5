// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] New()
{
    Console.Write("Введите значения массива через запятую c пробелом: ");
    string[] sign = Console.ReadLine()!.Split(", ");
    int[] array;
    if (sign.Length > 8)
    {
        array = new int[sign.Length];
    }
    else
    {
        array = new int[8];
    }
    for (int i = 0; i < sign.Length; i++)
    {
        array[i] = System.Int32.Parse(sign[i]);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("Вывод заданного массива: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i != arr.Length - 1)
        {
            Console.Write(", ");

        }
    }

}

PrintArray(New());