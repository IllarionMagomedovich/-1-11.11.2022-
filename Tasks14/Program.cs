// Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23.

// 14 = нет
// 46 = нет
// 161 = да


// Первый Метод
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

 bool Multiplicity (int number1)
{
     if (number1 % 7 == 0  & number1 % 23 == 0 ) return true;
     return false;
}
bool result = Multiplicity(num);
Console.WriteLine(result ? "Да" : "Нет");

// Второй метод
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = 0;

//  if (num % 7 == 0 & num % 23 == 0) Console.WriteLine ("Да");

//  else
//  {
//     if(num % 7 != 0 & num % 23 != 0);
//     Console.WriteLine("Нет");
//  }
 