// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

// первый метод
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void Square(int num)
// {
//     for (int i = 1; i <= num ; i++)
//     {
//         Console.WriteLine($"{i} -> {i*i}" );   
//     }
// }
// Square(number);

// Второй метод

int n = -1;
while(n < 1)
{
    Console.WriteLine("Введите число");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введены неверные данные");
}

string SqrTable(int n1)
{
    int count = 1;
    string table = "";
    while (count <= n1)
    {
        table = table + $"{count}|{count * count} \n";
        count++;
    }
    return table;
}

string sqrTable = SqrTable(n);
Console.WriteLine(sqrTable);
