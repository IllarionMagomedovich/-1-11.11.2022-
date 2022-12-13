// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());

int SumNaturalElement(int M, int N)
{
    
    if(M == N) return M;
    if (M < N) return N + SumNaturalElement(M, N - 1);
     else return N + SumNaturalElement (M, N + 1);
        

}

Console.Write(SumNaturalElement(m, n));
