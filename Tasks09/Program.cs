// Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 --> {number}");


// int firstDigit = number / 10;  // 7
// int secondDigit = number % 10; //8

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифрая числа --> {secondDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;  // 7
    int secondDigit = num % 10; //8 
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit; // else

    int max = firstDigit > secondDigit ? firstDigit : secondDigit;
    return max;
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");
