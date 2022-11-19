// Example 13.
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 = 5
// 78 = третьей цифры нет
// 32679 = 6


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 1 & num < 100)
{  
    Console.WriteLine("Третьей цифры нет");
}
else if(num < -1)
{
   while(num < -1000)
   {
    num = num / 10;
   }
   num = num % 10;
   Console.WriteLine(num);
}
 
else 
{
int ThirdDigit(int number)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    return number % 10;
}
Console.WriteLine(ThirdDigit(num));
}


