// Задача 69:
// Напишите программу, которая на вход принимает 
// два числа А и в
// и возводит число А в целую степень числа В 
// с помощью реурсии

// А = 3; B = 5 -> 243 (3*5)
// A = 2; B = 3 -> 8 (2*3)

Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());

// первый способ
// int DegreeNumber(int A, int degree)
// {
//     if(degree == 0) return 1;
//     return  DegreeNumber(A, degree - 1) * A;
// }
// Console.WriteLine(DegreeNumber(a, b));


int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath (a * a, n / 2);
    else return PowerRecMath (a, n - 1) * a;
}

Console.WriteLine(PowerRecMath(a, b));

// double Faktorial(int n)
// {
//  if (n==1)return 1;
//  else
//  return n*Faktorial(n-1);
// }

