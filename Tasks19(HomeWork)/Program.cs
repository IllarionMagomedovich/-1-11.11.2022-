﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 = нет
// 23432 = да
// 12821 = да


Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;


if (number < 10000) 
    {
      Console.WriteLine("Введенно не пятизначное число");
    }
    
     while(number > 0)
    {
        result = result * 10;
        result = result + number % 10;
        number = number / 10;
    }

  Console.WriteLine(result);
    

//    if(result % 10 == number / 10000) Console.WriteLine("Да");
//    else Console.WriteLine("Нет");
    
   


// Console.WriteLine("Ведите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// int RemoveSecondDigit(int n)
// {
//     int firstDigit = n % 10;
//     int result = firstDigit;
//     return result;
// }
// Console.WriteLine(RemoveSecondDigit(num));