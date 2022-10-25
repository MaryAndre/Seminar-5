// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Рассчёт формулы:
// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1

// --> x = (b2 - b1) / (k1 - k2)
// --> y = k1 * x + b1 

double[] New(string[] arr)
{
    double[] array = new double[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = double.Parse(arr[i]);
    }
    return array;
}

double CoorXdot(double[] a)
{
    double x = (a[2] - a[0]) / (a[1] - a[3]);
    return x;
}

double CoorYdot(double[] b, double x)
{
    double y = b[1] * x + b[0];
    return y;
}

bool IsTriun(double[] a)
{
    //"a[0]==a[2] && a[1]==a[3]" -> прямые совпадают;
    //"a[1]==a[3]" - > прямые параллельны.
    return a[0] == a[2] && a[1] == a[3] || a[1] == a[3];
}

Console.Clear();       //        0   1   2   3
Console.Write("Введите значения b1, k1, b2, k2 через запятую c пробелом: ");
string[] sign = Console.ReadLine()!.Split(", ");
double[] array = New(sign);

double x1 = CoorXdot(array);
double y1 = CoorYdot(array, x1);

if (IsTriun(array))
{
    Console.Write("Нет точки пересечения!");
}
else
{
    Console.WriteLine($"Координаты точки пересечения: ({x1:f1}; {y1:f1})");
}