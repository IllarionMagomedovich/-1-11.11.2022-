﻿// Задача 29: Напишите программу, которая задает массив из 8 элементов
// заполненный псевдослучайными числами и выводит их на экран

// 1, 2, 5, 7, 19 = [1, 2, 5, 7, 19]
// 6, 1, 33 = [6, 1, 33]

int[] array = new int[8];
void RandomArray(int[] array)
{
   
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);

    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
RandomArray(array);
PrintArray(array);