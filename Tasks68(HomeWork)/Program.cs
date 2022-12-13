﻿// Задача 68: Напишите программу 
// вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


int PositiveNumAkker (int m , int n)
{
    if(m == 0) return  n + 1;
    else if(m > 0 && n == 0) return  PositiveNumAkker(m - 1, 1);
    else return  (PositiveNumAkker(m - 1, PositiveNumAkker(m, n - 1)));
}
Console.Write(PositiveNumAkker(m, n));