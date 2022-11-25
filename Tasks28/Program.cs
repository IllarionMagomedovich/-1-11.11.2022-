// Задача 28: Напишите программу, которая принимает на вход число N и выдает
// произведение чисел от 1 до N.

// 4 = 24
// 5 = 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Multiplication(int num)
{   
    int com = 1;
    for( int i = 1; i <= num; i++)
    {
        com = com * i;
    }
    return com;
}
if(number > 0)
{
    int multiplication = Multiplication(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {multiplication}");
}


