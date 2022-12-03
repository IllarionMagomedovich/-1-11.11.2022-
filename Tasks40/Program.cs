// Задача 40:
// Напишите программу, которая принимает на вход три
// числа и проверяет, можеттли существовать 
// треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона
// треугольника меньше суммы двух других сторон.

bool Triagnle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.WriteLine("Введите сторону треугольника");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону треугольника");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите сторону треугольника");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Triagnle(a, b, c) ? "Да" : "Нет");

