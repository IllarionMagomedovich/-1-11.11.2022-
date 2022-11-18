// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом дургого

// 5, 25 = да
// -4, 16 = да
// 25, 5 = да
// 8, 9 = нет

// Первый метод
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2 * num2)
// {
//     Console.WriteLine("Да");
// }

// else if(num2 == num1 * num1)

// {
//     Console.WriteLine("Да");
// }

// else
// {
//     Console.WriteLine("Нет");
// }


// Второй метод

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Square (int number1, int number2)
{
    return (number1 == number2*number2) || (number2 == number1 * number1);
}
Console.WriteLine(Square(num1, num2)? "Да" : "Нет"); 
