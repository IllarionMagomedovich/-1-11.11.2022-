// Задача 42:
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

// 45 = 10101
// 3 = 11
// 2 = 10

// string Binary(int numb)
// {
//     string bin = string.Empty;
//     while(numb > 0)
//     {
//         bin = numb % 2 + bin;
//         numb /= 2;
//     }
//     return bin;
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Binary(number));



// int[] CreateArrayRndInt (int size, int min, int max)
// {
//     int [] arr = new int[size];
//     Random rnd = new Random();
    
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

void PrintArray (int[] arr, string beginStr, string separatorElems, string endStr)

{
    Console.Write(beginStr);
     for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write($"{arr[i]}{separatorElems} ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine(endStr);
}

int[] Binary(int numb)
{
    int numb1 = numb;
    int digits = 0;
    while(numb > 0)
    {
        numb1 /= 2;
        digits += 1;
    }
    int[] bin = new int[digits];
    for(int i = 0; i < bin.Length; i++)
    {
        bin[i] = numb % 2;
        numb /= 2;   
    }
    Array.Reverse(bin);
    return bin;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] binary = Binary(number);
PrintArray(binary, "", "", "");