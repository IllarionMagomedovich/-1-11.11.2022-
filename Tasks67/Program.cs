// Задача 67:
// Напишите программу, которая будет принимать 
// на вход число и возвращать  сумму его цифр.

// 453 = 12

// 45 = 9

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
     return num != 0 ? num % 10 + SumNumber(num / 10) : 0;
}
Console.WriteLine(SumNumber(Math.Abs(number)));

// double Faktorial(int n)
// {
//  if (n==1)return 1;
//  else
//  return n*Faktorial(n-1);
// }

// for(int i =1;i<40;i++)
// {
// Console.WriteLine($"{i}!={Faktorial(i)}");
// }