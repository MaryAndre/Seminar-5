// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Mult(int num1, int num2)
{
    int mult = 1;

    for (int i = 0; i < num2; i++)
    {
        mult *= num1;
    }
    return mult;
}

Console.Clear();

Console.WriteLine("Введите основание степени A: ");
int numA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите показатель B: ");
int numB = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число: {numA} в натуральной степени: {numB}, равно: {Mult(numA, numB)} ");