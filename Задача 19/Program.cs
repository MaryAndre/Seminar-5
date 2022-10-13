// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Rev(int num1)
{
    int rev = 0;
    while (num1 > 0)
    {
        rev = rev * 10;
        rev = rev + num1 % 10;
        num1 = num1 / 10;
    }
    return (rev);
}

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

while (num < 10000 || num > 99999)
{
    Console.WriteLine("Введите пятизначное число: ");
    int num2 = int.Parse(Console.ReadLine()!);
    num = num2;
}
if (num == Rev(num))
{
    Console.WriteLine($"Да! число {num} палиндром");
}
else
{
    Console.WriteLine($"НЕТ! число {num} не палиндром");
}