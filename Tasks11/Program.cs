// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(101, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 1000 --> {number}");

int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}

Console.WriteLine(RemoveSecondDigit(number));
