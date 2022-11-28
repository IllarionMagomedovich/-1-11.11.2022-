// Напишите программу, которая принимает на вход 
// число и выдает сумму цифр в числе.

// 452 = 11
// 82 = 10
// 9012 = 12
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int firstdigit = 0;
    int result = 0;
    while(num > 0)
    {
        firstdigit = num % 10;
        result = result + firstdigit;
        num = num / 10;
        
    }
    return result;
}
if(number < 0) number = -number;
int sumdigit = SumDigit(number);
Console.WriteLine($"Сумма чисел  {number} = {sumdigit} ");