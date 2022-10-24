// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


int[] NewArray(string[] arr)
{
    int[] array = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = int.Parse(arr[i]);
    }
    return array;
}

int AbZero(int[] array)
{
    int result = 0;
    foreach (int el in array)
    {
        result += el > 0 ? 1 : 0;
    }
    return result;
}

Console.Clear();
Console.Write("Введите значения массива через запятую c пробелом: ");
string[] sign = Console.ReadLine()!.Split(", ");

int[] array = NewArray(sign);
Console.WriteLine($"Кол-во чисел больше 0: {AbZero(array)} ");