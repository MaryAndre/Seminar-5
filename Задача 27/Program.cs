// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int Summ(int num1)
{
    int sum = 0;
    while (num1 != 0)
    {
        sum += num1 % 10;
        num1 /= 10;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр в числе {num}: {Summ(num)}");