// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m != 0 && n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
}

Console.Clear();
Console.Write("Введите неотрицательное число M: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите неотрицательное число N: ");
int numberB = int.Parse(Console.ReadLine()!);

while (numberA < 0 || numberB < 0)
{
    Console.Clear();
    Console.WriteLine($"Число M или число N отрицательные. Введите заново!");
    Console.Write("Введите неотрицательное число M: ");
    int a = int.Parse(Console.ReadLine()!);
    numberA = a;
    Console.Write("Введите неотрицательное число N: ");
    int b = int.Parse(Console.ReadLine()!);
    numberB = b;
}

Console.WriteLine($"Итог: {AkkermanFunction(numberA, numberB)}");