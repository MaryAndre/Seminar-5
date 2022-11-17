// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumElemMtoN(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return start + SumElemMtoN(start + 1, end);
}

Console.Clear();
Console.Write("Введите начальное число M: ");
int startNum = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число N: ");
int endNum = int.Parse(Console.ReadLine()!);

while (endNum < startNum)
{
    Console.Clear();
    Console.WriteLine($"Начальное число M больше конечного числа N. Введите заново!");
    Console.Write("Введите начальное число M: ");
    int a = int.Parse(Console.ReadLine()!);
    startNum = a;
    Console.Write("Введите конечное число N: ");
    int b = int.Parse(Console.ReadLine()!);
    endNum = b;
}

int sumOfElem = SumElemMtoN(startNum, endNum);
Console.WriteLine($"Cумма натуральных элементов в промежутке от {startNum} до {endNum}: {sumOfElem} ");