// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет является ли этот день выходным.

// 6 = да
// 7 = да
// 1 = нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Holiday (int num)
{
    return (num == 6) || (num == 7);
        
}
 Console.WriteLine(Holiday(number)? "Да" : "Нет"); 

if (number > 7)
    Console.WriteLine("Такого дня нет");


