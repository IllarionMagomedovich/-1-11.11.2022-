// Задача 25: Напишите цикл, который на вход принимает два числа
// (А и В) и возводит число А в натуральную степень В.

// 3, 5 = 243
// 2, 4 = 16

Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int Degree(int a1, int b1)
{
   int count = 1;
   while(count < b1)
   {
     a1 = a1 * a;
     count++;
   }
   return a1;
}
if(a < 0) a = -a;
int degree = Degree(a, b);
Console.WriteLine($"Степень числа {a} в {b} = {degree}");

