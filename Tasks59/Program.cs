// Задача 59:
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

// Например задан массив : 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Наименьший элемент - 1, на выходе получим следующий массив:

// 9 2 3
// 4 2 4
// 2 6 7



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

void RowColummnIndexMinElem(int[,] matrix, out int indexRow, out int indexColumn)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int min = matrix[0,0];
    indexRow = 0;
    indexColumn = 0;
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            if(matrix[i,j] < min) 
            {
                min = matrix[i, j];
                indexRow = i;
                indexColumn = j;
            }

        }
    }
}

int[,] DeleteRowColumnsMinElemeMatrix(int[,] matrix, int indexRows, int indexColumns)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[,] matrix2 = new int[rows - 1, columns - 1]; 
    int m = 0;
    for(int i = 0; i < rows - 1; i++)
    {
        int n = 0;
        if(m == indexRows) m++;
        for(int j = 0; j < columns - 1; j++)
        {
            if(n == indexColumns) n++;
            matrix2[i,j] = matrix[m,n];
            n++;
            // if(i != indexRows && j != indexColumns)
            // matrix2[i, j] = matrix[i, j];
        }
        m++;
    }
    return matrix2;
}

int [,] array2D = CreateMatrixRndInt(4, 4, 1, 30);
PrintMatrix(array2D);
Console.WriteLine();
int rowIndex1, columnIndex1;
RowColummnIndexMinElem(array2D, out rowIndex1, out columnIndex1);
Console.WriteLine($"Минимальное число - {array2D[rowIndex1,columnIndex1]}");
int[,] matrix2 = DeleteRowColumnsMinElemeMatrix(array2D, rowIndex1, columnIndex1);
PrintMatrix(matrix2);