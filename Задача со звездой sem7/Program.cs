// Задача со звездочкой: Написать программу для
// перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994

int Value(char r)
{
    if (r == 'I')
        return 1;
    if (r == 'V')
        return 5;
    if (r == 'X')
        return 10;
    if (r == 'L')
        return 50;
    if (r == 'C')
        return 100;
    if (r == 'D')
        return 500;
    if (r == 'M')
        return 1000;
    return -1;
}

int RomanToDecimal(string str)
{
    int res = 0;
    for (int i = 0; i < str.Length; i++)
    {
        int num1 = Value(str[i]);
        if (i < str.Length - 1)
        {
            int num2 = Value(str[i + 1]);
            if (num1 >= num2)
            {
                res = res + num1;
            }
            else
            {
                res = res + num2 - num1;
                i++;
            }
        }
        else
        {
            res = res + num1;
            i++;
        }
    }
    return res;
}

Console.Clear();
Console.Write("Введите римскую цифру: ");
string str = Console.ReadLine()!;
Console.WriteLine($"Римская цифра {str} в десятичной арабской: {RomanToDecimal(str)}");