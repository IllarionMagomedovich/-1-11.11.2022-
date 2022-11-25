// задача 26: Напишите программу, которая принимает на вход число и выдает
// количество цифр в числе.

// 456 = 3
// 78 = 2
// 89126 = 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitLength(int num)
{
    int n = 1;
    for(int i = 0; i < 10 ; i++ )
    {
        num = num / 10;
        if(num != 0) n++;
        else break;

    }
    return n;
}
int digitlength = DigitLength(number);
Console.WriteLine(digitlength);

// Способ через цикл while
int Digits(int num)
{
    int count = 0;
    while(num > 0)
    {
        num = num / 10;
        count++;
    }
    return count == 0 ? 1 : count;
}
if (number < 0) number = -number;
int result = Digits(number);
Console.WriteLine($"Количство цифр в числе {number} = {result} ");


Console.WriteLine(Math.Abs(-123));