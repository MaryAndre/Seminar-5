// Напишите функцию, которая принимает одно число - 
// высоту елочки и рисует ее в консоли звездочками.

void Elka(int arg)
{
    for (int i = 0; i <= arg; i++)
    {
        for (int j = 0; j < arg - i; j++)
        {
            Console.Write(" ");
        }
        for (int z = 0; z < i * 2 - 1; z++)
        {
            Console.Write("*");
        }
        Console.Write("\n");
    }
}

Console.Clear();
Console.Write("Высота елки: ");
int num = int.Parse(Console.ReadLine()!);

Elka(num);