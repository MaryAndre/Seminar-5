// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

double Dist(int x, int y, int z, int x1, int y1, int z1)
{
    double res;
    res = Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2) + Math.Pow(z - z1, 2));
    return res;
}

Console.WriteLine("Введите координату x точки А: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y точки А: ");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z точки А: ");
int z = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату x точки B: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату y точки B: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату z точки B: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Отрезок AB = {Dist(x, y, z, x1, y1, z1):f2}");