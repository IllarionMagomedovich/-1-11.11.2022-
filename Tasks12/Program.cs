// Напишите программу, которая будет принимать на вход два числа и выводить
// является ли первое число кратным второму. Если число 1 не кратно числу 2,
// то программа выводит остаток от деления.

// 34, 5 = не кратно, остаток 4
// 16, 4 = кратно

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Первый метод
bool Multiplicity (int num1, int num2)
{
     if (num1 % num2 == 0) return true;
     return false;
}
bool result = Multiplicity(number1, number2);
Console.WriteLine(result ? "Кратно" : $"Не кратно, остаток = {number1 % number2} ");


// Второй метод
// if (number1 % number2 == 0) Console.WriteLine("Кратно");


// else 
// { 
//      int result = number1 % number2;
//      if(result == 0); 
//     Console.WriteLine($"Не кратно, остаток  {result} ");
// }
