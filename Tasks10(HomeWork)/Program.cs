﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

 if(number < 99)  
{
    Console.WriteLine("Число не трехзначное");
}  

else
{
int SecondDigit(int num)
 {
     int secondDigit = num % 100;
     int result =secondDigit / 10;
     return result;
}
 

Console.WriteLine(SecondDigit(number));      
} 
 






