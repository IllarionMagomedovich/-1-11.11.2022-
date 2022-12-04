// Задача 41:
// Пользователь вводит с клавиатуры М чисел. Посчитайте,
// сколько чисел больше 0 ввел пользователь.

// 0, 7. 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)

{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
