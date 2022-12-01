﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble (int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
  
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        
        
    }
    return arr;


}

void PrintArray (double[] arr)
{
    Console.Write("[");
     for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write($"{Math.Round (arr[i], 2)} ");
        else Console.Write($"{Math.Round (arr[i], 2)}");
          
    }
    Console.Write("]");
}
double MinArray(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
      if(arr[i] < min) min = arr[i];
     
    }
    return min;
}

double MaxArray(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        
    }
    return max;
}
double[] array = CreateArrayRndDouble(5, 0, 100);
PrintArray(array);
double minArr = Math.Round (MinArray(array), 2);
double maxArr = Math.Round (MaxArray(array), 2);
double result = Math.Round ((maxArr - minArr), 2);

Console.Write($" {maxArr} - {minArr} = {result}");


 
