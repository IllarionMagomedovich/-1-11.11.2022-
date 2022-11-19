// Example 13.
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 = 5
// 78 = третьей цифры нет
// 32679 = 6


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int ThirdDigit(int number)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    return number % 10;
}
if (num < 100 & num > -1000)
{  
    Console.WriteLine("Третьей цифры нет");
}
else 
{
   Console.WriteLine(ThirdDigit(num));
}

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = 0;
// int num1 = 0;
// if(number > 99 & number <= 1000)
// {    
//     result = number % 10;
//     Console.WriteLine(result);

// }
  
// else if(number > 1000)
// {
//   num1 = number / 10;
//   result = num1 % 10;
//   Console.WriteLine(result);
// }
// else
// {
//   if(number < 99)
//  Console.WriteLine("Третьей цифры нет");
// }


