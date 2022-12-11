// Задача 55:
// Задайте двумерный массив. Напишите программу, которая заменяет
// строки на столбцы. В случае , если это невозможно, программа 
// должна вывести сообщение для пользователя.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");

    }

}

int[,] CreateModifidematrix(int[,] matrix)
{
    int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix2[i, j] = matrix[j, i];
        }
    }
    return matrix2;
}

// Второй способ
// bool CheckSquareMatrix(int[,] matrix)
// {
//     return matrix.GetLength(0) == matrix.GetLength(1);
// }

// void ReplaceRowsColumnsMatrix(int[,] matrix)
// {
//     int rows = matrix.GetLength(0);
//     int columns = matrix.GetLength(1);
//     for(int i = 0; i < rows -1; i++)
//     {
//         for (int j = i + 1; j < columns; j++)
//         {
//             int temp = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temp;

//         }
//     }
// }


int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
if (matrix.GetLength(0) != matrix.GetLength(1))
{
    Console.WriteLine("Замена невозможна");
}
else
{
    int[,] matrix2 = CreateModifidematrix(matrix);
    PrintMatrix(matrix2);
}