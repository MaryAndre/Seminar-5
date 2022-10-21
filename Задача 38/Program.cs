// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] NewArray(int size, int minval, int maxval)
{
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minval, maxval);
    }
    return array;
}

double MaxEl(double[] array)
{
    double maxel = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxel)
        {
            maxel = array[i];
        }
    }
    return maxel;
}

double MinEl(double[] array)
{
    double minel = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minel)
        {
            minel = array[i];
        }
    }
    return minel;
}

Console.WriteLine("Введите длину массива: ");
int n = int.Parse(Console.ReadLine()!);

double[] arr = NewArray(n, 1, 100);
Console.WriteLine(String.Join(", ", arr));

double min = MinEl(arr);
double max = MaxEl(arr);

Console.WriteLine($"Разница между максимальным и минимальным значением массива: {max - min}");