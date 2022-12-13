// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("]");

    }

}

int[] SumElementsRows(int[,] matrix)
{
    
    
    int[] sumElements = new int[matrix.GetLength(0)];
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
         sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum  += matrix[i, j];
            sumElements[i] = sum;
        }
       
    }
    return sumElements;

}

(int, int) TheSmallestSummaRow(int[] array)
{
    int resultSumma = array[0];
    int resultRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < resultSumma)
        {
            resultSumma = array[i];
            resultRow = i;
        }
    }
    return (resultSumma, resultRow);
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

int [,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);

int[] sumElements  = SumElementsRows(array2D);
PrintArray(sumElements);

(int, int) theSmallestSummaRow = TheSmallestSummaRow(sumElements);
Console.WriteLine($"Минимальная сумма, строка = {theSmallestSummaRow}");
