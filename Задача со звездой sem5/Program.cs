// Задача "со звездочкой": Разобраться с алгоритмом сортировки 
// методом пузырька. Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] NewArray(int size, int minval, int maxval)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minval, maxval);
    }
    return array;
}

void Sort(int[] arr)
{
    Console.WriteLine("Отсортированный массив:");
    int temp = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] < arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
    Console.WriteLine(String.Join(", ", arr));
}

Console.WriteLine("Введите длину массива: ");
int n = int.Parse(Console.ReadLine()!);

int[] arr = NewArray(n, 1, 10);
Console.WriteLine(String.Join(", ", arr));
Sort(arr);