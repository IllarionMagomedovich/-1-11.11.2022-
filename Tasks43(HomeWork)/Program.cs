// Задача 43:
// Напишите программу, которая найдет точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1,k1,b2 и k2 задаются пользователем.


Console.WriteLine("Введите точчку b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точчку k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точчку b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точчку k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = 0;
x = (b2 - b1) / (k1 - k2);

double MetodY(double k2, double x, double b2)
{
    double y = (k2 * x + b2);
    double res = y;
    return res;
}

double result2 = MetodY(k2, x, b2);
double res = x;
// double resRound = Math.Round(res, result2, 2, MidpointRounding.ToZero);
Console.WriteLine ($"{res} {result2}");
// int x = (b2 - b1)/(k1 - k2);
// int y = (k2 * x + b2);

// Console.WriteLine($"X:{x}  Y:{y}");