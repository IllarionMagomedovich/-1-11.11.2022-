// Задача 65:
// Задайте значения M и n.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от M до n.

// M = 1; n = 5 -> "1, 2, 3, 4, 5"
// M = 4; n = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());

NaturalDigits(m, n);

void NaturalDigits(int M, int N)
{
    if (M > N)
    {
        
        NaturalDigits(M, N + 1);
        Console.Write($"{N} ");

    }
    if (M < N)
    {
        Console.Write($"{M} ");
        NaturalDigits(M + 1, N);


    }
    if(M == N)
    Console.Write($"{M} ");

}
