// Задача 41:
// Пользователь вводит с клавиатуры М чисел. Посчитайте,
// сколько чисел больше 0 ввел пользователь.

// 0, 7. 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

// Console.WriteLine("Введите число: ");
// int numbers = Convert.ToInt32(Console.ReadLine());


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

Console.Write("Введите элементы(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


int Digits(int[] arr)
{
    int sum = 0;
    int[] count = new int [arr.Length];    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) 
        {
            sum ++;
        }
    }
    return sum;
}

int digit = Digits(array);
Console.WriteLine($"Чисел больше нуля {digit}");

// Console.Write("Введите числа через запятую: ");
// int[] numbers = Array.ConvertAll(Console.ReadLine(). Split(), int.Parse) ;
// PrintArray(numbers);
// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"количество значений больше 0 = {sum}");

